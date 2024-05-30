using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBooster.Entities;

namespace ProjetoBooster.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("tb_produto");

            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .IsRequired()
            .HasMaxLength(100);

            builder.Property(x => x.Preco)
                .HasColumnName("preco")
                .HasColumnType("decimal(18,2)")
                .HasMaxLength(100);

        }
    }
}
