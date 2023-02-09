using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Business.Models;

namespace ControleFinanceiro.Data.Mappings
{
    public class ReceitaMapping : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.HasKey(p => p.ReceitaId);

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Data)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("decimal");

            builder.ToTable("Receitas");
        }

    }
}
