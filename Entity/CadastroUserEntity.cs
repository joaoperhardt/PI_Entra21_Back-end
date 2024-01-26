namespace PI_Entra21_Back_end.Entity
{
    public class CadastroUserEntity
    {
		public int? Id { get; set; }
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }
		public string Cep { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

	}
}
