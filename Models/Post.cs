using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Post
    {
    public int PostId { get; set; }

    public string PostTitle { get; set; }

    public string PostBody { get; set; }

    public string PostDate { get; set; }

    public bool Published { get; set; }

    public Post()
    {

    }
}
}
