using MehmetMusic.Stores;
using MehmetMusic.ViewModels;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MehmetMusic.Model
{
    public class Login
    {
       public OracleConnection con;
       public OracleCommand command;
   
        public string username {  get; set; }
        public string password { get; set; }


        public Login()
        {


            //// 1) Alle Username und Pass von Datenbank holen (SELECT)
            //// 2) username und pass von LoginView annehmmen
            //// For schleiffe
            //// 3) wenn richtig weiter wenn nicht dann 1/3 2/3 3/3 dann Konto sperren



            try
            {
                using (OracleConnection connection = new OracleConnection("Data Source=dbserver2.bg.bib.de:1521/ora10.bg.bib.de;User ID=bbm3h21mde;Password=T4kZCn5HsqVK"))
                {
                    connection.OpenAsync();
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public bool Einloggen(string u, string p)
        {
            // Überprüfen, ob Benutzername oder Passwort leer ist
            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p)) // Fehlerhafte Logik (&&) korrigiert zu ||
            {
                MessageBox.Show("Bitte geben Sie ihren Usernamen und ihr Passwort ein!");
                return false;
            }

            // Verwenden von using zum sicheren Schließen der Verbindung
            using (OracleConnection con = new OracleConnection("Data Source=dbserver2.bg.bib.de:1521/ora10.bg.bib.de;User ID=bbm3h21mde;Password=T4kZCn5HsqVK;"))
            {
                con.OpenAsync();

                // Wenn Benutzername und Passwort einem spezifischen Benutzer zugewiesen sind
                if (u.Equals("mehmet") && p == "123")
                {
                    // SQL-Befehl erstellen
                    using (OracleCommand command = con.CreateCommand()) // Deklaration von `command`
                    {
                        command.CommandText = $"select username, password from login where username = '{u}' and password = '{p}'";
                        con.OpenAsync();
                        // Abfrage ausführen
                        var reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Anmeldeinformationen sind korrekt
                            MessageBox.Show("Account Erfolgreich");
                            return true;
                        }
                    }
                }
            }

            // Nachricht anzeigen, wenn Anmeldung fehlschlägt
            MessageBox.Show("Bitte Registrieren Sie sich um einen Account zu erhalten!");
            return false;
        }


    }
}
