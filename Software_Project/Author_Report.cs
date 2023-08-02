using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class Author_Report : Form
    {
        CrystalReport1 cr1;
        User user;
        public Author_Report(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Author_Report_Load(object sender, EventArgs e)
        {
            cr1 = new CrystalReport1();
            cr1.Refresh();
            cr1.SetParameterValue(0, user.user_id);
            crystalReportViewer1.ReportSource = cr1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            AuthorPage authorPage = new AuthorPage(user);
            authorPage.Show();
            this.Hide();
        }

        private void Author_Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
