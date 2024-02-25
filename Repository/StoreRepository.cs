using Dapper;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Infrastructure;



namespace PI_Entra21_Back_end.Repository
{
    public class StoreRepository : Connection, IStoreRepository
    {
        public async Task AddStore(StoreDTO store)
        {
            string sql = @"
                INSERT INTO STORE (Name, Description,Cep,State,City, District, Street, Number, Complement, Phone, Cpf,cnpj)
                    VALUE (@Name, @Description,@Cep,@State,@City,@District, @Street, @Number, @Complement, @Phone,@Cpf,@cnpj)";
            await Execute(sql, store);

        }
    }
}