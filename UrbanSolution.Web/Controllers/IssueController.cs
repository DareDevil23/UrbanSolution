﻿namespace UrbanSolution.Web.Controllers
{
    using Infrastructure.Extensions;
    using Infrastructure.Filters;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UrbanSolution.Models;
    using UrbanSolution.Services.Models;
    using static Infrastructure.WebConstants;

    public class IssueController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IIssueService issues;

        public IssueController(IIssueService issues, UserManager<User> userManager)
        {
            this.issues = issues;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(IssuesSortAndFilterModel model)
        {
            var modelIssues = await this.issues.AllAsync(isApproved: true, model.RowsCount, model.Page, model.RegionFilter, model.TypeFilter, model.SortType);

            var issueModel = await this.GetModelForListingIssuesAsync(modelIssues, model.Page);

            return this.View(issueModel);
        }

        [ServiceFilter(typeof(ValidateIssueIdExistsAttribute))]
        public async Task<IActionResult> Details(int id)
        {            
            if(this.User.IsInRole(ManagerRole))
            {
                var user = await this.userManager.GetUserAsync(this.User);

                this.ViewData[ViewDataManagerRegionKey] = user.ManagedRegion?.ToString();
            }

            var issueModel = await this.issues.GetAsync<UrbanIssueDetailsServiceModel>(id);

            if (issueModel == null)
            {
                return this.RedirectToAction("Index").WithDanger("", NoIssueInDb);
            }

            return this.View(issueModel);
        }

        private async Task<IssuesListingViewModel> GetModelForListingIssuesAsync(
            IEnumerable<UrbanIssuesListingServiceModel> modelIssues, int page)
        {
            var totalIssues = await this.issues.TotalAsync(isApproved: true);

            var model = new IssuesListingViewModel
            {
                Issues = modelIssues,
                TotalIssues = totalIssues,
                CurrentPage = page
            };

            return model;
        }

    }
}
