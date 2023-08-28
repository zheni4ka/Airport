using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Plane
    {
        public int Id { get; set; }
        [Required][MaxLength(50)] public string Name { get; set; }
        public PlaneType Type { get; set; }
        [Required] [ForeignKey("PlaneType")] public int PlaneTypeId { get; set; }
        [Required] public int MaxPassengersCount { get; set; }
        public Country Country { get; set; }
        [Required] [ForeignKey("Country")] public int CountryId { get; set; }
    }
}
