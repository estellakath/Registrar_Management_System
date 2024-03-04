using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kathleen\OneDrive\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            Form2 sForm = new Form2();
            sForm.Show();
            this.Hide();
        }

        private void loginexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (loginshowpass.Checked)
            {
                txtloginpass.PasswordChar = '\0';
            }
            else
            {
                txtloginpass.PasswordChar = '*';
            }
        }

        private void buttonloginacc_Click(object sender, EventArgs e)
        {
            if (txtloginusername.Text == "" || txtloginpass.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND passwrd = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txtloginusername.Text);
                            cmd.Parameters.AddWithValue("@pass", txtloginpass.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Dashboard mForm = new Dashboard();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}

        
    

