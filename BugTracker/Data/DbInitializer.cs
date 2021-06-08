using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BugTracker.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MvcTicketContext context)
        {
            context.Database.EnsureCreated();

            if(context.Ticket.Any())
            {
                return;
            }

            var tickets = new Ticket[]
            {
                new Ticket{ Id = 1, Title="Hello", Body="Test", CreationDate=DateTime.Today }
            };

            foreach (Ticket ticket in tickets)
            {
                context.Ticket.Add(ticket);
            }
            
            context.SaveChanges();
        }
    }
}