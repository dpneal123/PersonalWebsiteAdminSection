using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class ImageViewModel
    {
        public string ImageDescription { get; set; }

        public string ImageLocation { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
