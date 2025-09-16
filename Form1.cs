using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

//       DESKTOP-27DTS7O\SQLEXPRESS

namespace MyCRUD
{
    public partial class Form1 : Form
    {
        private SqlConnection _connection;
        public Form1()
        {
            InitializeComponent();
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCRUD.Properties.Settings.ConnectionString"].ConnectionString);
            _connection.Open();
            LoadData();
        }
        private void LoadData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM PASAZER", _connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("INSERT INTO PASAZER (ID, IMIE, NAZWISKO, N_WAGON, N_MIEJSCA, M_STARTIMIE, M_KONCAIMIE, KOSZT_BILETU) VALUES (@ID, @IMIE, @NAZWISKO, @N_WAGON, @N_MIEJSCA, @M_STARTIMIE, @M_KONCAIMIE, @KOSZT_BILETU)", _connection);

            Random random = new Random();
            int myid = random.Next(1, 10000001);

            command1.Parameters.AddWithValue("@ID", myid);
            command1.Parameters.AddWithValue("@IMIE", tx_imie.Text);
            command1.Parameters.AddWithValue("@NAZWISKO", tx_nazwisko.Text);
            command1.Parameters.AddWithValue("@N_WAGON", tx_wagon.Text);
            command1.Parameters.AddWithValue("@N_MIEJSCA", tx_miejsce.Text);
            command1.Parameters.AddWithValue("@M_STARTIMIE", tx_start.Text);
            command1.Parameters.AddWithValue("@M_KONCAIMIE", tx_koniec.Text);
            command1.Parameters.AddWithValue("@KOSZT_BILETU", tx_koszt.Text);
            command1.ExecuteNonQuery();
            LoadData();
            SqlCommand command2 = new SqlCommand("INSERT INTO POCIAG (ID, NAZWA_POCIAG ) VALUES (@ID, @NAZWA_POCIAG )", _connection);
            Random random1 = new Random();
            int myid1 = random1.Next(1, 10000001);
            command2.Parameters.AddWithValue("@ID", myid1);
            command2.Parameters.AddWithValue("@NAZWA_POCIAG", tx_pociag.Text);
            command2.ExecuteNonQuery();
            LoadData();
        }

        private void zmien_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("UPDATE PASAZER SET IMIE = @IMIE, NAZWISKO = @NAZWISKO, N_WAGON = @N_WAGON, N_MIEJSCA = @N_MIEJSCA, M_STARTIMIE = @M_STARTIMIE, M_KONCAIMIE = @M_KONCAIMIE, KOSZT_BILETU = @KOSZT_BILETU WHERE Id = @Id", _connection);

            int.TryParse(tx_id.Text, out int id1);

            command1.Parameters.AddWithValue("@ID", id1);
            command1.Parameters.AddWithValue("@IMIE", tx_imie.Text);
            command1.Parameters.AddWithValue("@NAZWISKO", tx_nazwisko.Text);
            command1.Parameters.AddWithValue("@N_WAGON", tx_wagon.Text);
            command1.Parameters.AddWithValue("@N_MIEJSCA", tx_miejsce.Text);
            command1.Parameters.AddWithValue("@M_STARTIMIE", tx_start.Text);
            command1.Parameters.AddWithValue("@M_KONCAIMIE", tx_koniec.Text);
            command1.Parameters.AddWithValue("@KOSZT_BILETU", tx_koszt.Text);

            command1.ExecuteNonQuery();

            LoadData();

        }

        private void usun_Click(object sender, EventArgs e)
        {

            SqlCommand command1 = new SqlCommand("DELETE FROM PASAZER WHERE Id = @Id", _connection);

            int.TryParse(tx_id.Text, out int id1);

            command1.Parameters.AddWithValue("@ID", id1);

            command1.ExecuteNonQuery();

            LoadData();

        }
        private void tx_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            string imie = tx_imie.Text;
            string nazwisko = tx_nazwisko.Text;

            string query = "SELECT ID, IMIE, NAZWISKO, N_WAGON, N_MIEJSCA, M_STARTIMIE, M_KONCAIMIE, KOSZT_BILETU FROM PASAZER WHERE IMIE = @IMIE AND NAZWISKO = @NAZWISKO";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@IMIE", imie);
            command.Parameters.AddWithValue("@NAZWISKO", nazwisko);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Nie znaleziono pasa¿era o podanym imieniu i nazwisku.", "B³¹d wyszukiwania", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

}
