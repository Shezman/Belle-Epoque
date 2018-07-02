using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticServices.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; } 
    }
}