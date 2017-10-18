﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Register.Models
{

    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthday { get; set; }
    }

}
