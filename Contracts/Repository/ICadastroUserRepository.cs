using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface ICadastroUserRepository
    {
        Task Add(CadastroUserDTO user);

    }
}
