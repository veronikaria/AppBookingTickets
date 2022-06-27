using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormFilmPriceByDate : Form
    {
        private readonly string connStr;
        MySqlDataAdapter adapter1;
        DataSet ds1;
        public FormFilmPriceByDate(string connection)
        {
            InitializeComponent();
            this.connStr = connection;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command;
            string film;
            try
            {
                film = comboBoxFilm.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter1 = new MySqlDataAdapter();
                command = new MySqlCommand("sp_PricesByRequirements", conn);
                command.Parameters.AddWithValue("@filmName", film);
                command.CommandType = CommandType.StoredProcedure;
                adapter1.SelectCommand = command;
                ds1 = new DataSet();
                this.adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
            }
            
        }

        private void FormFilmPriceByDate_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmdFilm = new MySqlCommand("SELECT Name FROM Film", conn);

            conn.Open();
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
    }
}
