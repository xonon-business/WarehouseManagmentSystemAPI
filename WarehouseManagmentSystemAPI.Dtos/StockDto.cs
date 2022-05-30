

using System.ComponentModel.DataAnnotations;

namespace WarehouseManagmentSystemAPI.Dtos
{
    public class StockDto
    {
        public Guid StockId { get; set; }

        [Display(Name ="Stock Name: ")]
        public string StockName { get; set; }
        public Guid ProductId { get; set;}
        public ProductEntity ProductEntity { get; set;}
    }
}
