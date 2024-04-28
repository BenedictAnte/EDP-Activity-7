using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class Selection : Form
    {
        private const string connectionString = "server=127.0.0.1;database=ante;uid=root;pwd=Bdic12345#;";
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Selection()
        {
            InitializeComponent();
            adapter = new MySqlDataAdapter("SELECT * FROM user_authentication", connectionString);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add new account to the database
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            AddAccount(username, password);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddAccount(string username, string password)
        {


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO user_authentication (username, password) VALUES (@username, @password)", conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Account added successfully.", "Account Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshDataGridView();
        }

        private void UpdateAccount(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE user_authentication SET password = @password WHERE username = @username", conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Account updated successfully.", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No account found with the provided username.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            AddAccount(username, password);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Update existing account in the database
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            UpdateAccount(username, password);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=ante;uid=root;pwd=Bdic12345#;";
            string query = "SELECT ID, username, Status FROM user_authentication WHERE username = @username";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Replace 'textBox3.Text' with the actual name of your TextBox control
                    cmd.Parameters.AddWithValue("@username", textBox3.Text);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming 'dataGridView' is the name of your DataGridView control
                        dataGridView1.DataSource = dataTable;

                        // Hide all columns except for ID, username, and Status
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            if (column.Name != "ID" && column.Name != "username" && column.Name != "Status")
                            {
                                column.Visible = false;
                            }
                        }
                    }
                }
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

