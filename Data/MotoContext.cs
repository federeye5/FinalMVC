using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Final.Data
{
    public class MotoContext : IdentityDbContext
    {
        public MotoContext (DbContextOptions<MotoContext> options)
            : base(options)
        {
        }

        public DbSet<Final.Models.Moto> Moto { get; set; } = default!;
        public DbSet<Final.Models.Agency> Agency { get; set; } = default!;

        public DbSet<Final.Models.Inventory> Inventory { get; set; } = default!;

        public DbSet<Final.Models.Accesory> Accesory { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Moto)
                .WithMany()
                .HasForeignKey(i => i.MotoId);
            
            modelBuilder.Entity<Moto>()
            .HasMany(p=> p.Accesories)
            .WithMany(p=> p.Motos)
            .UsingEntity("MotoAccesory");    
        }
    }

    
}