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
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;" + "Password=tiger;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "INSERT into users " +
                "values(USERS_ID_seq.nextval,:name,:email,:password,:phone,:gender,:type,:age )";
            comm.Parameters.Add("name", Name.Text);
            comm.Parameters.Add("email", Email.Text);
            comm.Parameters.Add("password", Password.Text);
            comm.Parameters.Add("phone", phone.Text);
            if (Male.Checked)
            {
                comm.Parameters.Add("gender", "M");
            }
            else
            {
                comm.Parameters.Add("gender", "F");
            }
            string type = "";
            if (Customer.Checked)
            {
                comm.Parameters.Add("type", "Customer");
            }
            else
            {
                comm.Parameters.Add("type", "Author");
            }
            comm.Parameters.Add("age", Age.Text);
            bool valid=true;
            try
            {
                int r = comm.ExecuteNonQuery();

            }
            catch (Exception exc) {
                valid = false;
                if (exc.Message.Contains("unique"))
                {
                    MessageBox.Show("this email or this phone entered before");
                }
                else if (exc.Message.Contains("NULL"))
                {
                    MessageBox.Show("please fill all the data");
                }
                else {
                    MessageBox.Show(exc.Message);
                }
            }
            if (valid)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
                comm.Dispose();
                conn.Dispose();
                return;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
