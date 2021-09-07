using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProjectCategory
    {
        [Key]
        public int ProjCatId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProjectCategory()
        {

        }
    }
}
