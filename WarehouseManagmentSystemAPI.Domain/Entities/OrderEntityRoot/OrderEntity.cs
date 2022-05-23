﻿

namespace WarehouseManagmentSystemAPI.Domain.Entities.OrderEntityRoot
{
    public class OrderEntity
    {
        public Guid OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDueDate { get; set; }
        //Navigation Props
        public Guid CustomerId { get; set; }
        public ICollection<CustomerEntity> Customers { get; set; }
        public List<OrderToItemsEntity> Items { get; set; }
        public List<OrdersToCustomersEntity> ordersToCustomers { get; set; }
        public ICollection<UserEntity> Users { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}
