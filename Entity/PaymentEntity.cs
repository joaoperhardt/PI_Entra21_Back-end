﻿

namespace PI_Entra21_Back_end.Entity
{
    public class PaymentEntity
    {

        public int? Id { get; set; }
       
        public string TITULAR_NAME { get; set; }
        public string CPF { get; set; }
        public int NUMBER { get; set; }
        public int CVV { get; set; }
        public string EXPIRING_DATE { get; set; }

        public string EXPIRING_DATE_MONTH { get; set; }



    }
}
