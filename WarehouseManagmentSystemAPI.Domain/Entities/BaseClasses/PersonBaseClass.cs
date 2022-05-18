


namespace ResturantWebApi.Domain.Entities.BaseClasses
{
    public class PersonBaseClass: AddressBaseClass
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? email { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;


    }
}
