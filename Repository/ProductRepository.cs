using Dapper;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.Entity;
using PI_Entra21_Back_end.Infrastructure;

namespace PI_Entra21_Back_end.Repository
{
    public class ProductRepository : Connection, IProductRepository
    {
        public async Task<ProductEntity> GetById(int id)
        {
            string sql = "SELECT * FROM PRODUCT WHERE ID = @id";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { id });
        }
    }
}
