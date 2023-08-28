using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Client
    {
        public int Id { get; set; }
        [Required] [MaxLength(100)] public string Name { get; set; }
        [Required] [MaxLength(100)] public string Surname { get; set; }
        [MinLength(10)] public string Email { get; set; }
        [Required] [ForeignKey("Sex")] public int SexId { get; set; }
        public Sex Sex { get; set; }
        public Account Account { get; set; }
        [Required] [ForeignKey("Account")] public int AccountId { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}