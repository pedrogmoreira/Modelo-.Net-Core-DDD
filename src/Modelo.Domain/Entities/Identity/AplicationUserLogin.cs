﻿using Microsoft.AspNetCore.Identity;
using System;

namespace Modelo.Domain.Entities.Identity
{
    public class AplicationUserLogin : IdentityUserLogin<Guid>
    {
        public ApplicationUser User { get; set; }
    }
}