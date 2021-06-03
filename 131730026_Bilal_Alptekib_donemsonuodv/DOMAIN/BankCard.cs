using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN
{
    public class BankCard
    {
        private string iban;
        private decimal balance;
        private int cvv;
        private string cardNumber;
        private DateTime validityDate;

        public string Iban { get => iban; set => iban = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public DateTime ValidityDate { get => validityDate; set => validityDate = value; }

        public BankCard(string iban,decimal balance,int cvv,string cardNumber,DateTime validityDate)
        {
            this.iban = iban;
            this.balance = balance;
            this.cvv = cvv;
            this.cardNumber = cardNumber;
            this.validityDate = validityDate;
        }
        public BankCard()
        {

        }
    }
}
