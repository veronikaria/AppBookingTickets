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
    public partial class FormGenre : Form
    {
        public int id = -1;
        public string name = string.Empty;
        public string description = string.Empty;
        public FormAdministration Administration { get; }
        public FormGenre(FormAdministration administration,
            int id = -1, string name = "", string description="")
        {
            InitializeComponent();
            Administration = administration;
            this.id = id;
            if (id != -1)
            {
                this.textBoxName.Text = name;
                this.richTextBoxDescription.Text = description;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            description = richTextBoxDescription.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (name != string.Empty)
            {
                if (id == -1)
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("INSERT Genre(Name, Description) VALUES (@name, @description)", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("UPDATE Genre SET Name=@name, Description=@description WHERE Id=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                Administration.fillGenre();
            }
        }
    }
}
