using PI_Entra21_Back_end.Entity;

namespace PI_Entra21_Back_end.DTO
{
    public class UserTokenDTO
    {
        public string Token { get; set; }
        public UserEntity User { get; set; }
    }
}
