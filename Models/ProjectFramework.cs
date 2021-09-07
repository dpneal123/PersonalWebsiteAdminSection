using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProjectFramework
    {
        [Key]
        public int ProjFrameId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }

        public ProjectFramework()
        {

        }
    }
}
