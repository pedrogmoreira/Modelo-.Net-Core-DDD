using Microsoft.AspNetCore.Identity;
using System;

namespace Modelo.Domain.Entities.Identity
{
    public class AplicationUserClaim : IdentityUserClaim<Guid>
    {
        public ApplicationUser User { get; set; }
    }
}