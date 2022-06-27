using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormFilmByData : Form
    {
        private readonly string connStr;
        DataSet ds1;
        MySqlDataAdapter adapter1;
        string film = "";
        string production = "";
        string genre = "";
        public FormFilmByData(string connection)
        {
            InitializeComponent();
            this.connStr = connection;
        }

        string formSql(string film, string production, string genre) 
        {
            return "SELECT f.Name AS Film, g.Name AS Genre, p.Name AS Production " +
                "FROM Film f " +
                "JOIN Genre g ON g.Id=f.GenreId " +
                "JOIN Production p ON p.Id=f.ProductionId " +
                "WHERE f.Name LIKE '%" + film + "%' AND " +
                "p.Name LIKE '%" + production + "%' AND g.Name LIKE '%" + genre + "%'";
        }


        private void LoadData() 
        {
            UpdateData();

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmdGenre = new MySqlCommand("SELECT Name FROM Genre", conn);
            MySqlDataReader readerGenre = cmdGenre.ExecuteReader();
            if (readerGenre.HasRows)
            {
                while (readerGenre.Read())
                {
                    comboBoxGenre.Items.Add(readerGenre.GetString(0));
                }
            }
            conn.Close();

            conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmdProduction = new MySqlCommand("SELECT Name FROM Production", conn);
            MySqlDataReader readerProduction = cmdProduction.ExecuteReader();
            if (readerProduction.HasRows)
            {
                while (readerProduction.Read())
                {
                    comboBoxProduction.Items.Add(readerProduction.GetString(0));
                }
            }
            conn.Close();


            conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmdFilm = new MySqlCommand("SELECT Name FROM Film", conn);
            MySqlDataReader readerFilm = cmdFilm.ExecuteReader();
            if (readerFilm.HasRows)
            {
                while (readerFilm.Read())
                {
                    comboBoxFilm.Items.Add(readerFilm.GetString(0));
                }
            }
            conn.Close();
        }

        private void FormFilmByData_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxGenre_TextChanged(object sender, EventArgs e)
        {
            genre = comboBoxGenre.Text;
            UpdateData();
        }

        void UpdateData()
        {
            string sql = formSql(film, production, genre);

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter1 = new MySqlDataAdapter(sql, connection);
                ds1 = new DataSet();
                this.adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
            }
            textBoxTotal.Text = (dataGridView1.Rows.Count-1).ToString();
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre = comboBoxGenre.SelectedItem.ToString();
            UpdateData();
        }


        private void comboBoxProduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            production = comboBoxProduction.SelectedItem.ToString();
            UpdateData();
        }

        private void comboBoxProduction_TextChanged(object sender, EventArgs e)
        {
            production = comboBoxProduction.Text;
            UpdateData();
        }


        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            film = comboBoxFilm.SelectedItem.ToString();
            UpdateData();
        }

        private void comboBoxFilm_TextChanged(object sender, EventArgs e)
        {
            film = comboBoxFilm.Text;
            UpdateData();
        }
    }
}
