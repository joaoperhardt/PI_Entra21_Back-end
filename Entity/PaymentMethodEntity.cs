namespace PI_Entra21_Back_end.Entity
{
    public class PaymentMethodEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Titular_Name { get; set; }
        public string Cpf { get; set; }
        public int Number { get; set; }
        public int Cvv { get; set; }
        public string Expiring_Date { get; set; }
    }
}
