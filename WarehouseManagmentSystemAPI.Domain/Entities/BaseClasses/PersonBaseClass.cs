


namespace ResturantWebApi.Domain.Entities.BaseClasses
{
    public class PersonBaseClass: AddressBaseClass
    {

        public string? Name { get; set; } = string.Empty;
        public string? email { get; set; } = string.Empty;
        public string? Phone { get; set; } = string.Empty;


    }
}
