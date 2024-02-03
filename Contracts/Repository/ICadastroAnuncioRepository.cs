using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface ICadastroAnuncioRepository
    {
        Task Add(CadastroAnuncioDTO anuncio);
        Task Update();
        Task Delete();
        Task GetByID(int id);
        Task Get();

    }
}
