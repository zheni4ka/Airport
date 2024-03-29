﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Country
    {
        public int Id { get; set; }
        [Required] [MaxLength(40)]public string Name { get; set; }
        public ICollection<Plane> Planes { get; set; } = new HashSet<Plane>();
    }
}
