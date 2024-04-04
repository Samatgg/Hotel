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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HOtellll
{
    public partial class HotelForm : Form
    {
        private string placeholderText = "Поиск...";
        private string placeholderText2 = "ФИО";

        List<string> names = new List<string>
        {
            "Иванов Иван Петрович",
            "Смирнова Анна Александровна",
            "Петров Сергей Игоревич",
            "Кузнецова Елена Владимировна",
            "Соколов Михаил Васильевич",
            "Попова Ольга Андреевна",
            "Лебедев Артем Викторович",
            "Козлов Дмитрий Николаевич",
            "Новикова Татьяна Ивановна",
            "Морозов Алексей Дмитриевич",
            "Волкова Мария Сергеевна",
            "Алексеев Павел Александрович"
        };
        public HotelForm()
        {
            InitializeComponent();
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            textBox_search.ForeColor = Color.Gray;
            textBox_search.Text = placeholderText;

            textBox_fio.ForeColor = Color.SteelBlue;
            textBox_fio.Text = placeholderText2;
        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_search_Enter(object sender, EventArgs e)
        {
            if(textBox_search.Text == placeholderText)
            {
                textBox_search.Text = "";
                textBox_search.ForeColor = Color.Black;
            }
        }

        private void textBox_search_Leave(object sender, EventArgs e)
        {
            if (textBox_search.Text == "")
            {
                textBox_search.Text = placeholderText;
                textBox_search.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchedName = textBox_search.Text;

            string foundName = names.FirstOrDefault(name => name.Contains(searchedName));

            if (foundName != null)
            {
                resultLabel.Text = foundName;
                textBox_fio.Text = foundName;
                
            }               
            else
            {
                resultLabel.Text = "Человек не найден";
                
            }
        }

        private void textBox_fio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_fio_Enter(object sender, EventArgs e)
        {
            if(textBox_fio.Text == placeholderText2)
            {
                textBox_fio.Text = "";
                textBox_fio.ForeColor = Color.Black;
            }
        }

        private void textBox_fio_Leave(object sender, EventArgs e)
        {
            if(textBox_fio.Text == "")
            {
                textBox_fio.Text = placeholderText2;
                textBox_fio.ForeColor = Color.SteelBlue;
            }
        }

        private void DataGridView_guests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void radioButton_zarezerv_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView_guests.Rows.Clear();
            string connectString = "server = localhost; port = 3306; username = root; password = root; database = hotel";

            MySqlConnection connection = new MySqlConnection(connectString);

            connection.Open();

            string query = "SELECT * FROM guests WHERE id IN (1, 2, 3)";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
            }
            reader.Close();

            connection.Close();
            foreach (string[] s in data)
                DataGridView_guests.Rows.Add(s);
                
                
            
        }

        private void radioButton_svobodni_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView_guests.Rows.Clear();
            string connectString = "server = localhost; port = 3306; username = root; password = root; database = hotel";

            MySqlConnection connection = new MySqlConnection(connectString);

            connection.Open();

            string query = "SELECT * FROM guests WHERE status = 'Свободные'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
            }
            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                DataGridView_guests.Rows.Add(s);
        }

        private void radioButton_zanyat_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView_guests.Rows.Clear();
            string connectString = "server = localhost; port = 3306; username = root; password = root; database = hotel";

            MySqlConnection connection = new MySqlConnection(connectString);

            connection.Open();

            string query = "SELECT * FROM guests WHERE status = 'Заняты'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
            }
            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                DataGridView_guests.Rows.Add(s);
        }

        private void radioButton_vipiska_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView_guests.Rows.Clear();

            string connectString = "server = localhost; port = 3306; username = root; password = root; database = hotel";
            MySqlConnection connection = new MySqlConnection(connectString);
            connection.Open();
            string query = "SELECT * FROM guests WHERE status = 'Выписываются'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
            }
            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                DataGridView_guests.Rows.Add(s);
        }

        private void textBox_search_Click(object sender, EventArgs e)
        {

        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestCardForm guestCardForm = new GuestCardForm();
            guestCardForm.Show();
        }
    }
}
