﻿namespace UrbanSolution.Services.Tests.Seed
{
    using System;
    using UrbanSolution.Models;

    public class UserCreator
    {
        private const string DefaultUserName = "DefaultUserName";

        public static User Create(RegionType? region = null)
        {
            return new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = DefaultUserName,
                ManagedRegion = region ?? RegionType.All
            };

        }
    }
}
