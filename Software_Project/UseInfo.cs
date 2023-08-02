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
    public partial class UseInfo : Form
    {
        User user;
        public UseInfo(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UseInfo_Load(object sender, EventArgs e)
        {
            Name.Text = user.Name;
            Email.Text = user.email;
            Password.Text = user.password;
            phone.Text = user.phone.ToString();
            Age.Text = user.age.ToString();
            if (user.gender == 'M')
                Male.Checked = true;
            else
                Female.Checked = true;
        }

        private void UseInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_butt_Click(object sender, EventArgs e)
        {
            if (user.type.Equals("Customer"))
            {
                HomePage home = new HomePage(user);
                home.Show();
            }
            else 
            {
                AuthorPage author = new AuthorPage(user);
                author.Show();
            }
            this.Hide();
        }
    }
}
