using API.Dtos;

namespace API.Services
{
    public interface IUserService
    {
         Task<string> RegisterAsync (RegisterDto model);
         Task<DatosUserDto> GetTokenAsync (LoginDto model);
    }
}