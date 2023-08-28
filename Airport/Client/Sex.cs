﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Sex
    {
        public int Id { get; set; }
        [Required] [MaxLength(100)] public string Name { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
