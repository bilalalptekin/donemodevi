using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _131730026_Bilal_Alptekib_donemsonuodv.DAL
{
    class custumerDAO
    {
        public void saveCustumuerwithoutcreditcard(Custumer custumer, BankCard bankCard)
        {
            (new MySqlCommand("insert into bank_card(iban,balance,cvv,card_number,val_num) values ('" + bankCard.Iban + "','" + bankCard.Balance + "','" + bankCard.Cvv + "','" + bankCard.CardNumber + "','" + bankCard.ValidityDate + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
            (new MySqlCommand("insert into custumer(name,surname,mail,password,iban,id_number,job) values ('" + custumer.Name + "','" + custumer.Surname + "','" + custumer.Mail + "','" + custumer.Password + "','" + custumer.Iban + "','" + custumer.IdentityNumber + "','" + custumer.Job + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();   
        }
        public void saveCustumuerwithcreditcard(Custumer custumer,BankCard bankCard,CreditCard creditCard)
        {

            (new MySqlCommand("insert into bank_card(iban,balance,cvv,card_number,val_num) values ('" + bankCard.Iban + "','" + bankCard.Balance + "','" + bankCard.Cvv + "','" + bankCard.CardNumber + "','" + bankCard.ValidityDate + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
            (new MySqlCommand("insert into credit_card(iban,max_credit,creditcard_number) values ('" + creditCard.Iban + "','" + creditCard.MaxCredit + "','" + creditCard.CreditCardNumber + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();      
            (new MySqlCommand("insert into custumer(name,surname,mail,password,iban,id_number,job) values ('" + custumer.Name + "','" + custumer.Surname + "','" + custumer.Mail + "','" + custumer.Password + "','" + custumer.Iban + "','" + custumer.IdentityNumber + "','" + custumer.Job + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();

        }
        public void updatePassword(Custumer custumer)
        {
            (new MySqlCommand("UPDATE custumer SET password='" + custumer.Password + "' where iban ='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteNonQuery();
        }

        public Custumer login(string tbxmail,string tbxpassword)
        {
            Custumer custumer = new Custumer();
           
            MySqlDataReader read = (new MySqlCommand("SELECT * FROM custumer where mail='" + tbxmail + "' AND password='" + tbxpassword + "'", (new dbConnection()).getConnection())).ExecuteReader();
            BankCard _bankCard = new BankCard();
            
            if (read.Read())
            {
            
                custumer.Id = Convert.ToInt32(read[0]);
                custumer.Name = read[1].ToString();
                custumer.Surname = read[2].ToString();
                custumer.Mail = read[3].ToString();
                custumer.Password = read[4].ToString();
                custumer.Iban = read[5].ToString();
                custumer.IdentityNumber = read[6].ToString();
                custumer.Job = read[7].ToString();

                MySqlDataReader readbankCard = (new MySqlCommand("SELECT * FROM bank_card where iban='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteReader();

                if (readbankCard.Read())
                {
                    _bankCard.Iban = readbankCard[0].ToString();
                    _bankCard.Balance = Convert.ToDecimal(readbankCard[1]);
                    _bankCard.Cvv = Convert.ToInt32(readbankCard[2]);
                    _bankCard.CardNumber = readbankCard[3].ToString();
                    _bankCard.ValidityDate = Convert.ToDateTime(readbankCard[4]);
                }

                MySqlDataReader readcreditCard = (new MySqlCommand("SELECT * FROM credit_card where iban='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteReader();

                CreditCard _creditCard = new CreditCard();

                if (readcreditCard.Read())
                {
                    _creditCard.Iban = readcreditCard[0].ToString();
                    _creditCard.MaxCredit = Convert.ToDecimal(readcreditCard[1]);
                    _creditCard.CreditCardNumber = readcreditCard[2].ToString();
                }
                custumer.BankCard = _bankCard;
                custumer.CreditCard = _creditCard;
                return custumer;
            }
            else
            {               
                return custumer;         
            }
        
        }
        public void takeCredit(Custumer custumer,Decimal miktar)
        {
            if (custumer.CreditCard.MaxCredit >= miktar)
            {
                (new MySqlCommand("UPDATE bank_card SET balance='" + (custumer.BankCard.Balance + miktar) + "' where iban ='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteNonQuery();
                (new MySqlCommand("UPDATE credit_card SET max_credit='" + (custumer.CreditCard.MaxCredit - miktar) + "' where iban ='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteNonQuery();
            }


        }
        public void sendMoney(Custumer custumer,Custumer custumerReceiver, Decimal miktar)
        {
            BankCard _bankCard = new BankCard();
            MySqlDataReader readCustumerReciever = (new MySqlCommand("SELECT * FROM bank_card where iban='" + custumerReceiver.Iban + "'", (new dbConnection()).getConnection())).ExecuteReader();
            
            MySqlDataReader readbankCard = (new MySqlCommand("SELECT * FROM bank_card where iban='" + custumerReceiver.Iban + "'", (new dbConnection()).getConnection())).ExecuteReader();
            

            if (readCustumerReciever.Read())
            {

                if (readbankCard.Read())
                {
                    _bankCard.Balance = Convert.ToDecimal(readbankCard[1]);
                }
                
                custumerReceiver.BankCard = _bankCard;
                (new MySqlCommand("UPDATE bank_card SET balance='" + (custumerReceiver.BankCard.Balance + miktar) + "' where iban ='" + custumerReceiver.Iban + "'", (new dbConnection()).getConnection())).ExecuteNonQuery();
                
                (new MySqlCommand("UPDATE bank_card SET balance='" + (custumer.BankCard.Balance - miktar) + "' where iban ='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteNonQuery();

            }


        }
        //public Custumer custumrReturn(Custumer custumer)
        //{
        //    return custumer;
        //}
    }
}
