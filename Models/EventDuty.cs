using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{

    public class EventDuty
    {

        public int EventDutyId { get; set; }
        public int EventId { get; set; }

        public Event Event { get; set; }
        public string DutyDescription { get; set; }

        public EventDuty()
        { 
        
        }
    }
}
