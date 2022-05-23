

namespace WarehouseManagmentSystemAPI.Infrastructure.FluentApis
{
    public class OrderFluentApi:IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasMany(o => o.Customers).WithMany(c => c.Orders)
                 .UsingEntity<OrdersToCustomersEntity>(

                 j => j.HasOne(oC => oC.Customers)
                 .WithMany(c => c.OrdersToCustomers)
                 .HasForeignKey(oC => oC.CustomerId),

                 j => j.HasOne(oC => oC.Orders)
                 .WithMany(c => c.ordersToCustomers)
                 .HasForeignKey(oC => oC.OrderId),

                 j =>
                 {
                     j.HasKey(t => new { t.OrderId, t.CustomerId });
                 }

                 );

            builder.HasMany(o => o.Products).WithMany(p => p.orders)
                 .UsingEntity<OrderToItemsEntity>(

                 j => j.HasOne(oI => oI.Products)
                 .WithMany(p => p.OrdersItems)
                 .HasForeignKey(oI => oI.ProductID),

                 j => j.HasOne(oI => oI.Orders)
                 .WithMany(o => o.OrdersItems)
                 .HasForeignKey(oI => oI.Order_Id),

                 j =>
                 {
                     j.HasKey(t => new { t.Order_Id, t.ProductID });
                 }

                 );

            builder.HasMany(o => o.Users).WithMany(u => u.orders)
                 .UsingEntity<OrdersToUsersEntity>(

                 j => j.HasOne(oU => oU.User)
                 .WithMany(o => o.ordersToUsers)
                 .HasForeignKey(oU => oU.UserId),

                 j => j.HasOne(oU => oU.Order)
                 .WithMany(o => o.ordersToUsers)
                 .HasForeignKey(oU => oU.OrderId),

                 j =>
                 {
                     j.HasKey(t => new { t.UserId, t.OrderId });
                 }

                 );



        }
    }

}
