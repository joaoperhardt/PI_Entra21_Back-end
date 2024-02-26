using PI_Entra21_Back_end.DTO;

namespace PI_Entra21_Back_end.Contracts.Repository
{
    public interface Ipaymentmethod
    {
        Task Add(PaymentDTO payment);


    }
}
