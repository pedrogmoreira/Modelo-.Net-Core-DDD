using Microsoft.AspNetCore.Identity;
using System;

namespace Modelo.Domain.Entities.Identity
{
    public class ApplicationRoleClaim : IdentityRoleClaim<Guid>
    {
        public ApplicationRole Role { get; set; }
    }
}