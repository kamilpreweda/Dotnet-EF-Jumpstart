using Dotnet_EF_Jumpstart.Dtos.Weapon;

namespace Dotnet_EF_Jumpstart.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}