

namespace WarehouseManagmentSystemAPI.Infrastructure.FluentApis
{
    public class UserFluentApi : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(u => new {u.User_Name,u.Id});
        }
    }
}
