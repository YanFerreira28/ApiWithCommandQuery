using DDDCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDCQRS.Infra.EntityConfig
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        #region[Configuration to entity Product]

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.id);

            builder.Property(c => c.fornecedor).HasColumnName("Fornecedor").HasColumnType("varchar(50)").IsRequired();

            builder.Property(c => c.marca).HasColumnName("Marca").HasColumnType("varchar(50)").IsRequired();

            builder.Property(c => c.nome).HasColumnName("Nome").HasColumnType("varchar(50)").IsRequired();

            builder.Property(c => c.valor).IsRequired().HasColumnType("decimal");

        }

        #endregion
    }
}
