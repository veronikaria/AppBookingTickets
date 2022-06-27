using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormMyTickets : Form
    {
        private readonly string connection;

        public FormMyTickets(string connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("sp_TicketByIdCustomer", conn);
            conn.Open();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Int32.Parse(textBoxTicketNo.Text));
                cmd.Parameters.AddWithValue("@customer", textBoxLastName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                groupBox1.Visible = true;
                labelError.Visible = false;

                while (reader.Read())
                {
                    textBoxTicket.Text = reader.GetString(0);
                    textBoxCategory.Text = reader.GetString(1);
                    textBoxHall.Text = reader.GetString(2);
                    textBoxPlaceAndRow.Text = "Ряд: " + reader.GetString(3) + "; місце: " + reader.GetString(4);
                    DateTime date = DateTime.Parse(reader.GetString(5)).Date;
                    DateTime time = DateTime.Parse(reader.GetString(6));
                    DateTime combined = date.Date.Add(time.TimeOfDay);
                    textBoxDateAndTime.Text = combined.ToString("yyyy-MM-dd HH:mm");
                    textBoxFilm.Text = reader.GetString(7);
                }
            }
            else
            {
                labelError.Visible = true;
                groupBox1.Visible = false;
            }

            conn.Close();
        }

        private void FormMyTickets_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            groupBox1.Visible = false;
        }
    }
}
