using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormFilm : Form
    {
        public int id = -1;
        public string name = string.Empty;
        public string ageConstraint = String.Empty;
        public string description = String.Empty;
        public string production = string.Empty;
        public int productionId = 0;
        public int countryId = 0;
        public string genre = string.Empty;
        public string country = string.Empty;
        public int genreId = 0;
        public int duration = 0;
        public int yearOfIssue = 0;
        public FormAdministration Administration { get; }

        public FormFilm(FormAdministration administration, int id = -1,
             string name = "", int duration = 0, int yearOfIssue = 0, string ageConstraint = "",
             int productionId = 0, int genreId = 0, int countryId = 0, string description = "")
        {
            InitializeComponent();
            Administration = administration;
            this.id = id;
            if (id != -1)
            {
                this.productionId = productionId;
                this.genreId = genreId;
                this.countryId = genreId;

                textBoxName.Text = name.ToString();
                textBoxAgeConstraint.Text = ageConstraint.ToString();
                textBoxDuration.Text = duration.ToString();
                textBoxYearOfIssue.Text = yearOfIssue.ToString();
                richTextBoxDescription.Text = description;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            ageConstraint = textBoxAgeConstraint.Text;
            duration = Int32.Parse(textBoxDuration.Text);
            yearOfIssue = Int32.Parse(textBoxYearOfIssue.Text);
            description = richTextBoxDescription.Text;
            production = comboBoxProduction.SelectedItem.ToString();
            genre = comboBoxGenre.SelectedItem.ToString();
            country = comboBoxCountry.SelectedItem.ToString();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFilm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Administration.connStr);
            MySqlCommand cmdProd = new MySqlCommand("SELECT Name FROM Production", conn);
            conn.Open();
            MySqlDataReader readerProd = cmdProd.ExecuteReader();
            if (readerProd.HasRows)
            {
                while (readerProd.Read())
                {
                    comboBoxProduction.Items.Add(readerProd.GetString(0));
                }
            }
            conn.Close();

            MySqlCommand cmdGenre = new MySqlCommand("SELECT Name FROM Genre", conn);
            conn.Open();
            MySqlDataReader readerGenre = cmdGenre.ExecuteReader();
            if (readerGenre.HasRows)
            {
                while (readerGenre.Read())
                {
                    comboBoxGenre.Items.Add(readerGenre.GetString(0));
                }
            }
            conn.Close();

            MySqlCommand cmdCountry = new MySqlCommand("SELECT Name FROM Country", conn);
            conn.Open();
            MySqlDataReader readerCountry = cmdCountry.ExecuteReader();
            if (readerCountry.HasRows)
            {
                while (readerCountry.Read())
                {
                    comboBoxCountry.Items.Add(readerCountry.GetString(0));
                }
            }
            conn.Close();

            if (productionId != 0 && genreId != 0 && countryId != 0)
            {
                conn = new MySqlConnection(Administration.connStr);
                cmdProd = new MySqlCommand("SELECT Name FROM Production WHERE Id=@productionid", conn);
                cmdGenre = new MySqlCommand("SELECT Name FROM Genre WHERE Id=@genreid", conn);
                cmdCountry = new MySqlCommand("SELECT Name FROM Country WHERE Id=@countryid", conn);
                conn.Open();
                cmdProd.Parameters.AddWithValue("@productionid", productionId);
                cmdGenre.Parameters.AddWithValue("@genreid", genreId);
                cmdCountry.Parameters.AddWithValue("@countryid", countryId);

                string categoryName = cmdProd.ExecuteScalar().ToString();
                comboBoxProduction.SelectedIndex = comboBoxProduction.FindStringExact(categoryName);

                string genreName = cmdGenre.ExecuteScalar().ToString();
                comboBoxGenre.SelectedIndex = comboBoxGenre.FindStringExact(genreName);

                string countryName = cmdCountry.ExecuteScalar().ToString();
                comboBoxCountry.SelectedIndex = comboBoxCountry.FindStringExact(countryName);
            }

            conn.Close();


        }

        private void FormFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (name != string.Empty && duration != 0)
            {
                if (id == -1)
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("INSERT Film(Name, Duration, YearOfIssue, AgeConstraint, " +
                        "ProductionId, GenreId, CountryId, Description) VALUES (@name,@duration,@yearOfIssue,@ageConstraint," +
                        "@productionId, @genreId, @countryid, @description)", conn);
                    MySqlCommand cmdProd = new MySqlCommand("SELECT Id FROM Production WHERE Name=@name", conn);
                    MySqlCommand cmdGenre = new MySqlCommand("SELECT Id FROM Genre WHERE Name=@name", conn);
                    MySqlCommand cmdCountry = new MySqlCommand("SELECT Id FROM Country WHERE Name=@name", conn);
                    conn.Open();

                    cmdProd.Parameters.AddWithValue("@name", production);
                    cmdGenre.Parameters.AddWithValue("@name", genre);
                    cmdCountry.Parameters.AddWithValue("@name", country);
                    int productionId = Int32.Parse(cmdProd.ExecuteScalar().ToString());
                    int genreId = Int32.Parse(cmdGenre.ExecuteScalar().ToString());
                    int countryId = Int32.Parse(cmdCountry.ExecuteScalar().ToString());

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@yearOfIssue", yearOfIssue);
                    cmd.Parameters.AddWithValue("@ageConstraint", ageConstraint);
                    cmd.Parameters.AddWithValue("@productionId", productionId);
                    cmd.Parameters.AddWithValue("@genreId", genreId);
                    cmd.Parameters.AddWithValue("@countryId", countryId);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("UPDATE Film SET Name=@name, Duration=@duration, YearOfIssue=@yearOfIssue," +
                        " AgeConstraint = @ageConstraint, ProductionId=@productionId, GenreId=@genreId, CountryId=@countryid, " +
                        "Description = @description WHERE Id=@filmId", conn);
                    MySqlCommand cmdProd = new MySqlCommand("SELECT Id FROM Production WHERE Name=@name", conn);
                    MySqlCommand cmdGenre = new MySqlCommand("SELECT Id FROM Genre WHERE Name=@name", conn);
                    MySqlCommand cmdCountry = new MySqlCommand("SELECT Id FROM Country WHERE Name=@name", conn);

                    conn.Open();
                    cmdProd.Parameters.AddWithValue("@name", production);
                    cmdGenre.Parameters.AddWithValue("@name", genre);
                    cmdCountry.Parameters.AddWithValue("@name", country);
                    int productionId = Int32.Parse(cmdProd.ExecuteScalar().ToString());
                    int genreId = Int32.Parse(cmdGenre.ExecuteScalar().ToString());
                    int countryId = Int32.Parse(cmdCountry.ExecuteScalar().ToString());

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@yearOfIssue", yearOfIssue);
                    cmd.Parameters.AddWithValue("@ageConstraint", ageConstraint);
                    cmd.Parameters.AddWithValue("@productionId", productionId);
                    cmd.Parameters.AddWithValue("@genreId", genreId);
                    cmd.Parameters.AddWithValue("@countryId", countryId);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@filmId", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                Administration.fillFilm();
            }
        }
    }
}
