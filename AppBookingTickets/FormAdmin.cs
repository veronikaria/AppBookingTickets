using AppBookingTickets.Properties;
using System;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            if (this.textBoxLogin.Text==Resources.Login && this.textBoxPassword.Text == Resources.Password) 
            {
                FormAdministration form=new FormAdministration();
                form.Show();
            }
            else
            {
                MessageBox.Show("Логін та пароль невірні! Спробуйте ще раз!");
                textBoxLogin.Clear();
                textBoxPassword.Clear();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
