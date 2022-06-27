using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormProduction : Form
    {
        public int id = -1;
        public string name = string.Empty;
        public string city = string.Empty;
        public string studio = string.Empty;

        public FormAdministration Administration { get; }

        public FormProduction(FormAdministration administration, int id=-1, 
            string name="", string city="", string studio="")
        {
            InitializeComponent();
            Administration = administration;
            this.id = id;
            if (id != -1) 
            {
                this.textBoxName.Text = name;
                this.textBoxCity.Text = city;
                this.textBoxStudio.Text = studio;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            city = textBoxCity.Text;
            studio = textBoxStudio.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduction_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (name != string.Empty && city != string.Empty && studio != string.Empty)
            {
                if (id == -1) 
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("INSERT Production(Name, City, Studio) VALUES (@name,@city,@studio)", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@studio", studio);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("UPDATE Production SET Name=@name, City=@city, Studio=@studio WHERE Id=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@studio", studio);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                Administration.fillProduction();
            }
        }
    }
}
