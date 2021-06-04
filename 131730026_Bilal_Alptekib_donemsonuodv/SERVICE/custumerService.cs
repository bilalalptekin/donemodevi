using _131730026_Bilal_Alptekib_donemsonuodv.DAL;
using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _131730026_Bilal_Alptekib_donemsonuodv.SERVICE
{
    class custumerService
    {
        internal void saveCustumerWithCreditCard(Custumer custumer,BankCard bankCard,CreditCard creditCard)
        {
            string name = custumer.Name;
            string surname = custumer.Surname;
            string mail = custumer.Mail;
            string passwword = custumer.Password;
            string iban = custumer.Iban;
            string job = custumer.Job;
            string identity = custumer.IdentityNumber;
            decimal balance = bankCard.Balance;
            string cardNumber = bankCard.CardNumber;
            int cvv = bankCard.Cvv;
            DateTime valThu = bankCard.ValidityDate;
            decimal maxCredit = creditCard.MaxCredit;
            string creditrCardNumber = creditCard.CreditCardNumber;

            (new custumerDAO()).saveCustumuerwithcreditcard(new Custumer(name, surname,mail,passwword,iban,identity,job,creditCard,bankCard),(new BankCard(iban,balance,cvv,cardNumber,valThu)),new CreditCard(iban,maxCredit,creditrCardNumber));
        }
        internal void saveCustumerWithoutCreditCard(Custumer custumer,BankCard bankCard)
        {
            string name = custumer.Name;
            string surname = custumer.Surname;
            string mail = custumer.Mail;
            string passwword = custumer.Password;
            string iban = custumer.Iban;
            string job = custumer.Job;
            string identity = custumer.IdentityNumber;
            decimal balance = bankCard.Balance;
            string cardNumber = bankCard.CardNumber;
            int cvv = bankCard.Cvv;
            DateTime valThu = bankCard.ValidityDate;

            (new custumerDAO()).saveCustumuerwithoutcreditcard(new Custumer(name, surname, mail, passwword, iban, identity, job,bankCard), (new BankCard(iban, balance, cvv, cardNumber, valThu)));
        }
        internal Custumer login(string mail,string sifre)
        {
           return (new custumerDAO()).login(mail,sifre);
        }
        internal void ChangePassword(Custumer custumer)
        {
            (new custumerDAO()).updatePassword(custumer);
        }
        internal void takeCredit(Custumer custumer,Decimal tutar)
        {
            (new custumerDAO()).takeCredit(custumer,tutar);
        }
        internal void sendMoney(Custumer custumer,Custumer custumerReciever, Decimal tutar)
        {
            (new custumerDAO()).sendMoney(custumer,custumerReciever, tutar);
        }
    }
}
