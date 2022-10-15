using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meelo_Browser
{
    public partial class HistoryControl : UserControl
    {
        //connection to the database
        //MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\CEDDYY\source\repos\Meelo Browser\Meelo Browser\bin\Debug\meeloHistory.accdb;
                                                        Persist Security Info =false");
        public HistoryControl()
        {
            InitializeComponent();
        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            //load the the base when the history is click
            loadDatabase();
        }

        //function to retrieve the history from the database
        public void loadDatabase()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Searches FROM history";
                command.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                guna2DataGridView1.Rows.Clear();

                foreach (DataRow items in dataTable.Rows)
                {
                    int n = guna2DataGridView1.Rows.Add();
                    //guna2DataGridView1.Rows[n].Cells[0].Value = "false";

                    guna2DataGridView1.Rows[n].Cells[1].Value = items["Searches"].ToString();

                    if (guna2DataGridView1.Rows[n].Cells[1].Value.ToString().ToLower().Contains("pornhub"))
                    {
                       
                        guna2DataGridView1.Rows[n].Cells[1].Style.BackColor = Color.Crimson;
                    }

                }

                connection.Close();
            }
            catch (Exception)
            {

            }

        }

        public bool checkEmpty()
        {
            bool listEmpty = false;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "SELECT Searches FROM history";
                command.CommandText = query;
                connection.Close();
            }
            catch (Exception)
            {

            }
            return listEmpty;
        }
        

        //clear all the data from the database
        public void clearHistory()
        {
            string message = $"Are you sure want to delete all history?";
            if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM history";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = deleteQuery;
                command.ExecuteNonQuery();
                connection.Close();
                loadDatabase();
            }
        }
        public bool TopLevel { get; internal set; }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                loadDatabase();

            }
            else
            {
                string message = $"Database is Empty!";
                MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // using checkbox to delete the data from the database and refreshing the database without the deleted data
            int total = guna2DataGridView1.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["CheckBox"].Value) == true).Count();

            if (total > 0)
            {
                string message = $"Are you sure want to delete {total} row?";
                if (total > 1)
                    message = $"Are you sure want to delete {total} rows?";
                if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = guna2DataGridView1.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = guna2DataGridView1.Rows[i];
                        if (Convert.ToBoolean(row.Cells["CheckBox"].Value) == true)
                        {
                            OleDbCommand command = new OleDbCommand();
                            
                            
                            string deleteQuery = "DELETE FROM history WHERE `Searches`= ('" + row.Cells[1].ToString() + "')";
                            connection.Open();
                            command.Connection = connection;
                            command.CommandText = deleteQuery;
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Successfully Deleted");
                    loadDatabase();
                    
                }
                else if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {

                }  
            }
            else {
                MessageBox.Show("No Selection! Please Check the row you want to delete. ");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                clearHistory();

            }
            else
            {
                string message = $"Database is Empty!";
                MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
