namespace PI_Entra21_Back_end.DTO
{
    public class CadastroAnuncioDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Buyers { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public decimal Rating { get; set; }
        public string File { get; set; }
        public int Discount { get; set; }
        public int Category_Id { get; set; }
        public int Store_Id { get; set; }
        
    }
}
