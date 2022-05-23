﻿

namespace WarehouseManagmentSystemAPI.Domain.Entities
{
    public class CustomerEntity:PersonBaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
        public List<OrdersToCustomersEntity> OrdersToCustomers { get;  set; }
    }
}
