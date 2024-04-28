using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.DataFormats;

namespace GUI
{
    public partial class Login : Form
    {
        // Connection string to connect to the MySQL database
        private const string connectionString = "server=127.0.0.1;database=ante;uid=root;pwd=Bdic12345#;";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string enteredUsername = textBox2.Text.Trim();
            string enteredPassword = textBox3.Text;

            // Create a new MySqlConnection object using the connection string
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a MySqlCommand object to check the entered credentials
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM user_authentication WHERE username = @username AND password = @password", conn))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@username", enteredUsername);
                        cmd.Parameters.AddWithValue("@password", enteredPassword);

                        // Execute the command and get the number of users that match the credentials
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        // Check if a user was found
                        if (userCount > 0)
                        {
                            MessageBox.Show("Correct"); // Display "Correct" if login is successful
                            Selection form3 = new Selection();
                            form3.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect"); // Display "Incorrect" if login is unsuccessful
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                // selection

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            ForgotPassword form2 = new ForgotPassword();

            // Show Form2
            form2.Show();

            // Optionally, hide the current form (Login form)
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Instantiate Form4
            Form4 form4 = new Form4();

            // Show Form4
            form4.Show();
        }

        // ... Other methods ...
    }
}
    