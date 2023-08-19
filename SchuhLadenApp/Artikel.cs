using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchuhLadenApp
{
    internal class Artikel
    {

        private string ArtikelId;
        private string Name;
        private string Lieferant;
        private double Preis;
        private int Menge;

        public Artikel() { }
        public Artikel(string artikelId, string name, string lieferant, double preis, int menge)
        {
            this.ArtikelId = artikelId;
            this.Name = name;
            this.Lieferant = lieferant;
            this.Preis = preis;
            this.Menge = menge;
        }
        public Artikel(string name, string lieferant, double preis, int menge)
        {
            this.Name = name;
            this.Lieferant = lieferant;
            this.Preis = preis;
            this.Menge = menge;
        }

        public string CalculateArtikelId()
        {

            string teilOne;
            string teilTwo;
            string teilThree;

            teilOne = this.Name.Substring(0, 3);
            teilTwo = this.Lieferant.Substring(0, 3);
            Random random = new Random();
            teilThree = random.NextDouble().ToString();

            string generatedArtikelId = teilOne + teilTwo;

            return generatedArtikelId;

        }

        public static List<Artikel> retrieveArtikelFromDb()
        {

            List<Artikel> artikels = new List<Artikel>();

            DatabaseHelper databaseHelper = new DatabaseHelper();

            using (SQLiteConnection connection = databaseHelper.OpenConnection())
            {
                string query = "SELECT * FROM artikel";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            string ArtikelId = reader.GetString(0);
                            string Name = reader.GetString(1);
                            string Lieferant = reader.GetString(2);
                            double Preis = reader.GetDouble(3);
                            int Menge = reader.GetInt32(4);

                            Artikel artikel = new Artikel(ArtikelId, Name, Lieferant, Preis, Menge);

                            artikels.Add(artikel);

                        }

                    }
                }
                databaseHelper.CloseConnection(connection);
            }

            return artikels;
        }

        public bool checkIfArtikelExists()
        {
            List<Artikel> artikels = retrieveArtikelFromDb();

            foreach (Artikel artikel in artikels)
            {
                if (this.ArtikelId == artikel.ArtikelId)
                {
                    return true;
                }
            }

            return false;

        }

        public Artikel getExistingUser(string artikelIdInput)
        {
            List<Artikel> artikels = retrieveArtikelFromDb();

            foreach (Artikel artikel in artikels)
            {

                if (artikel.getArtikelId() == artikelIdInput)
                {

                    return artikel;
                }
            }

            /* string input = tbxInput2.Text.ToString();

       User user = new User().getExistingUser(input);

       tbxTestInput.Text = user.ToString();*/

            return null;
        }

        public void addNewArtikel()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            using (SQLiteConnection connection = databaseHelper.OpenConnection())
            {
                string query = "INSERT INTO artikel(artikelid, name, lieferant, preis, menge) " +
                    "VALUES (@artikelid, @name, @lieferant, @preis, @menge) ";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@artikelid", this.getArtikelId());
                    command.Parameters.AddWithValue("@name", this.getName());
                    command.Parameters.AddWithValue("@lieferant", this.getLieferant());
                    command.Parameters.AddWithValue("@preis", this.getPreis());
                    command.Parameters.AddWithValue("@menge", this.getMenge());

                    command.ExecuteNonQuery(); // Execute the INSERT query
                }
                databaseHelper.CloseConnection(connection);
            }
        }

        public void updateArticle()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            using (SQLiteConnection connection = databaseHelper.OpenConnection())
            {
                string query = "UPDATE artikel SET name=@name, lieferant=@lieferant, preis=@preis, menge=@menge " +
                    "WHERE artikelid=@artikelid";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@artikelid", this.getArtikelId());
                    command.Parameters.AddWithValue("@name", this.getName());
                    command.Parameters.AddWithValue("@lieferant", this.getLieferant());
                    command.Parameters.AddWithValue("@preis", this.getPreis());
                    command.Parameters.AddWithValue("@menge", this.getMenge());

                    command.ExecuteNonQuery(); // Execute the INSERT query
                }
                databaseHelper.CloseConnection(connection);
            }
        }

        public void setArtikelId(string ArtikelId)
        {
            this.ArtikelId=ArtikelId;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public void setLieferant(string Lieferant)
        {
            this.Lieferant = Lieferant;
        }

        public void setPreis(double Preis)
        {
            this.Preis = Preis;
        }

        public void setMenge(int Menge)
        {
            this.Menge = Menge;
        }

        public string getArtikelId()
        {
            return this.ArtikelId;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getLieferant()
        {
            return this.Lieferant;
        }

        public double getPreis()
        {
            return this.Preis;
        }

        public int getMenge()
        {
            return this.Menge;
        }
    }
}
