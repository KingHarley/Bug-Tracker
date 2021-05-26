using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        
    }
}