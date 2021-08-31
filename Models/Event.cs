using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public int EventTypeId { get; set; }

        public EventType EventType { get; set; }

        public string EventTitle { get; set; }

        public string EventBody { get; set; }

        public string EventLocation { get; set; }

        public string EventStart { get; set; }

        public string EventEnd { get; set; }

        public bool PublishEvent { get; set; }

        public Event()
        { 
        
        }
    }
}
