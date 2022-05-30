


namespace WarehouseManagmentSystemAPI.Dtos.UserDtoRoot
{
    public class UserDto:PersonBaseClass
    {
        public string? User_Name { get; set; } = string.Empty;
        public string? User_email { get; set; } = string.Empty;
        public string? User_Phone { get; set; } = string.Empty;
        public string RoleType { get; set; }

    }
}
