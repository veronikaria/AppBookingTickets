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
    public partial class FormMain : Form
    {
        string connection = "server=localhost;uid=root;database=BookingTickets;pwd=asdf";

        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonMyTickets_Click(object sender, EventArgs e)
        {
            FormMyTickets form = new FormMyTickets(connection);
            form.Show();
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            FormAdmin form = new FormAdmin();
            form.ShowDialog();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            FormTickets form = new FormTickets(connection);
            form.Show();
        }

        private void buttonListByDate_Click(object sender, EventArgs e)
        {
            FormFilmByWeekday form = new FormFilmByWeekday(connection);
            form.Show();
        }

        private void buttonListByData_Click(object sender, EventArgs e)
        {
            FormFilmByData form = new FormFilmByData(connection);
            form.Show();
        }

        private void buttonPrices_Click(object sender, EventArgs e)
        {
            FormFilmPriceByDate form = new FormFilmPriceByDate(connection);
            form.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
