using Mysqlx.Crud;
using PI_Entra21_Back_end.Contracts.Repository;
using PI_Entra21_Back_end.DTO;
using PI_Entra21_Back_end.Infrastructure;

namespace PI_Entra21_Back_end.Repository
{
    public class PaymentRepository : Connection, IpaymentmethodRepository
    {
        

            public async Task Add(PaymentDTO payment)
            {
                string sql = @"
                INSERT INTO payment_method(TITULAR_NAME, CPF, NUMBER, CVV, EXPIRING_DATE, EXPIRING_DATE_MONTH)
                    VALUE (@TITULAR_NAME, @CPF, @NUMBER, @CVV, @EXPIRING_DATE, @EXPIRING_DATE_MONTH)";
                await Execute(sql, payment);
        }
    }
}
