using Dapper;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Infrastructure;
using PI_Entra21_Back_end.Entity;

namespace PI_Entra21_Back_end.Repository
{
    public class CadastroAnuncioRepository : Connection, ICadastroAnuncioRepository
    {
        public async Task Add(CadastroAnuncioDTO anuncio)
        {
            string sql = @"
                INSERT INTO PRODUCT (Name, Price, Buyers, Description, Type, Rating, File, Discount, Category_Id, Store_Id)
                VALUES (@Name, @Price, @Buyers, @Description, @Type, @Rating, @File, @Discount, @Category_Id, @Store_ID)
            ";
            await Execute(sql, anuncio);
        }

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public Task Get()
        {
            throw new NotImplementedException();
        }

        public Task GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }
    }
    
    
}
