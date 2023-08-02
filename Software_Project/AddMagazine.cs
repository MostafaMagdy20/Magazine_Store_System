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
    public partial class AddMagazine : Form
    {
        User user;
        string ordb = "Data source=orcl;User Id=scott;" + "Password=tiger;";
        OracleConnection conn;
        public AddMagazine(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void AddMagazine_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "INSERT into Magazines " +
                "values(:magazinename,:authorname,:AuthorID,:content,:price)";
            comm.Parameters.Add("magazinename", Name.Text);
            comm.Parameters.Add("authorname", user.Name);
            comm.Parameters.Add("AuthorID", user.user_id);
            comm.Parameters.Add("content", content.Text);
            comm.Parameters.Add("price",float.Parse(price.Text));
            bool valid = true;
            try
            {
                int r = comm.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                valid = false;
                if (exc.Message.Contains("unique"))
                {
                    MessageBox.Show("the name is copyrighted");
                }
                else if (exc.Message.Contains("NULL"))
                {
                    MessageBox.Show("please fill all the data");
                }
                else
                {
                    MessageBox.Show(exc.Message);
                }
            }
            if (valid)
            {
                this.Hide();
                AuthorPage authorPage = new AuthorPage(user);
                authorPage.Show();
                return;
            }
        }

        private void AddMagazine_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
