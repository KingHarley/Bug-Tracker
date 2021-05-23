using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BugTracker.Models;


namespace BugTracker.Controllers
{
    public class TicketController : Controller
    {
        

        public string Index()
        {
            return "Hello this is the index method '/'";
        }

        public string Welcome()
        {
            return "Welcome this is the welcome method /Welcome";
        }
    }
}