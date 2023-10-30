﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }
        

    }
}
