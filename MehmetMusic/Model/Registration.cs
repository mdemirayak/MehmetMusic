using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MehmetMusic.Model
{
    public class Registration
    {

        public OracleConnection con;
        public OracleCommand command;

        public string vorname { get; set; }
        public string nachname { get; set; }
        public string email { get; set; }
        public string userid { get; set; }
        public int birthday { get; set; }
        public int birthmonth { get; set; }
        public int birthyear { get; set; }

        //public DateTime birth {  get; set; }

        public Registration()
        {
            try
            {
                string connection = "Data Source = dbserver2.bg.bib.de:1521/ora10.bg.bib.de;User ID=bbm3h21mde;Password=T4kZCn5HsqVK";
                con = new OracleConnection(connection);
                command = con.CreateCommand();
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void AccAnlegen(string v, string n, string em, string userID, int birthDay, int birthMonth, int birthYear)
        {
            if (!String.IsNullOrEmpty(v) && !String.IsNullOrEmpty(n) && !String.IsNullOrEmpty(em)
                && !String.IsNullOrEmpty(userID) && (birthDay != 0 && birthDay <= 31  )&& (birthMonth != 0 && birthMonth <= 12 ) 
                && (birthYear > 1900 && birthYear <= DateTime.Now.Year))
            {
                command.CommandText = "INSERT INTO regestrierungmusicapp (vorname, nachname, email, username, birthday) " +
                       "VALUES ('" + v + "', '" + n + "', '" + em + "', '" + userID + "', '" + birthYear + "-" 
                       + birthMonth.ToString("D2") 
                       + "-" + birthDay.ToString("D2") + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Account erfolgreich angelegt!");
                con.Clone();
            }
            else
            {
                MessageBox.Show("Account anlegen Fehlgeschlagen!");
            }
        }
    }
}
