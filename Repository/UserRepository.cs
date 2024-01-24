using Dapper;
using Mysqlx.Prepare;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.Entity;
using PI_Entra21_Back_end.Infrastructure;

namespace PI_Entra21_Back_end.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public async Task<UserEntity> GetById(int id)
        {
            string sql = "SELECT * FROM USER WHERE ID = @id";
            return await GetConnection().QueryFirstAsync<UserEntity>(sql, new { id });
        }
    }
}
