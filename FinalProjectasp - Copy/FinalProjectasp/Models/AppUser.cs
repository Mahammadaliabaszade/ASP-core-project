﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectasp.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
