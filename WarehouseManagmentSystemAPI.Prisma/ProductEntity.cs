using System;
using System.Net;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagmentSystemAPI.Prisma {
  [Table("ProductEntity")]
  public class ProductEntity {
    [Key, Required, Column]
    public string id { get; set; }
    [Required, Column]
    public string ProductName { get; set; }
    [Required, Column]
    public string ProductDescription { get; set; }
    [Required, Column]
    public string SKU { get; set; }
    [Required, Column]
    public int ProductQTY { get; set; }
    [Required, Column]
    public int ReOrderPoint { get; set; }
    [Required, Column]
    public long ProductSalePrice { get; set; }
    [Required, Column]
    public long ProductCostPrice { get; set; }
    public CategoryEntity CategoryEntity { get; set; }
    [ForeignKey("CategoryEntity")]
    [Required, Column]
    public string categoryEntityId { get; set; }
    [Required, Column]
    public byte[] Image { get; set; }
  }
}