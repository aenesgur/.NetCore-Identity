﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Core2Identity.Models
{
    public class RoleDetails
    {
        public IdentityRole Role { get; set; }

        public IEnumerable<ApplicationUser> Members { get; set; }
        public IEnumerable<ApplicationUser> NonMembers { get; set; }

    }

    public class RoleeditModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }

    }
}
