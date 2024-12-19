using Core.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class Form1 : Form
    {
        private SqlDatabaseManager _dbManager;
        private PO_Manager _poManager;
        public Form1()
        {
            InitializeComponent();
            string serverName = ".";
            string databaseName = "Order";
            string userName = "sa";
            string password = "6825";
            _dbManager = new SqlDatabaseManager(serverName, databaseName, userName, password);
            _poManager = new PO_Manager(_dbManager, "AdminUser");
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void dgvPOData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtFilePath.Text;
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Please select an Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int month = Convert.ToInt32(txtMonth.Text);
                int year = Convert.ToInt32(txtYear.Text);
                int poType = Convert.ToInt32(txtPOType.Text);

                // Load data using PO_Manager
                var poDetails = _poManager.GetDetails(filePath, month, year, poType);

                // Bind data to the DataGridView
                dgvPOData.DataSource = poDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
