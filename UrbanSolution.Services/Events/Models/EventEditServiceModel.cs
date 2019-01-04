﻿namespace UrbanSolution.Services.Events.Models
{
    using Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using UrbanSolution.Models;
    using static Utilities.ServiceConstants;
    using static UrbanSolution.Models.Utilities.DataConstants;

    public class EventEditServiceModel : IMapFrom<Event>, IValidatableObject
    {
        [Required]
        [StringLength(EventTitleMaxLength, MinimumLength = EventTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(EventDescriptionMaxLength, MinimumLength = EventDescriptionMinLength)]
        public string Description { get; set; }

        [Display(Name = "Starting")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ending")]
        public DateTime EndDate { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string CreatorId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.StartDate <= DateTime.UtcNow.AddDays(1))
            {
                yield return new ValidationResult(EventStartDateRestriction);
            }

            if (this.EndDate < this.StartDate.AddHours(1))
            {
                yield return new ValidationResult(EventEndDateRestriction);
            }

            if (string.IsNullOrEmpty(this.Latitude))
            {
                yield return new ValidationResult(NoCoordinatesValidationError);
            }
        }

    }
}