using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN
{
    public class Custumer
    {
        private int id;
        private string name;
        private string surname;
        private string mail;
        private string password;
        private string iban;
        private string identityNumber;
        private string job;
        //private string image; 
        private CreditCard creditCard;
        private BankCard bankCard;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public string Iban { get => iban; set => iban = value; }
        public BankCard BankCard { get => bankCard; set => bankCard = value; }
        public string IdentityNumber { get => identityNumber; set => identityNumber = value; }
        public string Job { get => job; set => job = value; }
        internal CreditCard CreditCard { get => creditCard; set => creditCard = value; }
    }
}
