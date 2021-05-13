using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedido.Domain.Entities;

namespace Pedido.Repository.Maps
{
    public class FornecedorMap : BaseDomainMap<Fornecedor>
    {
        public FornecedorMap(): base("tb_fornecdor") { }

        public override void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.NomeFantasia).HasColumnName("nome_fantasia").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();
        }
    }
}
