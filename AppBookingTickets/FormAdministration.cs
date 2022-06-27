using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppBookingTickets
{
    public partial class FormAdministration : Form
    {
        public string connStr = "server=localhost;uid=root;database=BookingTickets;pwd=asdf";

        DataSet ds1, ds2, ds3, ds4, ds5, ds6, ds7;
        MySqlDataAdapter adapter1, adapter2, adapter3, adapter4, adapter5, adapter6, adapter7;



        string sql1 = "SELECT * FROM Film";
        string sql2 = "SELECT * FROM Production";
        string sql3 = "SELECT * FROM Genre";
        string sql4 = "SELECT * FROM Hall";
        string sql5 = "SELECT * FROM Category";
        string sql6 = "SELECT * FROM Price";
        string sql7 = "SELECT * FROM Country";

        private void buttonCountryAdd_Click(object sender, EventArgs e)
        {
            FormCountry country = new FormCountry(this);
            country.Show();
        }

        private void buttonCountryChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView4.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView7.Rows[rowindex].Cells["Id"].Value.ToString());
            string name = dataGridView7.Rows[rowindex].Cells["Name"].Value.ToString();
            FormCountry country = new FormCountry(this, id, name);
            country.Show();
        }

        private void buttonCountryDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView7.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Country WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView7.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView7.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView7.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Country WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView7.Rows.Remove(dataGridView7.Rows[rowindex]);
                }
            }
            this.fillCountry();
        }

        private void buttonProductionDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Production WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView2.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView2.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView2.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Production WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView2.Rows.Remove(dataGridView2.Rows[rowindex]);
                }
            }
            this.fillProduction();
        }

        private void buttonProductionChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView2.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView2.Rows[rowindex].Cells["Id"].Value.ToString());
            string name = dataGridView2.Rows[rowindex].Cells["Name"].Value.ToString();
            string city = dataGridView2.Rows[rowindex].Cells["City"].Value.ToString();
            string studio = dataGridView2.Rows[rowindex].Cells["Studio"].Value.ToString();
            FormProduction production = new FormProduction(this, id, name, city, studio);
            production.Show();
        }

        private void buttonProductionAdd_Click(object sender, EventArgs e)
        {
            FormProduction production = new FormProduction(this);
            production.Show();

        }

        private void buttonHallAdd_Click(object sender, EventArgs e)
        {
            FormHall hall = new FormHall(this);
            hall.Show();
        }

        private void buttonHallChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView4.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView4.Rows[rowindex].Cells["Id"].Value.ToString());
            string name = dataGridView4.Rows[rowindex].Cells["Name"].Value.ToString();
            FormHall hall = new FormHall(this, id, name);
            hall.Show();
        }

        private void buttonHallDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView4.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Hall WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView4.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView4.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView4.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Hall WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView4.Rows.Remove(dataGridView4.Rows[rowindex]);
                }
            }
            this.fillHall();
        }

        private void buttonCategoryAdd_Click(object sender, EventArgs e)
        {
            FormCategory category = new FormCategory(this);
            category.Show();
        }

        private void buttonCategoryChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView5.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView5.Rows[rowindex].Cells["Id"].Value.ToString());
            string name = dataGridView5.Rows[rowindex].Cells["Name"].Value.ToString();
            FormCategory category = new FormCategory(this, id, name);
            category.Show();
        }

        private void buttonCategoryDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView5.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Category WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView5.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView5.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView5.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Category WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView5.Rows.Remove(dataGridView5.Rows[rowindex]);
                }
            }
            this.fillCategory();
        }

        private void buttonGenreAdd_Click(object sender, EventArgs e)
        {
            FormGenre genre = new FormGenre(this);
            genre.Show();
        }

        private void buttonGenreChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView3.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView3.Rows[rowindex].Cells["Id"].Value.ToString());
            string name = dataGridView3.Rows[rowindex].Cells["Name"].Value.ToString();
            string description = dataGridView3.Rows[rowindex].Cells["Description"].Value.ToString();
            FormGenre genre = new FormGenre(this, id, name, description);
            genre.Show();
        }

        private void buttonGenreDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Genre WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView3.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView3.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView3.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Genre WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView3.Rows.Remove(dataGridView3.Rows[rowindex]);
                }
            }
            this.fillGenre();
        }

        private void buttonPriceAdd_Click(object sender, EventArgs e)
        {
            FormPrice price = new FormPrice(this);
            price.Show();
        }


        private void buttonChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView6.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView6.Rows[rowindex].Cells["Id"].Value.ToString());
            string date = dataGridView6.Rows[rowindex].Cells["Date"].Value.ToString();
            string time = dataGridView6.Rows[rowindex].Cells["Time"].Value.ToString();
            int categoryid = Int32.Parse(dataGridView6.Rows[rowindex].Cells["CategoryId"].Value.ToString());
            double price = Double.Parse(dataGridView6.Rows[rowindex].Cells["Cost"].Value.ToString());
            FormPrice form = new FormPrice(this, id, date, time, categoryid, price);
            form.Show();
        }

        private void buttonPriceDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView6.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Price WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView6.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView6.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView6.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Price WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView6.Rows.Remove(dataGridView6.Rows[rowindex]);
                }
            }
            this.fillPrice();
        }


        public FormAdministration()
        {
            InitializeComponent();
        }


        public void fillFilm()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter1 = new MySqlDataAdapter(sql1, connection);
                ds1 = new DataSet();
                this.adapter1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
                dataGridView1.Columns["Id"].ReadOnly = true;
            }
        }

        public void fillProduction()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter2 = new MySqlDataAdapter(sql2, connection);
                ds2 = new DataSet();
                this.adapter2.Fill(ds2);
                dataGridView2.DataSource = ds2.Tables[0];
                dataGridView2.Columns["Id"].ReadOnly = true;
            }
        }

        public void fillGenre()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter3 = new MySqlDataAdapter(sql3, connection);
                ds3 = new DataSet();
                this.adapter3.Fill(ds3);
                dataGridView3.DataSource = ds3.Tables[0];
                dataGridView3.Columns["Id"].ReadOnly = true;
            }
        }

        public void fillHall()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter4 = new MySqlDataAdapter(sql4, connection);
                ds4 = new DataSet();
                this.adapter4.Fill(ds4);
                dataGridView4.DataSource = ds4.Tables[0];
                dataGridView4.Columns["Id"].ReadOnly = true;
            }
        }

        public void fillCategory()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter5 = new MySqlDataAdapter(sql5, connection);
                ds5 = new DataSet();
                this.adapter5.Fill(ds5);
                dataGridView5.DataSource = ds5.Tables[0];
                dataGridView5.Columns["Id"].ReadOnly = true;
            }
        }

        public void fillPrice()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter6 = new MySqlDataAdapter(sql6, connection);
                ds6 = new DataSet();
                this.adapter6.Fill(ds6);
                dataGridView6.DataSource = ds6.Tables[0];
                dataGridView6.Columns["Id"].ReadOnly = true;
            }
        }

        public void fillCountry()
        {
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                adapter7 = new MySqlDataAdapter(sql7, connection);
                ds7 = new DataSet();
                this.adapter7.Fill(ds7);
                dataGridView7.DataSource = ds7.Tables[0];
                dataGridView7.Columns["Id"].ReadOnly = true;
            }
        }

        private void FormAdministration_Load(object sender, EventArgs e)
        {
            this.fillFilm();
            this.fillProduction();
            this.fillCategory();
            this.fillPrice();
            this.fillCountry();
            this.fillGenre();
            this.fillHall();
        }

        private void buttonFilmAdd_Click(object sender, EventArgs e)
        {
            FormFilm film = new FormFilm(this);
            film.Show();
        }


        private void buttonFilmChange_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[rowindex].Cells["Id"].Value.ToString());
            string name = dataGridView1.Rows[rowindex].Cells["Name"].Value.ToString();
            int duration = Int32.Parse(dataGridView1.Rows[rowindex].Cells["Duration"].Value.ToString());
            int yearOfIssue = Int32.Parse(dataGridView1.Rows[rowindex].Cells["YearOfIssue"].Value.ToString());
            string ageConstraint = dataGridView1.Rows[rowindex].Cells["AgeConstraint"].Value.ToString();
            int productionId = Int32.Parse(dataGridView1.Rows[rowindex].Cells["ProductionId"].Value.ToString());
            int genreId = Int32.Parse(dataGridView1.Rows[rowindex].Cells["GenreId"].Value.ToString());
            int countryId = Int32.Parse(dataGridView1.Rows[rowindex].Cells["CountryId"].Value.ToString());
            string description = dataGridView1.Rows[rowindex].Cells["Description"].Value.ToString();
            FormFilm form = new FormFilm(this, id, name, duration, yearOfIssue,ageConstraint, productionId, genreId,countryId, description);
            form.Show();
        }

        private void buttonFilmDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Int32.Parse(row.Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Film WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.Remove(row);
                }
                return;
            }
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                int rowindex = cell.RowIndex;
                if (rowindex != -1)
                {
                    int id = Int32.Parse(dataGridView1.Rows[rowindex].Cells["Id"].Value.ToString());
                    string sql = "DELETE FROM Film WHERE Id=@id";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.Remove(dataGridView1.Rows[rowindex]);
                }
            }
            this.fillFilm();
        }
    }
}
