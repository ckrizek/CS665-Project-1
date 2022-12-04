// Nicholas Krizek | CS665 CRUD APPLICATION | 27NOV2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CS665_Project_1
{
    public partial class Form1 : Form
    {
        
        string path = "roomers_database.db";
        string cs = @"URI=file:"+Application.StartupPath+"\\roomers_database.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;


        public Form1()
        {
            InitializeComponent();
        }

        private void data_show()
        {

            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM roommate";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string roommate_sql = "create table roommate(id string, name string, username string, email string, created string, gender string, addr string, state string, country string)";
                    SQLiteCommand command = new SQLiteCommand(roommate_sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database already exists.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO roommate (id, name, Username, Email, Created, Gender, Addr, State, Country) VALUES (@id, @name, @Username, @Email, @Created, @Gender, @Addr, @State, @Country)";

                string NAME = name_txt.Text;
                string ID = id_txt.Text;
                string USERNAME = username_txt.Text;
                string EMAIL = email_txt.Text;
                string CREATED_AT = created_at_txt.Text;
                string GENDER = gender_txt.Text;
                string ADDR = addr_txt.Text;
                string STATE = state_txt.Text;
                string COUNTRY = country_txt.Text;

                cmd.Parameters.AddWithValue("@name", NAME);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@Username", USERNAME);
                cmd.Parameters.AddWithValue("@Email", EMAIL);
                cmd.Parameters.AddWithValue("@Created", CREATED_AT);
                cmd.Parameters.AddWithValue("@Gender", GENDER);
                cmd.Parameters.AddWithValue("@Addr", ADDR);
                cmd.Parameters.AddWithValue("@State", STATE);
                cmd.Parameters.AddWithValue("@Country", COUNTRY);

                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].Name = "id";
                dataGridView1.Columns[1].Name = "name";
                dataGridView1.Columns[2].Name = "Username";
                dataGridView1.Columns[3].Name = "Email";
                dataGridView1.Columns[4].Name = "Created";
                dataGridView1.Columns[5].Name = "Gender";
                dataGridView1.Columns[6].Name = "Address";
                dataGridView1.Columns[7].Name = "State";
                dataGridView1.Columns[8].Name = "Country";
                string[] row = new string[] { ID, NAME, USERNAME, EMAIL, CREATED_AT, GENDER, ADDR, STATE, COUNTRY };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "UPDATE roommate Set name=@name, username=@Username, email=@Email, created=@Created, gender=@Gender, addr=@Addr, state=@State, country=@Country where id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", name_txt.Text);
                cmd.Parameters.AddWithValue("@id", id_txt.Text);
                cmd.Parameters.AddWithValue("@Username", username_txt.Text);
                cmd.Parameters.AddWithValue("@Email", email_txt.Text);
                cmd.Parameters.AddWithValue("@Created", created_at_txt.Text);
                cmd.Parameters.AddWithValue("@Gender", gender_txt.Text);
                cmd.Parameters.AddWithValue("@Addr", addr_txt.Text);
                cmd.Parameters.AddWithValue("@State", state_txt.Text);
                cmd.Parameters.AddWithValue("@Country", country_txt.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();


            }
            catch (Exception)
            {
                Console.WriteLine("cannot update data");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                cmd.CommandText = "DELETE FROM roommate where id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", name_txt.Text);
                cmd.Parameters.AddWithValue("@id", id_txt.Text);
                cmd.Parameters.AddWithValue("@Username", username_txt.Text);
                cmd.Parameters.AddWithValue("@Email", email_txt.Text);
                cmd.Parameters.AddWithValue("@Created", created_at_txt.Text);
                cmd.Parameters.AddWithValue("@Gender", gender_txt.Text);
                cmd.Parameters.AddWithValue("@Addr", addr_txt.Text);
                cmd.Parameters.AddWithValue("@State", state_txt.Text);
                cmd.Parameters.AddWithValue("@Country", country_txt.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delete data");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                id_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                username_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                email_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                created_at_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Created"].FormattedValue.ToString();
                gender_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                addr_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Addr"].FormattedValue.ToString();
                state_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["State"].FormattedValue.ToString();
                country_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Country"].FormattedValue.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void created_at_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addr_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void state_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }
    }
}
