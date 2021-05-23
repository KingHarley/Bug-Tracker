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
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewTicket(string newTicket)
        {
            ViewData["newTicket"] = newTicket;
            return View();
        }
    }
}