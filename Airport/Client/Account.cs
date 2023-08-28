using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Account
    {
        public int Id { get; set; }
        [Required] [MaxLength(20)] public string Login { get; set; }
        [Required] [MaxLength(20)] public string Password { get; set; }
        [Required] [ForeignKey("Client")] public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
