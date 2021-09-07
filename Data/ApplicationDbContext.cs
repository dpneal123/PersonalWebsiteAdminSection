using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebApplication1.Models.Image> Image { get; set; }
        public DbSet<WebApplication1.Models.Post> Post { get; set; }
        public DbSet<WebApplication1.Models.Event> Event { get; set; }
        public DbSet<WebApplication1.Models.EventDuty> EventDuty { get; set; }
        public DbSet<WebApplication1.Models.EventType> EventType { get; set; }
        public DbSet<WebApplication1.Models.Project> Project { get; set; }
        public DbSet<WebApplication1.Models.Category> Category { get; set; }
        public DbSet<WebApplication1.Models.Framework> Framework { get; set; }
        public DbSet<WebApplication1.Models.ProjectCategory> ProjectCategory { get; set; }
        public DbSet<WebApplication1.Models.ProjectFramework> ProjectFramework { get; set; }
        public DbSet<WebApplication1.Models.Colour> Colour { get; set; }


    }
}
