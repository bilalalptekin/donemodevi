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
        public CreditCard CreditCard { get => creditCard; set => creditCard = value; }

        public Custumer(string name, string surname, string mail, string password, string iban, string identityNumber, string job)
        {
            
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.password = password;
            this.iban = iban;
            this.identityNumber = identityNumber;
            this.job = job;
        }
            public Custumer(int id,string name,string surname,string mail,string password,string iban,string identityNumber,string job,CreditCard creditCard,BankCard bankCard)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.password = password;
            this.iban = iban;
            this.identityNumber = identityNumber;
            this.job = job;
            this.creditCard = creditCard;
            this.bankCard = bankCard;
        }
        public Custumer(string name, string surname, string mail, string password, string iban, string identityNumber, string job,BankCard bankCard) /*CreditCard creditCard, BankCard bankCard)*/
        {
            
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.password = password;
            this.iban = iban;
            this.identityNumber = identityNumber;
            this.job = job;
            this.bankCard = bankCard;
            
        }
        public Custumer( string name, string surname, string mail, string password, string iban, string identityNumber, string job, CreditCard creditCard, BankCard bankCard)
        {
            
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.password = password;
            this.iban = iban;
            this.identityNumber = identityNumber;
            this.job = job;
            this.creditCard = creditCard;
            this.bankCard = bankCard;
        }
        public Custumer(string mail, string password)
        {
            this.mail = mail;
            this.password = password;   
        }
        public Custumer()
        {

        }
        
    }
}
