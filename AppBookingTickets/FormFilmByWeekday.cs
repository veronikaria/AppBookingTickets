using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormFilmByWeekday : Form
    {
        string connection;
        public FormFilmByWeekday(string connection)
        {
            InitializeComponent();
            this.connection = connection;
        }


        private void buttonFind_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            int index = comboBoxWeekday.SelectedIndex;

            DateTime dt1 = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            string time1 = dt1.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            string time2 = dt2.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

            FormTickets.CallProcedure(conn, dataGridView1, "sp_BookingInfoByWeekdayTime",
                    new Dictionary<string, string>
                    {
                        { "@dayIndex", index.ToString()},
                        { "@ttime1", time1},
                        { "@ttime2", time2},
                    });

        }

        private void FormFilmByWeekday_Load(object sender, EventArgs e)
        {
            comboBoxWeekday.Items.AddRange(new string[]
            {
                "Понеділок","Вівторок","Середа","Четвер", "П'ятниця","Субота","Неділя"
            });
        }
    }
}
