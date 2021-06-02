using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool login(Custumer custumer)
        {

            ArrayList emailandpassword = new ArrayList();
           // MySqlDataReader read=(new MySqlCommand("SELECT * FROM custumer where mail='" + custumer.Mail + "' AND password='" + custumer.Password + "'", (new dbConnection()).getConnection())).ExecuteReader();
            MySqlDataReader read = (new MySqlCommand("SELECT * FROM custumer where mail='" + custumer.Mail + "' AND password='" + custumer.Password + "'", (new dbConnection()).getConnection())).ExecuteReader();
            //MySqlDataReader readbankCard = (new MySqlCommand("SELECT * FROM bank_card where iban='" + custumer.Iban + "'", (new dbConnection()).getConnection())).ExecuteReader();

            if (read.Read())
            {
                //BankCard _bankCard = (new BankCard(readbankCard[0].ToString(), Convert.ToDecimal(readbankCard[1]), Convert.ToInt32(readbankCard[2]), readbankCard[3].ToString(), Convert.ToDateTime(readbankCard[4])));

                                                   //id                        //name              //surname          //mail              //password         //iban           //id_number         //job
                //emailandpassword.Add(new Custumer(/*Convert.ToInt32(read[0]),*/ read[1].ToString(),read[2].ToString(),read[3].ToString(),read[4].ToString(),read[5].ToString(),read[6].ToString(),read[7].ToString(),_bankCard));
                return true;
            }
            else
            {
                return false;
            }
        }
        //public 
    }
}
