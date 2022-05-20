


using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WarehouseManagmentSystemAPI.Infrastructure.FluentApis
{
    public class ProductsFluentApi : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasOne<CategoryEntity>(p => p.Category).WithMany(c => c.ProductEntities).HasForeignKey(p=>p.CategoryIdFK);
        }
    }
}
