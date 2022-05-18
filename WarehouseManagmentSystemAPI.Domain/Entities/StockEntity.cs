

namespace ResturantWebApi.Domain.Entities
{
    public class StockEntity
    {
        public Guid ProductId { get; set;}
        public ProductEntity ProductEntity { get; set;}
    }
}
