using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Flights
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public ICollection<Client> Clients { get; set; } = new HashSet<Client>();        
        [Required] [ForeignKey("Plane")]public int PlaneId { get; set; }
        public Plane Plane { get; set; }
        public DateOnly DepartueDate { get; set; }
        public DateOnly ArrivalDate { get; set; }
        [ForeignKey("City")] public int DeparturePlaceId { get; set; }
        public City DeparturePlace { get; set; }
        [ForeignKey("City")]public int ArrivalPlaceId { get; set; }
        public City ArrivalPlace { get; set; } 
    }
}
