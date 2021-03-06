﻿namespace UrbanSolution.Models
{
    using System;

    public class UsersWithRoles
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public string UserRoles { get; set; }

        public string UserNotInRoles { get; set; }
    }
}
