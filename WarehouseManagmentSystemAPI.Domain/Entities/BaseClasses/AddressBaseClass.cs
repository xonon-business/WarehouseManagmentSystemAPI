using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystemAPI.Domain.Entities.BaseClasses
{
    public class AddressBaseClass
    { 
        public string? StreetAddress { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty; 
        public string? ZipCode { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
    }
}
