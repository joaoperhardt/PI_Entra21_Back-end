using Dapper;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Infrastructure;



namespace PI_Entra21_Back_end.Repository
{
    public class CadastroUserRepository : Connection, ICadastroUserRepository
    {
        public async Task Add(CadastroUserDTO user)
        {
            string sql = @"
                INSERT INTO USER(Name, Birthdate, Phone, Cep, Email, Password)
                    VALUE (@Name, @Birthdate, @Phone, @Cep, @Email, @Password)";
            await Execute(sql, user);
        }
    }
}
