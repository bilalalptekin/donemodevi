using _131730026_Bilal_Alptekib_donemsonuodv.DOMAIN;
using MySql.Data.MySqlClient;
using System;
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
            (new MySqlCommand("insert into custumer(name,surname,mail,password,iban,id_number,job) values" + " ('" + custumer.Name + "','" + custumer.Surname + "','" + custumer.Mail + "','" + custumer.Password + "','" + custumer.Iban + "','" + custumer.IdentityNumber + "','" + custumer.Job + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
            (new MySqlCommand("insert into bank_card(iban,balance,cvv,card_number,val_num) values" + " ('" + bankCard.Iban + "','" + bankCard.Balance + "','" + bankCard.Cvv + "','" + bankCard.CardNumber + "','" + bankCard.ValidityDate + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
            
        }
        public void saveCustumuerwithcreditcard(Custumer custumer,BankCard bankCard,CreditCard creditCard)
        {
            (new MySqlCommand("insert into custumer(name,surname,mail,password,iban,id_number,job) values" + " ('" + custumer.Name + "','" + custumer.Surname + "','" + custumer.Mail + "','" + custumer.Password + "','" + custumer.Iban + "','" + custumer.IdentityNumber + "','" + custumer.Job + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
            (new MySqlCommand("insert into bank_card(iban,balance,cvv,card_number,val_num) values" + " ('" + bankCard.Iban + "','" + bankCard.Balance + "','" + bankCard.Cvv + "','" + bankCard.CardNumber + "','" + bankCard.ValidityDate + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
            (new MySqlCommand("insert into bank_card(iban,max_credit,creditcard_number) values" + " ('" + creditCard.Iban + "','" + creditCard.MaxCredit + "','" + creditCard.CreditCardNumber + "','" + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
        }
    }
}
