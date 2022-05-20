using System;
using System.Net;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagmentSystemAPI.Prisma {
  [Table("CategoryEntity")]
  public class CategoryEntity {
    [Key, Required, Column]
    public string id { get; set; }
    [Required, Column]
    public string CategoryName { get; set; }
    [Required, Column]
    public string ProductId { get; set; }
    public ICollection<ProductEntity> ProductEntities { get; set; }
  }
}