using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN
{
    public class CreditCard
    {
        private string iban; 
        private decimal maxCredit;
        private string creditCardNumber;

        public string Iban { get => iban; set => iban = value; }
        public decimal MaxCredit { get => maxCredit; set => maxCredit = value; }
        public string CreditCardNumber { get => creditCardNumber; set => creditCardNumber = value; }
    
    
        public CreditCard(string iban,decimal maxCredit,string creditCardNumber)
        {
            this.iban = iban;
            this.maxCredit = maxCredit;
            this.creditCardNumber = creditCardNumber;
        }

    }
}
