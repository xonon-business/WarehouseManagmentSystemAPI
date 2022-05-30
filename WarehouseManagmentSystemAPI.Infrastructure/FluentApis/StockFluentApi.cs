

namespace WarehouseManagmentSystemAPI.Infrastructure.FluentApis
{
    public class StockFluentApi : IEntityTypeConfiguration<StockEntity>
    {
        public void Configure(EntityTypeBuilder<StockEntity> builder)
        {
            builder.HasKey(s => s.StockId);
        }
    }
}
