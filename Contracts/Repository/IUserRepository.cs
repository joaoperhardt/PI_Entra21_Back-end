using PI_Entra21_Back_end.Entity;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<UserEntity> GetById(int id);
    }
}
