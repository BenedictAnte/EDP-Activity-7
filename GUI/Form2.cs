using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class ForgotPassword : Form
    {
        // Connection string to connect to the MySQL database
        private const string connectionString = "server=127.0.0.1;database=ante;uid=root;pwd=Bdic12345#;";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            // This method is called when the ForgotPassword form is loaded.
            // You can add any initialization code here if needed.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This method is called when the text in textBox1 is changed.
            // You can add any code here to handle the event if needed.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // This method is called when the pictureBox1 is clicked.
            // You can add any code here to handle the event if needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string newPassword = textBox2.Text;
            string retypePassword = textBox3.Text;

            // Check if the new password and retype password match
            if (newPassword == retypePassword)
            {
                // Update the password in the database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand("UPDATE user_authentication SET password = @password WHERE username = @username", conn))
                        {
                            cmd.Parameters.AddWithValue("@password", newPassword);
                            cmd.Parameters.AddWithValue("@username", username);

                            int result = cmd.ExecuteNonQuery();

                            // Check if the update was successful
                            if (result > 0)
                            {
                                MessageBox.Show("Password reset successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Password reset failed. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Handle any MySQL errors
                        MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Ensure the connection is closed
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The passwords do not match. Please retype your new password.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}





