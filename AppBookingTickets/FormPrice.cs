using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormPrice : Form
    {
        public int id = -1;
        public string date = string.Empty;
        public string time = string.Empty;
        public string category = string.Empty;
        public int categoryId = 0;
        public double price = 0;

        public FormAdministration Administration { get; }

        public FormPrice(FormAdministration administration, int id = -1,
             string date = "", string time = "", int categoryid=0, double price = 0)
        {
            InitializeComponent();
            Administration = administration;
            this.id = id;
            if (id != -1) 
            {
                this.categoryId = categoryid;
                dateTimePicker1.Value = DateTime.Parse(date);
                dateTimePicker2.Value = DateTime.Parse(time);
                textBoxPrice.Text = price.ToString();
            }
        }
         
        private void buttonSave_Click(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToString();
            time = dateTimePicker2.Value.ToString();
            price = Double.Parse(textBoxPrice.Text);
            category = comboBoxCategory.SelectedItem.ToString();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (date != string.Empty && time != string.Empty)
            {
                if (id == -1)
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("INSERT Price(Date, Time, CategoryId, Cost) VALUES (@date,@time,@categoryid,@cost)", conn);
                    MySqlCommand cmdFind = new MySqlCommand("SELECT Id FROM Category WHERE Name=@name", conn);
                    conn.Open();

                    cmdFind.Parameters.AddWithValue("@name", category);
                    this.categoryId = Int32.Parse(cmdFind.ExecuteScalar().ToString());
                    
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@categoryid", categoryId);
                    cmd.Parameters.AddWithValue("@cost", price);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(Administration.connStr);
                    MySqlCommand cmd = new MySqlCommand("UPDATE Category SET Date=@date, Time=@time, Cost=@cost WHERE Id=@categoryid", conn);
                    MySqlCommand cmdFind = new MySqlCommand("SELECT Id FROM Category WHERE Name=@name", conn);
                    conn.Open();
                    cmdFind.Parameters.AddWithValue("@name", category);
                    this.categoryId = Int32.Parse(cmdFind.ExecuteScalar().ToString());

                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@categoryid", categoryId);
                    cmd.Parameters.AddWithValue("@cost", price);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                Administration.fillPrice();
            }
        }

        private void FormPrice_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Administration.connStr);
            MySqlCommand cmd = new MySqlCommand("SELECT Name FROM Category", conn);
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxCategory.Items.Add(reader.GetString(0));
                }
            }

            conn.Close();

            if (id != -1)
            {
                conn = new MySqlConnection(Administration.connStr);
                cmd = new MySqlCommand("SELECT Name FROM Category WHERE Id=@categoryid", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@categoryid", categoryId);

                string categoryName = cmd.ExecuteScalar().ToString();
                comboBoxCategory.SelectedIndex = comboBoxCategory.FindStringExact(categoryName);
                conn.Close();

            }
        }
    }
}
