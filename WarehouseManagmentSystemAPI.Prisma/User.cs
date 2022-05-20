using System;
using System.Net;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagmentSystemAPI.Prisma {
  [Table("User")]
  public class User {
    [Key, Required, Column]
    public string id { get; set; }
    [Required, Column]
    public string email { get; set; }
    [Required, Column]
    public string password { get; set; }
    [Column]
    public string creditCardNumber { get; set; }
    [Column]
    public string expDate { get; set; }
    [Column]
    public int cvv { get; set; }
    [Column]
    public string address { get; set; }
    [Required, Column]
    public string firstName { get; set; }
    [Required, Column]
    public string lastName { get; set; }
    [Column]
    public string profilePictureUrl { get; set; }
    [Required, Column]
    public DateTime timeCreated { get; set; }
    [Required, Column]
    public DateTime timeNow { get; set; }
  }
}