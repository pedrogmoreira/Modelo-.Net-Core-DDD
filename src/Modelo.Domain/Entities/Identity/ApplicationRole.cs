using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Modelo.Domain.Entities.Identity
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole(Guid id,string name)
        {
            Id = id;
            Name = name;
        }
        public ICollection<ApplicationRoleClaim> RoleClaims { get; set; }
        public ICollection<AplicationUserRole> UserRoles { get; set; }
    }
}