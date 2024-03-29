﻿using Core2Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2Identity.Infrastructure
{
    public class CustomPasswordValidator : IPasswordValidator<ApplicationUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError()
                {
                    Code="PasswordContainsUserName",
                    Description="Password can not contain username"
                });
            }
            if (password.Contains("12345"))
            {
                errors.Add(new IdentityError()
                {
                    Code = "PasswordContainsSequence",
                    Description = "Password can not contain numeric sequence"
                });
            }

            return Task.FromResult(errors.Count == 0 ?
                IdentityResult.Success :
                IdentityResult.Failed(errors.ToArray()));
        }
    }
}
