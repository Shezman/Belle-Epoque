using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticServices.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}