﻿namespace UrbanSolution.Web.Models.Issues
{
    using AutoMapper;
    using UrbanSolution.Services.Mapping;
    using UrbanSolution.Models;
   
    public class IssueMapInfoBoxModel : IMapFrom<UrbanIssue>, IHaveCustomMappings
    {
        public int Id { get; set; }

        //public string Title { get; set; }

        //public string PictureUrl { get; set; }

        //public string PictureThumbnailUrl { get; set; }

        //public string Description { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<UrbanIssue, IssueMapInfoBoxModel>()
                .ForMember(x => x.Latitude, m => m.MapFrom(u => u.Latitude.ToString().Replace(",", ".")))
                .ForMember(x => x.Longitude, m => m.MapFrom(u => u.Longitude.ToString().Replace(",", ".")));
                //.ForMember(x => x.PictureUrl, m => m.MapFrom(u => u.CloudinaryImage.PictureUrl))
                //.ForMember(x => x.PictureThumbnailUrl, m => m.MapFrom(u => u.CloudinaryImage.PictureThumbnailUrl));
        }
    }
}
