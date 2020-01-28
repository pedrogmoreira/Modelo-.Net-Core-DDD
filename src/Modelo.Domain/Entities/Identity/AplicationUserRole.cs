using Microsoft.AspNetCore.Identity;
using System;

namespace Modelo.Domain.Entities.Identity
{
    public class AplicationUserRole : IdentityUserRole<Guid>
    {
        public ApplicationRole Role { get; set; }
        public ApplicationUser User { get; set; }
    }
}