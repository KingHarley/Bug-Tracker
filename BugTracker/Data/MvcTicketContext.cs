using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BugTracker.Models;

    public class MvcTicketContext : DbContext
    {
        public MvcTicketContext (DbContextOptions<MvcTicketContext> options)
            : base(options)
        {
        }

        public DbSet<BugTracker.Models.Ticket> Ticket { get; set; }
    }
