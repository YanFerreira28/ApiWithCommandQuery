using DDDCQRS.Domain.Entities;
using DDDCQRS.Infra.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");

            modelBuilder.ApplyConfiguration<Produto>(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
