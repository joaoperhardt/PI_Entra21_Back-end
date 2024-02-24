using Microsoft.AspNetCore.SignalR;
using MySql.Data;
﻿using Dapper;
using Mysqlx.Prepare;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Entity;
using PI_Entra21_Back_end.Infrastructure;


namespace PI_Entra21_Back_end.Repository
{
    public class UserRepository : Connection, IUserRepository
    {
        public async Task Add(UserDTO user)
        {
            string sql = @"
                INSERT INTO USER(Name, Birthdate, Phone, Cep, Email, Password)
                    VALUE (@Name, @Birthdate, @Phone, @Cep, @Email, @Password)";
            await Execute(sql, user);
        }

        public async Task<UserEntity> GetById(int id)
        {
            string sql = "SELECT * FROM USER WHERE ID = @id";
            return await GetConnection().QueryFirstAsync<UserEntity>(sql, new { id });
        }

        public async Task<UserTokenDTO> LogIn(UserLoginDTO user)
        {
            string sql = "SELECT * FROM USER WHERE EMAIL=@Email AND PASSWORD=@Password";
            UserEntity userLogin = await GetConnection().QueryFirstAsync<UserEntity>(sql, user);
            return new UserTokenDTO
            {
                Token = Authentication.GenerateToken(userLogin),
                User = userLogin
            };
        }
        public async Task Update(UserEntity user)
        {
            string sql = @"UPDATE USER SET NAME=@Name, CEP=@Cep, EMAIL=@Email, FILE=@File WHERE ID=@Id";
            await Execute(sql, user);
        }
    }
}
