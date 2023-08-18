using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchuhLadenApp
{
    internal class User
    {

        private string UserId;
        private string Name;
        private string Vorname;
        private string Strasse;
        private string Hausnummer;
        private int Plz;
        private string Adresse;
        private string Anstellungszeit;
        private double Lohngehalt;
        private string UserStatus;
        private string account;
        private string password;

        // Constructor
        public User() { }
        public User(string UserId, string name, string vorname, string strasse, string hausnummer, int plz, string anstellungszeit, double lohngehalt, string userStatus, string password, string account)
        {
            this.UserId = UserId;
            this.Name = name;
            this.Vorname = vorname;
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.Plz = plz;
            this.Anstellungszeit = anstellungszeit;
            this.Lohngehalt = lohngehalt;
            this.UserStatus = userStatus;
            this.account = account;
            this.password = password;
        }
        public User(string name, string vorname, string strasse, string hausnummer, int plz, string anstellungszeit, double lohngehalt, string userStatus, string password, string account)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.Plz = plz;
            this.Anstellungszeit = anstellungszeit;
            this.Lohngehalt = lohngehalt;
            this.UserStatus = userStatus;
            this.account = account;
            this.password = password;
        }
        public User(string UserId, string name, string vorname, string strasse, string hausnummer, int plz, string anstellungszeit, double lohngehalt, string userStatus)
        {
            this.UserId = UserId;
            this.Name = name;
            this.Vorname = vorname;
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.Plz = plz;
            this.Anstellungszeit = anstellungszeit;
            this.Lohngehalt = lohngehalt;
            this.UserStatus = userStatus;
        }
        public User(string name, string vorname, string strasse, string hausnummer, int plz, string anstellungszeit, double lohngehalt, string userStatus)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.Plz = plz;
            this.Anstellungszeit = anstellungszeit;
            this.Lohngehalt = lohngehalt;
            this.UserStatus = userStatus;
        }
        public User(string account, string password)
        {
            this.account = account;
            this.password = password;
        }

        // Calculate the User ID
        public string CalculateUserId()
        {

            string teilOne;
            string teilTwo;
            string teilThree;
            string teilFour;
            string teilFive;

            string AnstellungsZeitToString = this.Anstellungszeit.ToString();

            teilOne = this.Name.Substring(0, 2);
            teilTwo = this.Vorname.Substring(0, 2);
            teilThree = this.Strasse.Substring(0, 2);
            teilFour = this.UserStatus.Substring(0, 2);
            teilFive = AnstellungsZeitToString.Substring(0, 8);

            string UserId = teilOne + teilTwo + teilThree + teilFour + teilFive;

            return UserId;

        }

        // Retrieve all users from the DB 
        public static List<User> retrieveUsersFromDb()
        {

            List<User> users = new List<User>();

            DatabaseHelper databaseHelper = new DatabaseHelper();

            using (SQLiteConnection connection = databaseHelper.OpenConnection())
            {
                string query = "SELECT * FROM user";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string userId = reader.GetString(0);
                            string name = reader.GetString(1);
                            string vorname = reader.GetString(2);
                            string strasse = reader.GetString(3);
                            string hausnummer = reader.GetString(4);
                            int plz = reader.GetInt32(5);
                            string anstellungszeit = reader.GetString(6);
                            double lohngehalt = reader.GetDouble(7);
                            string userstatus = reader.GetString(8);
                            string password = reader.GetString(9);
                            string account = reader.GetString(10);

                            User newUser = new User(userId, name, vorname, strasse, hausnummer, plz, anstellungszeit, lohngehalt, userstatus, password, account);

                            users.Add(newUser);

                        }

                    }
                }
                databaseHelper.CloseConnection(connection);
            }

            return users;
        }

        // Iterate through the list and check if the userID exists
        public bool checkIfUserExists()
        {
            List<User> users = retrieveUsersFromDb();

            foreach (User user in users) 
            { 
                if (this.UserId == user.UserId) 
                {
                    return true;
                }
            }

            return false;
            
        }

        // Add new User to the DB
        public void addNewUser()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            using (SQLiteConnection connection = databaseHelper.OpenConnection())
            {
                string query = "INSERT INTO user(userid, name, vorname, strasse, hausnummer, plz, anstellungszeit, lohngehalt, userstatus, password, account) " +
                    "VALUES (@userid, @name, @vorname, @strasse, @hausnummer, @plz, @anstellungszeit, @lohngehalt, @userstatus, @password, @account) ";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userid", this.getUserId());
                    command.Parameters.AddWithValue("@name", this.getName());
                    command.Parameters.AddWithValue("@vorname", this.getVorname());
                    command.Parameters.AddWithValue("@strasse", this.getStrasse());
                    command.Parameters.AddWithValue("@hausnummer", this.getHausnummer());
                    command.Parameters.AddWithValue("@plz", this.getPlz());
                    command.Parameters.AddWithValue("@anstellungszeit", this.getAnstellungsZeit());
                    command.Parameters.AddWithValue("@lohngehalt", this.getLohnGehalt());
                    command.Parameters.AddWithValue("@userstatus", this.getUserStatus());
                    command.Parameters.AddWithValue("@password", this.getPassword());
                    command.Parameters.AddWithValue("@account", this.getAccount());

                    command.ExecuteNonQuery(); // Execute the INSERT query
                }
                databaseHelper.CloseConnection(connection);
            }
        }

        // Check userId and return the user if it exists in the db
        public User getExistingUser(string userIdInput)
        {
            Console.WriteLine("Aufgerufen");
            List<User> users = retrieveUsersFromDb();

                foreach (User user in users)
                {
                
                    if (user.getUserId() == userIdInput)
                    {
                        
                        return user;
                    }
                }
                
                 /* string input = tbxInput2.Text.ToString();

            User user = new User().getExistingUser(input);

            tbxTestInput.Text = user.ToString();*/

            return null;
        }

        // Log in Check
        public bool checkUserCredentials(string account, string password)
        {

            List<User> users = retrieveUsersFromDb();

            foreach (User user in users)
            {
                if(user.account == account && user.password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public void setUserId(string userId)
        { 
            this.UserId = userId; 
        }

        public string getUserId()
        {
            return this.UserId;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getVorname()
        {
            return this.Vorname;
        }

        public string getStrasse()
        {
            return this.Strasse;
        }

        public int getPlz()
        {
            return this.Plz;
        }

        public string getHausnummer()
        {
            return this.Hausnummer;
        }

        public string getAdresse()
        {
            return this.Adresse;
        }

        public string getAnstellungsZeit()
        {
            return this.Anstellungszeit;
        }

        public double getLohnGehalt()
        {
            return this.Lohngehalt;
        }

        public string getUserStatus()
        {
            return this.UserStatus;
        }

        public string getAccount()
        {
            return this.account;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public void setVorname(string Vorname)
        {
            this.Vorname = Vorname;
        }

        public void setHausnummer(string Hausnummer)
        {
            this.Hausnummer = Hausnummer;
        }

       public string concatinateAdresse()
        {
            return this.Adresse = Strasse + " " + this.Hausnummer + " " + this.Plz;
        }

        public void setAnstellungsZeit(string AnstellungsZeit)
        {
            this.Anstellungszeit = AnstellungsZeit;
        }

        public void setLohnGehalt(double LohnGehalt)
        {
            this.Lohngehalt = LohnGehalt;
        }

        public void setUserStatus(string UserStatus)
        {
            this.UserStatus = UserStatus;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setAccount(string account)
        {
            this.account = account;
        }

        override
        public string ToString()
        {
            return this.UserId + " " +
            this.Name + " " +
            this.Vorname + " " +
            this.Strasse + " " +
            this.Hausnummer + " " +
            this.Plz + " " +
            this.Adresse + " " +
            this.Anstellungszeit + " " +
            this.Lohngehalt + " " +
            this.UserStatus + " " +
            this.account + " " +
            this.password;
        }

    }
}
