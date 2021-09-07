using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Colour
    {
        [Key]
        public int ColourId { get; set; }

        public string ColourName { get; set; }

        public string ColourCode { get; set; }

        public Colour()
        {

        }

    }
}
