using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Software_Project
{
    public partial class Login : Form
    {
        string ordb = "Data source=orcl;User Id=scott;" + "Password=tiger;";
        OracleConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //usernameTextBox
            //passwordTextBox
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //go to register form
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        //create or replace PROCEDURE getuserbyemail(uremail in varchar2 , urpassword in varchar2,
        //urname out VARCHAR2,urphone out NUMBER,urgender out VARCHAR2,urage out NUMBER)

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (UserName.Text.Equals("admin") && Password.Text.Equals("admin")) 
            {
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                this.Hide();
                return;
            }
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "getuserbyemail";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("uremail", UserName.Text);
            comm.Parameters.Add("urpassword", Password.Text);
            comm.Parameters.Add("urid", OracleDbType.Int32, ParameterDirection.Output);
            comm.Parameters.Add("urname", OracleDbType.Varchar2,100).Direction = ParameterDirection.Output;
            comm.Parameters.Add("urphone", OracleDbType.Int32, ParameterDirection.Output);
            comm.Parameters.Add("urgender", OracleDbType.Varchar2,3).Direction= ParameterDirection.Output;
            comm.Parameters.Add("urage", OracleDbType.Int32, ParameterDirection.Output);
            comm.Parameters.Add("urtype", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            bool found = true;
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception exc) {
                if (exc.Message.Contains("no data found")) {
                    found = false;
                }
            }
            if (found) {
                User user = new User(int.Parse(comm.Parameters["urid"].Value.ToString()), comm.Parameters["urname"].Value.ToString()
                    , comm.Parameters["uremail"].Value.ToString(), comm.Parameters["urpassword"].Value.ToString(),
                   int.Parse(comm.Parameters["urphone"].Value.ToString()), comm.Parameters["urgender"].Value.ToString()[0]
                   , comm.Parameters["urtype"].Value.ToString(), int.Parse(comm.Parameters["urage"].Value.ToString()));
                comm.Dispose();
                conn.Dispose();
                if (user.type.Equals("Customer"))
                {
                    HomePage home = new HomePage(user);
                    home.Show();
                }
                else 
                {
                    AuthorPage authorPage = new AuthorPage(user);
                    authorPage.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid user email or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
