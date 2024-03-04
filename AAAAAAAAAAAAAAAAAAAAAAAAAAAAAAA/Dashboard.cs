using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;


namespace AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void buttondashboard_Click(object sender, EventArgs e)
        {
            loadform(new Sidebar_dashboard());
        }

        private void buttonappointment_Click(object sender, EventArgs e)
        {
            loadform(new Sidebar_appointment());
        }

        private void buttoncalendaar_Click(object sender, EventArgs e)
        {
            loadform(new Sidebar_calendar());

        }

        private void buttonsched_Click(object sender, EventArgs e)
        {
            loadform(new Sidebar_sched());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 lForm = new Form1();
                lForm.Show();
                this.Hide();
            }
        }
    }
}
