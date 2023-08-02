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
    public partial class HomePage : Form
    {
        string ordb = "Data source=orcl;User Id=scott;" + "Password=tiger;";
        OracleConnection conn;
        public HomePage(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UseInfo useInfo = new UseInfo(user);
            useInfo.Show();
            this.Hide();
        }

        private void searchmagazine_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from magazines where  MagazineName like :magzinename";
            comm.Parameters.Add("magzinename", magName.Text);
            OracleDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                magazine_name.Text = dr[0].ToString();
            }
            else 
            {
                MessageBox.Show("nothing found");
                magazine_name.Text = "nothing found";
            }
            dr.Close();
            comm.Dispose();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void search_author_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "select * from magazines where  AuthorName like :authorname";
            comm.Parameters.Add("authorname", '%'+authorname.Text+'%');
            OracleDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add ( dr[0].ToString());
                magazine_name.Text = "select  item";
            }
            if (comboBox1.Items.Count==0)
            {
                MessageBox.Show("nothing found");
                magazine_name.Text = "nothing found";
            }
            dr.Close();
            comm.Dispose();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            magazine_name.Text = comboBox1.SelectedItem.ToString();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (magazine_name.Text.Equals("select  item") || magazine_name.Text.Equals("nothing found")
                || magazine_name.Text.Length==0) 
            {
                MessageBox.Show(" please select item \n 3lashan at5n2t mnhohm");
                return;
            }
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "INSERT into buys " +
                "values(:magazinename,:userid )";
            comm.Parameters.Add("magazinename",magazine_name.Text);
            comm.Parameters.Add("userid", user.user_id);
            bool valid = true;
            try
            {
                int r = comm.ExecuteNonQuery();
            }
            catch (Exception exce)
            {
                valid = false;
                MessageBox.Show(exce.Message);
            }
            if (valid) 
            {
                MessageBox.Show("congrataultion");
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            Customer_Report customer_Report = new Customer_Report(user);
            customer_Report.Show();
            this.Hide();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
