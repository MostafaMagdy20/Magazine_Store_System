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
    public partial class AuthorPage : Form
    {
        User user;
        string ordb = "Data source=orcl;User Id=scott;" + "Password=tiger;";
        OracleConnection conn;
        public AuthorPage(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AddMagazine addMagazine = new AddMagazine(user);
            addMagazine.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "GETMAGAZINESBYAUTHID";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("Aid",user.user_id);
            comm.Parameters.Add("id",OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = comm.ExecuteReader();
            while (dr.Read()) 
            {
                if(!comboBox1.Items.Contains(dr[0].ToString()))
                        comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();

        }

        private void AuthorPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void report_butt_Click(object sender, EventArgs e)
        {
            Author_Report report = new Author_Report(user);
            report.Show();
            this.Hide();
        }

        private void AuthorPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userinfo_Click(object sender, EventArgs e)
        {
            UseInfo useInfo=new UseInfo(user);
            useInfo.Show();
            this.Hide();
        }
    }
}
