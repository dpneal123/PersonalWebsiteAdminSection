using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }

        public string EventTypeName { get; set; }

        public int EventDisplayOrder { get; set; }

        public int EventTypeActive { get; set; }

        public EventType()
        {

        }
    }
}
