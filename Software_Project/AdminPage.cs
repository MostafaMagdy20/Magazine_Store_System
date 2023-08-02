using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Software_Project
{
    public partial class AdminPage : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet dataSet;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {
            string ordb = "Data source=orcl;User Id=scott;" + "Password=tiger;";
            string cmdstr = "";
            if (Male.Checked)
                cmdstr = "select * from users where gender='M'";
            else if (Female.Checked)
                cmdstr = "select * from users where gender='F'";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            save.Enabled = true;

        }

        private void save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(dataSet.Tables[0]);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                while (dataGridView1.SelectedRows.Count > 0)
                       dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else {
                MessageBox.Show("please select a row");
            }
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
