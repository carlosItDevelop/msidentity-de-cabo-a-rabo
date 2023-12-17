using AspnIdentityClaims.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnIdentityClaims.IdentityPolicy
{
    public class CustomPasswordPolicy : PasswordValidator<AppUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            IdentityResult result = await base.ValidateAsync(manager, user, password);

            List<IdentityError> errors = result.Succeeded ? new List<IdentityError>() : 
                result.Errors.ToList();

            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError
                {
                    Description = "A senha não pode conter o nome do usuário"
                });
            }

            if (password.Contains("123"))
            {
                errors.Add(new IdentityError
                {
                    Description = "A senha não pode conter a sequência 123"
                });
            }
            return errors.Count == 0 ? IdentityResult.Success :
                               IdentityResult.Failed(errors.ToArray());
        }
    }
}
