using Microsoft.AspNetCore.SignalR;
using Dapper;
using MySql.Data;
using PI_Entra21_Back_end.Infrastructure;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Entity;

namespace PI_Entra21_Back_end.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public async Task<UserTokenDTO> Login(UserLoginDTO user)
        {
            string sql = "SELECT * FROM USER WHERE EMAIL = @Email AND PASSWORD = @Password";
            UserEntity userLogin = await GetConnection().QueryFirstAsync<UserEntity>(sql, user);
            return new UserTokenDTO
            {
                Token = Authentication.GenerateToken(userLogin),
                User = userLogin
            };
        }
    }
}
