



namespace WarehouseManagmentSystemAPI.Infrastructure.Entities
{
    public class CategoryEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public List<ProductEntity> ProductEntities { get; set; }

    }
}
