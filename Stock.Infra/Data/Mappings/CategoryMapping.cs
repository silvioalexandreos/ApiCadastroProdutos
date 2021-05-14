using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Business.Entities;

namespace Stock.Infra.Data.Mappings
{
    public class CategoryMapping : BaseEntityMapping<Category>
    {
        public CategoryMapping() : base(nameof(Category)) { }

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            base.Configure(builder);
        }
    }
}
