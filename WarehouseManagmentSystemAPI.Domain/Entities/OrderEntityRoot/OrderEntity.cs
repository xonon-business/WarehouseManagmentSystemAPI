

namespace ResturantWebApi.Domain.Entities.OrderEntityRoot
{
    public class OrderEntity
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDueDate { get; set; }
        public ICollection<CustomerEntity> CustomerEntity { get; set; }
        public ICollection<UserEntity> UserEntity { get; set; }
    }
}
