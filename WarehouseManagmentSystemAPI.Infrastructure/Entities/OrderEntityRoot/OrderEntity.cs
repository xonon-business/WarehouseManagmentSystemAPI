﻿

namespace WarehouseManagmentSystemAPI.Infrastructure.OrderEntityRoot
{
    public class OrderEntity
    {
        public Guid OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDueDate { get; set; }

        //Navigation Props
        public ICollection<CustomerEntity> Customers { get; set; }
        public ICollection<UserEntity> Users { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
        public List<OrderToItemsEntity> OrdersItems { get; set; }
        public List<OrdersToCustomersEntity> ordersToCustomers { get; set; }
        public List<OrdersToUsersEntity> ordersToUsers { get; set; }

    }
}
