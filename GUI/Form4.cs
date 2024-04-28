using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using System.IO;
using System.Transactions;


namespace GUI
{
    public partial class Form4 : Form
    {

        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;


        public Form4()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=127.0.0.1;database=ante;uid=root;pwd=Bdic12345#;";
            connection = new MySqlConnection(connectionString);
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the button has been clicked
            if (!button1Clicked)
            {
                // If the button hasn't been clicked, leave the dataGridView1 blank
                dataGridView1.DataSource = null;
                return;
            }
        }
        private bool button1Clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM borrow";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                // Set button1Clicked to true indicating that the button has been clicked
                button1Clicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the button has been clicked
            if (!button2Clicked)
            {
                // If the button hasn't been clicked, leave the dataGridView1 blank
                dataGridView2.DataSource = null;
                return;
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the button has been clicked
            if (!button3Clicked)
            {
                // If the button hasn't been clicked, leave the dataGridView1 blank
                dataGridView3.DataSource = null;
                return;
            }
        }

        private bool button3Clicked = false;


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM borrow";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView3.DataSource = dataTable;

                // Set button1Clicked to true indicating that the button has been clicked
                button3Clicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool button2Clicked = false;


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM transaction";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView2.DataSource = dataTable;

                // Set button1Clicked to true indicating that the button has been clicked
                button2Clicked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if there is data in the dataGridView1
                if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("There is no data to export.");
                    return;
                }

                // Specify the path to your template Excel file
                string templateFilePath = @"C:\Users\Benedict\Desktop\Activities and assignments\Assignement\EDP\GUI\template.xlsx";

                // Check if the template file exists
                if (!File.Exists(templateFilePath))
                {
                    MessageBox.Show("Template file not found.");
                    return;
                }

                // Specify the directory where the new file will be created
                string outputDirectory = @"C:\Users\Benedict\Desktop\Activities and assignments\Assignement\EDP\GUI\";
                string newFileName = "BORROWGAME_REPORT.XLSX";  // Change the name as needed 

                // Combine the output directory with the new file name
                string newFilePath = Path.Combine(outputDirectory, newFileName);

                // Copy the template file to the new location
                File.Copy(templateFilePath, newFilePath, true);

                // Open the copied template Excel file
                using (var wb = new XLWorkbook(newFilePath))
                {
                    // Get the first worksheet
                    var ws = wb.Worksheets.Worksheet(1);

                    // Export data from dataGridView1
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            // Explicitly convert the Value property to string
                            string cellValue = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";

                            // Assign the cell value to the Excel worksheet cell
                            ws.Cell(i + 2, j + 1).Value = cellValue;
                        }
                    }

                    // Save the workbook
                    wb.Save();

                    MessageBox.Show("Data exported successfully to: " + newFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if there is data in the dataGridView3
                if (dataGridView3.DataSource == null || dataGridView3.Rows.Count == 0)
                {
                    MessageBox.Show("There is no data to export.");
                    return;
                }

                // Specify the path to your template Excel file
                string templateFilePath = @"C:\Users\Benedict\Desktop\Activities and assignments\Assignement\EDP\GUI\template.xlsx";

                // Check if the template file exists
                if (!File.Exists(templateFilePath))
                {
                    MessageBox.Show("Template file not found.");
                    return;
                }

                // Specify the directory where the new file will be created
                string outputDirectory = @"C:\Users\Benedict\Desktop\Activities and assignments\Assignement\EDP\GUI\";
                string newFileName = "STOCKS REPORT.XLSX";  // Change the name as needed 

                // Combine the output directory with the new file name
                string newFilePath = Path.Combine(outputDirectory, newFileName);

                // Copy the template file to the new location
                File.Copy(templateFilePath, newFilePath, true);

                // Open the copied template Excel file
                using (var wb = new XLWorkbook(newFilePath))
                {
                    // Get the first worksheet
                    var ws = wb.Worksheets.Worksheet(1);

                    // Export data from dataGridView3
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView3.Columns.Count; j++)
                        {
                            // Explicitly convert the Value property to string
                            string cellValue = dataGridView3.Rows[i].Cells[j].Value?.ToString() ?? "";

                            // Assign the cell value to the Excel worksheet cell
                            ws.Cell(i + 2, j + 1).Value = cellValue;
                        }
                    }

                    // Save the workbook
                    wb.Save();

                    MessageBox.Show("Data exported successfully to: " + newFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Check if there is data in the dataGridView1
                if (dataGridView2.DataSource == null || dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("There is no data to export.");
                    return;
                }

                // Specify the path to your template Excel file
                string templateFilePath = @"C:\Users\Benedict\Desktop\Activities and assignments\Assignement\EDP\GUI\template.xlsx"; 

                // Check if the template file exists
                if (!File.Exists(templateFilePath))
                {
                    MessageBox.Show("Template file not found.");
                    return;
                }

                // Specify the directory where the new file will be created
                string outputDirectory = @"C:\Users\Benedict\Desktop\Activities and assignments\Assignement\EDP\GUI\";
                string newFileName = "TRANSACTION REPORT.XLSX";  // Change the name as needed  

                // Combine the output directory with the new file name
                string newFilePath = Path.Combine(outputDirectory, newFileName);

                // Copy the template file to the new location
                File.Copy(templateFilePath, newFilePath, true);

                // Open the copied template Excel file
                using (var wb = new XLWorkbook(newFilePath))
                {
                    // Get the first worksheet
                    var ws = wb.Worksheets.Worksheet(1);

                    // Export data from dataGridView1
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            // Explicitly convert the Value property to string
                            string cellValue = dataGridView2.Rows[i].Cells[j].Value?.ToString() ?? "";

                            // Assign the cell value to the Excel worksheet cell
                            ws.Cell(i + 2, j + 1).Value = cellValue;
                        }
                    }

                    // Save the workbook
                    wb.Save();

                    MessageBox.Show("Data exported successfully to: " + newFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}