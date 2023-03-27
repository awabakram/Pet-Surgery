using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PetSurgery
{
    public partial class Form1 : Form
    {
        SqlConnection cnn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            openConnection();
            closeConnection();
            
        }

        private void openConnection()
        {
            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\awaba\Documents\School stuff\College\Computer Science\Programming\PetSurgery\PetDatabase.mdf';Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
        }

        private void closeConnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        private int nonQuery(string sql)
        {
            int recordsChanged = 0;
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sql, cnn);
                recordsChanged = command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Connection Not Open");
            }
            return recordsChanged;
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO Customer (Forename, Surname, TelephoneNumber) VALUES ('{txtbxForename.Text}', '{txtbxSurname.Text}', '{txtbxTelephoneNumber.Text}')";
            openConnection();
            nonQuery(sql);
            closeConnection();

            txtbxForename.Text = "";
            txtbxSurname.Text = "";
            txtbxTelephoneNumber.Text = "";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int count = 0;
            openConnection();

            StreamReader file = new StreamReader(@"C:\Users\awaba\Documents\School stuff\College\Computer Science\Programming\MOCK_DATA.CSV");
            string lineFromFile = file.ReadLine();

            while (lineFromFile != null)
            {
                lineFromFile = lineFromFile.Replace("'", "''");
                string[] fields = lineFromFile.Split(',');

                string sql = $"INSERT INTO Customer (Forename, Surname, TelephoneNumber) VALUES ('{fields[0]}', '{fields[1]}', '{fields[2]}')";
                nonQuery(sql);
                lineFromFile = file.ReadLine();

                count++;
                lblRecordsImported.Text = $"Records imported: {count}";

                Refresh();

            }

            file.Close();
            closeConnection();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Customer WHERE Forename = '{txtbxForename2.Text}' AND Surname = '{txtbxSurname2.Text}'";

            openConnection();
            lblRecordsDeleted.Text = "Records deleted: " + nonQuery(sql);
            closeConnection();

            txtbxForename2.Text = "";
            txtbxSurname2.Text = "";
        }

        private List<string> query(string sql)
        {
            List<string> queryResults = new List<string>();
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string record = "";
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            record += reader[i] + ",";
                        }
                        queryResults.Add(record.Substring(0, record.Length - 1));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Connection Not Open");
            }
            return queryResults;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            lstboxQueryResults.Items.Clear();
            string sql = txtbxSelect.Text;
            openConnection();
            List<string> queryResults = query(sql);
            closeConnection();
            lblResultCount.Text = "Result Count: " + queryResults.Count;
            foreach (string record in queryResults)
            {
                lstboxQueryResults.Items.Add(record);
            }
        }
    }
}
