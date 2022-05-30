

namespace WarehouseManagmentSystemAPI.Dtos
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public string OrderStatus { get; set; }
        public string? Customer_Name { get; set; } = string.Empty;
        public string? Customer_Email { get; set; } = string.Empty;
        public string? Customer_Phone { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public DateTime OrderDueDate { get; set; }
    }
}
