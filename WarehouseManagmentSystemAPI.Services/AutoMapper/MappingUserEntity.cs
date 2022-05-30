

namespace WarehouseManagmentSystemAPI.Services.AutoMapper
{
    public class MappingUserEntity:Profile
    {
        public MappingUserEntity()
        {
            CreateMap<UserDto,UserEntity>() //source >> where the info coming from ,  des is where it's going,where this info going to be stored
                .ForMember(
                des => des.User_Name,
                from => from.MapFrom(x=>$"{x.User_Name}")
                );
        }

    }
}
