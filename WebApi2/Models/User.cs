﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }

    }
}
