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
    public partial class Customer_Report : Form
    {
        CrystalReport2 cr2;
        User user;
        public Customer_Report(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Customer_Report_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport2();
            cr2.Refresh();
            cr2.SetParameterValue(0, user.user_id);
            crystalReportViewer1.ReportSource = cr2;
        }

        private void back_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(user);
            homePage.Show();
            this.Hide();
        }

        private void Customer_Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
