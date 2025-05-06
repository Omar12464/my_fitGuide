﻿using Core.Identity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Allergy:ModelBase
    {
        public string Name { get; set; }
        public ICollection<UserAllergy> userAllergy { get; set; } = new HashSet<UserAllergy>();
    }
}
