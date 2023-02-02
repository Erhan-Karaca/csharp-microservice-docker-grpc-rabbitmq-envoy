using Microsoft.EntityFrameworkCore;
using Catalog.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Catalogg> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalogg>().HasData(
                new Catalogg() { Id = Guid.NewGuid(), Name = "İsim 1", Description = "Açıklama 1" },
                new Catalogg() { Id = Guid.NewGuid(), Name = "İsim 2", Description = "Açıklama 2" }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
