using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticServices.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int ServiceID { get; set; }
        public int ClientID { get; set; }
        public DateTime AppointmentDateTime { get; set; }

        public virtual Service Service { get; set; }
        public virtual Client Client { get; set; }
    }
}