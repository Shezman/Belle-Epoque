using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CosmeticServices.Models;

namespace CosmeticServices.DAL
{
    public class CosmeticInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<CosmeticContext>
    {
        protected override void Seed(CosmeticContext context)
        {
            var clients = new List<Client>
            {
                new Client {FirstMidName = "Sherman", LastName="Tanuwidjaja"},
                new Client {FirstMidName = "Aja", LastName="Brofferio"},
                new Client {FirstMidName = "Kendra", LastName="Irina"},
                new Client {FirstMidName = "Quynh", LastName="Nguyen"},
                new Client {FirstMidName = "Reed", LastName="Jarvis"},
                new Client {FirstMidName = "Amit", LastName="Toor"}
            };
            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();

            var services = new List<Service>
            {
                new Service {ServiceID=101, Title="Custom European Facial", Price=50},
                new Service {ServiceID=102, Title="Anti-Stress Facial", Price=20},
                new Service {ServiceID=103, Title="Express Facial", Price=15},
                new Service {ServiceID=104, Title="Back Facial", Price=18}
            };
            services.ForEach(s => context.Services.Add(s));
            context.SaveChanges();

            var appointments = new List<Appointment>
            {
                new Appointment{ClientID=1, ServiceID=101, AppointmentDateTime=DateTime.Parse("2018-09-01 11:00:00") },
                new Appointment{ClientID=2, ServiceID=102, AppointmentDateTime=DateTime.Parse("2018-07-04 18:30:00") },
                new Appointment{ClientID=3, ServiceID=102, AppointmentDateTime=DateTime.Parse("2018-08-22 13:00:00") },
                new Appointment{ClientID=4, ServiceID=103, AppointmentDateTime=DateTime.Parse("2018-07-30 15:15:00") },
                new Appointment{ClientID=6, ServiceID=104, AppointmentDateTime=DateTime.Parse("2018-11-05 09:30:00") }
            };
            appointments.ForEach(s => context.Appointmets.Add(s));
            context.SaveChanges();
        }
    }
}