using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }

        public ICollection<AplicationUserClaim> UserClaims { get; set; }
        public ICollection<AplicationUserLogin> UserLogins { get; set; }
        public ICollection<ApplicationUserToken> UserTokens { get; set; }
        public ICollection<AplicationUserRole> UserRoles { get; set; }
    }
}