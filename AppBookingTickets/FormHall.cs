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
    public partial class FormHall : Form
    {
        public int id = -1;
        public string name = string.Empty;
        public FormAdministration Administration { get; }

        public FormHall(FormAdministration administration, int id = -1,
            string name = "")
        {
            InitializeComponent();
            Administration = administration;
            this.id = id;
            if (id != -1)
            {
                this.textBoxName.Text = name;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHall_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (name != string.Empty)
            {
                if (id == -1)
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("INSERT Hall(Name) VALUES (@name)", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("UPDATE Hall SET Name=@name WHERE Id=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                Administration.fillHall();
            }
        }
    }
}
