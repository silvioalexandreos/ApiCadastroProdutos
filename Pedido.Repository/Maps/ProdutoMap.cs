using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Domain.Entities;

namespace Pedido.Repository.Maps
{
    public class ProdutoMap : BaseDomainMap<Produto>
    {
        public ProdutoMap(): base("tb_produto") { }

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Categoria).HasColumnName("categoria").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Fornecedor).HasColumnName("fornecedor").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(17,2).IsRequired();
            builder.Property(x => x.QtdeProduto).HasColumnName("quantidade").HasMaxLength(2).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

            builder.Property(x => x.IdFornecedor).HasColumnName("id_forncedor").IsRequired();
            builder.HasOne(x => x.Fornecedor).WithMany(x => x.Produtos).HasForeignKey(x => x.IdFornecedor);
        }
    }
}
