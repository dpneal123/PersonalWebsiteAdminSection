using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string ProjectShortDesc { get; set; }

        public string ProjectLongDesc { get; set; }

        public string ProjectPostedDate { get; set; }

        public string ProjectCreationDate { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Framework> Frameworks { get; set; }

        public Project()
        {

        }

    }

}
