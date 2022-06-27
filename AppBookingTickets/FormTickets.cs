using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormTickets : Form
    {
        MySqlDataAdapter adapter1;
        DataSet ds1;
        string connStr;
        double totalPrice;
        string benefits = "Немає";
        public FormTickets(string connection)
        {
            connStr = connection;
            InitializeComponent();
        }

        public static void CallProcedure(MySqlConnection conn, 
            DataGridView view, string proc, Dictionary<string, string> args)
        {
            MySqlCommand command;

            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command = new MySqlCommand(proc, conn);
            
            if(args!=null)
                foreach (var kv in args)
                    command.Parameters.AddWithValue(kv.Key, kv.Value);
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            view.DataSource = ds.Tables[0];

            conn.Close();
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            string film;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                film = comboBoxFilm.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (checkBoxDate.Checked && checkBoxTime.Checked && checkBoxHall.Checked)
            {
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                string date = dt1.ToString("yyyy-MM-dd");
                string time = dt2.ToString("hh:mm:ss");
                string hall = comboBoxHall.SelectedItem.ToString();

                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameDateTimeHall",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@ddate",date},
                        { "@ttime",time},
                        { "@hallName",hall},
                    });
                return;
            }


            if (checkBoxDate.Checked && checkBoxTime.Checked)
            {
                DateTime dt1 = dateTimePicker1.Value;
                DateTime dt2 = dateTimePicker2.Value;
                string date = dt1.ToString("yyyy-MM-dd");
                string time = dt2.ToString("hh:mm:ss");
                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameDateTime",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@ddate",date},
                        { "@ttime",time}
                    });
                return;
            }

            if (checkBoxDate.Checked && checkBoxHall.Checked)
            {
                DateTime dt1 = dateTimePicker1.Value;
                string date = dt1.ToString("yyyy-MM-dd");
                string hall = comboBoxHall.SelectedItem.ToString();

                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameDateHall",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@ddate",date},
                        { "@hallName",hall}
                    });
                return;
            }


            if (checkBoxTime.Checked && checkBoxHall.Checked)
            {
                DateTime dt2 = dateTimePicker2.Value;
                string time = dt2.ToString("hh:mm:ss");
                string hall = comboBoxHall.SelectedItem.ToString();

                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameTimeHall",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@ttime",time},
                        { "@hallName",hall}
                    });
                return;
            }

            if (checkBoxDate.Checked)
            {
                DateTime dt = dateTimePicker1.Value;
                string date = dt.ToString("yyyy-MM-dd");
                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameDate",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@ddate",date}
                    });

                return;
            }

            if (checkBoxTime.Checked)
            {
                DateTime dt = dateTimePicker1.Value;
                string time = dt.ToString("hh:mm:ss");
                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameTime",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@ttime",time}
                    });

                return;
            }

            if (checkBoxHall.Checked)
            {
                string hall = comboBoxHall.SelectedItem.ToString();
                CallProcedure(conn, dataGridView1, "sp_BookingInfoByNameHall",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film},
                        { "@hall",hall}
                    });

                return;
            }

            CallProcedure(conn, dataGridView1, "sp_BookingInfoByName",
                    new Dictionary<string, string>
                    {
                        { "@filmName",film}
                    });


        }

        private void FormTickets_Load(object sender, EventArgs e)
        {
            checkBoxDate.Checked = false;
            checkBoxHall.Checked = false;
            checkBoxTime.Checked = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBoxHall.Visible = false;
            dateTimePicker1.Value = new DateTime(2022, 5, 5);
            dateTimePicker2.Value = new DateTime(2022, 5, 5, 10, 0, 0);

            MySqlConnection conn = new MySqlConnection(connStr);

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter1 = new MySqlDataAdapter("sp_BookingInfo", connection);
                ds1 = new DataSet();
                this.adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
            }

            MySqlCommand cmdHall = new MySqlCommand("SELECT Name FROM Hall", conn);
            MySqlCommand cmdFilm = new MySqlCommand("SELECT Name FROM Film", conn);

            conn.Open();
            MySqlDataReader readerHall = cmdHall.ExecuteReader();
            if (readerHall.HasRows)
            {
                while (readerHall.Read())
                {
                    comboBoxHall.Items.Add(readerHall.GetString(0));
                }
            }
            conn.Close();

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

            comboBoxBenefits.Items.AddRange(new string[] { "Немає", "Школяр", "Студент" });

        }

        

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            string sqlInsert = "INSERT Ticket (Date, Time, Customer, BookingId, Benefits, EndPrice) " +
                        "VALUES (@date, @time, @customer, @bookingId, @benefits, @endPrice)";
            string sql = "UPDATE Booking SET IsSold=TRUE WHERE Id=@id";

            //benefits = comboBoxBenefits?.SelectedItem.ToString();
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn = new MySqlConnection(connStr);
                    cmd = new MySqlCommand(sqlInsert, conn);

                    conn.Open();

                    string dd = row.Cells["Date"].Value.ToString();
                    string tt = row.Cells["Time"].Value.ToString();
                    DateTime dateOnly = DateTime.Parse(dd).Date;
                    DateTime timeOnly = DateTime.Parse(tt);
                    DateTime combined = dateOnly.Date.Add(timeOnly.TimeOfDay);
                    
                    string date = combined.ToString("yyyy-MM-dd");
                    string time = combined.ToString("HH:mm:ss");

                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@customer", textBoxCustomer.Text);
                    cmd.Parameters.AddWithValue("@bookingId", id);
                    cmd.Parameters.AddWithValue("@benefits", benefits);
                    cmd.Parameters.AddWithValue("@endPrice", row.Cells["Price"].Value.ToString().Replace(',','.'));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else 
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    int rowindex = cell.RowIndex;
                    if (rowindex != -1)
                    {
                        int id = Int32.Parse(dataGridView1.Rows[rowindex].Cells["Id"].Value.ToString());
                        conn = new MySqlConnection(connStr);
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        conn = new MySqlConnection(connStr);
                        cmd = new MySqlCommand(sqlInsert, conn);

                        conn.Open();

                        string dd = dataGridView1.Rows[rowindex].Cells["Date"].Value.ToString();
                        string tt = dataGridView1.Rows[rowindex].Cells["Time"].Value.ToString();
                        DateTime dateOnly = DateTime.Parse(dd).Date;
                        DateTime timeOnly = DateTime.Parse(tt);
                        DateTime combined = dateOnly.Date.Add(timeOnly.TimeOfDay);

                        string date = combined.ToString("yyyy-MM-dd");
                        string time = combined.ToString("HH:mm:ss");

                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@customer", textBoxCustomer.Text);
                        cmd.Parameters.AddWithValue("@bookingId", id);
                        cmd.Parameters.AddWithValue("@benefits", benefits);
                        cmd.Parameters.AddWithValue("@endPrice", dataGridView1.Rows[rowindex].Cells["Price"].Value.ToString());
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
            
            MessageBox.Show("Білет(-и) куплено!");
            textBoxEndPrice.Clear();
            CallProcedure(conn, dataGridView1, "sp_BookingInfo", null);
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked)
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
            {
                dateTimePicker2.Visible = true;
            }
            else
            {
                dateTimePicker2.Visible = false;
            }
        }

        private void checkBoxHall_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHall.Checked)
            {
                comboBoxHall.Visible = true;
            }
            else
            {
                comboBoxHall.Visible = false;
            }
        }

        private void buttonEndPrice_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    double price = Double.Parse(row.Cells["Price"].Value.ToString());
                    totalPrice += price;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    int rowindex = cell.RowIndex;
                    if (rowindex != -1)
                    {
                        double price = Double.Parse(dataGridView1.Rows[rowindex].Cells["Price"].Value.ToString());
                        totalPrice += price;
                    }
                }
            }
            try
            {
                benefits = comboBoxBenefits.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (benefits == "Школяр")
            {
                totalPrice = totalPrice * 0.8;
                textBoxEndPrice.Text = totalPrice.ToString();
            }
            else if (benefits == "Студент")
            {
                totalPrice = totalPrice * 0.9;
                textBoxEndPrice.Text = totalPrice.ToString();
            }
            else if (benefits == "Немає")
            {
                textBoxEndPrice.Text = totalPrice.ToString();
            }
        }

        private void comboBoxBenefits_SelectedIndexChanged(object sender, EventArgs e)
        {
            benefits = comboBoxBenefits?.SelectedItem.ToString();
        }
    }
}

