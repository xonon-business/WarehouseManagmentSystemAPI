using System;
using System.Net;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagmentSystemAPI.Prisma {
  [Table("StockEntity")]
  public class StockEntity {
    [Key, Required, Column]
    public string ProductId { get; set; }
    [Required, Column]
    public string productEntityId { get; set; }
  }
}