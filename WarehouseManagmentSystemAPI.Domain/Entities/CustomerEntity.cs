

namespace ResturantWebApi.Domain.Entities
{
    public class CustomerEntity:PersonBaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
    }
}
