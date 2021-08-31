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
    }
}
