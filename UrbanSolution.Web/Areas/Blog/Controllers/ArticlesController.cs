﻿namespace UrbanSolution.Web.Areas.Blog.Controllers
{
    using Infrastructure.Extensions;
    using Infrastructure.Filters;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using UrbanSolution.Models;
    using UrbanSolution.Services.Blog;
    using UrbanSolution.Web.Models.Areas.Blog;
    using UrbanSolution.Web.Models.Common;
    using static UrbanSolutionUtilities.WebConstants;

    [Area(BlogArea)]
    [Authorize(Roles = BlogAuthorRole)]
    public class ArticlesController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IBlogArticleService articles;

        public ArticlesController(
            UserManager<User> userManager, IBlogArticleService articles)
        {
            this.userManager = userManager;
            this.articles = articles;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int page = 1)
        {
            var model = new ArticleListingViewModel
            {
                Articles = await this.articles.AllAsync<BlogArticleListingModel>(page),
                PagesModel = new PagesModel
                {
                    TotalItems = await this.articles.TotalAsync(),
                    CurrentPage = page,
                    ItemsOnPage = ArticlesPageSize
                }
            };

            return this.View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var model = await this.articles.GetAsync<ArticleDetailsModel>(id);

            var user = await this.userManager.GetUserAsync(this.User);

            this.ViewData[ViewDataUsernameKey] = user.UserName;

            return this.ViewOrNotFound(model);
        }

        public IActionResult Create()
        { 
            return this.View();
        }

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Create(PublishArticleInputModel model)
        {            
            var userId = this.userManager.GetUserId(User);

            var articleId = await this.articles.CreateAsync(model.Title, model.Content, model.PictureFile, userId);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await this.articles.GetAsync<EditArticleViewModel>(id);

            return this.ViewOrNotFound(model);
        }

        [ServiceFilter(typeof(ValidateArticleIdExistsAttribute))]
        [ValidateModelState]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditArticleViewModel model)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            bool isUpdated = await this.articles.UpdateAsync(id, user.Id, model.Title, model.Content);

            if (!isUpdated)
            {
                return this.RedirectToAction("Details", new {Area = "Blog", id})
                    .WithDanger(string.Empty, CantEditAnotherBloggerArticle);
            }

            return this.RedirectToAction("Details", new {Area = "Blog", id})
                .WithSuccess(string.Empty, SuccessfullyEditedArticle);
        }

        [ServiceFilter(typeof(ValidateArticleIdExistsAttribute))]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            bool isDeleted = await this.articles.DeleteAsync(id, user.Id);

            if (!isDeleted)
            {
                return this.RedirectToAction("Index", new { Area = "Blog" })
                    .WithDanger(string.Empty, CantDeleteArticle);
            }

            return this.RedirectToAction("Index", new { Area = "Blog" })
                .WithSuccess(string.Empty, SuccessfullyDeletedArticle);
        }

    }
}
