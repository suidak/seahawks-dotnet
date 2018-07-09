using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seahawks.Domain.Entities
{
    public class Appointment
    {
        public Appointment()
        {

        }
        public int Id { get; set; }
        public string Description { get; set; }

        [ForeignKey("UserId")]
        public user User { get; set; }
        
        public int UserId { get; set; }
    }
}
