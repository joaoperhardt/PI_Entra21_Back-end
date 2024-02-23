using PI_Entra21_Back_end.Entity;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface IProductRepository
    {
        Task<ProductEntity> GetById(int id);
    }
}
