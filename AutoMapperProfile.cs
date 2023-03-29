using Dotnet_EF_Jumpstart.Dtos.Weapon;

namespace Dotnet_EF_Jumpstart
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}