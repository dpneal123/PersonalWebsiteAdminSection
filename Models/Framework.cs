using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Framework
    {
        [Key]
        public int FrameworkId { get; set; }

        public string FrameworkName { get; set; }

        public string FrameworkIconLoc { get; set; }

    }
}
