using MySql.Data.MySqlClient;
using System.Data;

namespace SchoolApp
{
    public partial class Form1 : Form
    {
        int selectedId = 0;

        public Form1()
        {
            InitializeComponent();
            dgvData.CellClick += dgvData_CellClick;

            ShowData();
            ClearData();
        }

        private string Connection()
        {
            return "Server=localhost;database=pi_school;uid=root;pwd=;";
        }

        private void ShowData()
        {
            using (MySqlConnection connection = new MySqlConnection(Connection()))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id AS ID, visitor_name AS Nama, institution AS Institusi FROM visitors";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvData.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblName.Text) || string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(Connection()))
            {
                try
                {
                    conn.Open();
                    string queryInsert = "INSERT INTO visitors (visitor_name, institution) VALUES (@name, @institution)";

                    using (MySqlCommand command = new MySqlCommand(queryInsert, conn))
                    {
                        command.Parameters.AddWithValue("@name", textBoxName.Text);
                        command.Parameters.AddWithValue("@institution", txtInstitution.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Input data success!", "Input Notif", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ShowData();
                    ClearData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi gagal. Error: {ex.Message}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            textBoxName.Clear();
            txtInstitution.Clear();
            selectedId = 0;
            lblName.Focus();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["ID"].Value);

                textBoxName.Text = row.Cells["Nama"].Value.ToString();
                txtInstitution.Text = row.Cells["Institusi"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a record to edit!", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(txtInstitution.Text))
            {
                MessageBox.Show("Please fill all fields!", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(Connection()))
            {
                try
                {
                    conn.Open();
                    string queryUpdate = "Update visitors SET name = name,institution = where id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(queryUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("name", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@institution", txtInstitution.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update data success!", "Input Notif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Koneksi Gagal. Error: {ex.Message}");
                }
            }
        }
    }
}