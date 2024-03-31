using PirateChan.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PirateChan
{
    public partial class Login : Form
    {
        private SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-I3H1TD1\\SQLEXPRESS02;Initial Catalog=users;Integrated Security=True");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == null)
            {
                MessageBox.Show("Enter the username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login();
            }
            else if (pwd_txt.Text == null)
            {
                MessageBox.Show("Enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from customer_table where username = @username and pwd = @pwd", conn);
                    cmd.Parameters.AddWithValue("username", username_txt.Text);
                    cmd.Parameters.AddWithValue("pwd", pwd_txt.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string userType = dt.Rows[0]["acctype"].ToString();

                        if (userType.Equals("Customer", StringComparison.OrdinalIgnoreCase))
                        {
                            var teacherDashboard = new CustomerLanding();
                            teacherDashboard.ShowDialog();
                        }
                        else if (userType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            var adminDashboard = new Admin_Dashboard();
                            adminDashboard.ShowDialog();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                        login();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Hide();
        }

        public void login() { 
            Login log = new Login();
            log.Show();
        }

        private void registerhere_btn1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        private void pwd_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        private void registerhere_btn2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
