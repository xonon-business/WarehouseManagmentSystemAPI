

namespace WarehouseManagmentSystemAPI.Infrastructure.Entities.BaseClasses
{
    public class AddressBaseClass
    { 
        public string? StreetAddress { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty; 
        public string? ZipCode { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
    }
}
