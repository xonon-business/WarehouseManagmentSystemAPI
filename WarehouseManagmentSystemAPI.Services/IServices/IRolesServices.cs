

namespace WarehouseManagmentSystemAPI.Services.IServices
{
    public interface IRolesServices
    {
        public RoleDto CreateRole(RoleDto RoleDto);
        public RoleDto UpdateRole(RoleDto RoleDto);
        public void DeleteRole(Guid id);
        public IEnumerable<RoleDto> ReadRoles(RoleDto RoleDto);
    }
}
