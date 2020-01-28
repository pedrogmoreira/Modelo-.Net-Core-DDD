using Microsoft.AspNetCore.Identity;
using System;

namespace Modelo.Domain.Entities.Identity
{
    public class ApplicationUserToken : IdentityUserToken<Guid>
    {
        public ApplicationUser User { get; set; }
    }
}