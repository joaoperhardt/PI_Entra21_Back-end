namespace PI_Entra21_Back_end.Entity
{
    public class UserEntity
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Cep { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string File { get; set; }
        public int Payment_Method_Id { get; set; }
    }
}
