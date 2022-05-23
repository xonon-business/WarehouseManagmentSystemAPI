

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities
{
    public class CustomerEntity:PersonBaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
        public string? Credit_Card { get; set; } = string.Empty;
        public ICollection<OrderEntity> Orders { get; set; }
        public List<OrdersToCustomersEntity> OrdersToCustomers { get;  set; }
    }
}
