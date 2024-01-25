using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<UserTokenDTO> Login(UserLoginDTO user);
    }
}
