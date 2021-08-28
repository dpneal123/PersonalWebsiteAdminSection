using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string ImageDescription { get; set; }

        public string ImageLocation { get; set; }

        public string ImageFile { get; set; }
        public Image()
        {

        }
    }
}
