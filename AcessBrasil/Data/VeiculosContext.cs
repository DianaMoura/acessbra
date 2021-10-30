using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcessBrasil.Models;


namespace AcessBrasil.Data
{
    public class VeiculosContext : DbContext
    {
        public VeiculosContext(DbContextOptions<VeiculosContext> options) : base(options)
        {
        }
        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Carro> Carros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>().ToTable("Marca");
            modelBuilder.Entity<Carro>().ToTable("Carro");

        }
    }
}
