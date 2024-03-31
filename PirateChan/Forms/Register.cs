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
using System.Security.Cryptography;


namespace PirateChan
{
    public partial class Register : Form
    {
        private SqlConnection conn;
        private bool isPasswordVisible = false;
        public Register()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-I3H1TD1\\SQLEXPRESS02;Initial Catalog=users;Integrated Security=True");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cbacctype.Items.Add("Customer");
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }


        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check for password mismatch
                if (pwd_txt.Text != cfpwd_txt.Text)
                {
                    pwd_txt.BackColor = Color.Red;
                    cfpwd_txt.BackColor = Color.Red;

                    MessageBox.Show("Passwords do not match. Please enter matching passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    pwd_txt.BackColor = SystemColors.Window;
                    cfpwd_txt.BackColor = SystemColors.Window;
                }

                // Check for valid email format
                if (!IsValidEmail(email_txt.Text))
                {
                    email_txt.BackColor = Color.Red;
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    email_txt.BackColor = SystemColors.Window;
                }

                if (IsusernameExists(username_txt.Text))
                {
                    MessageBox.Show("Account already exists. Please choose a different user.", "INFORMATION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string hashedPassword = HashPassword(pwd_txt.Text); // Hash the password

                string acctype = cbacctype.SelectedItem?.ToString() ?? ""; // Get selected item or empty string if null

                using (SqlCommand com = new SqlCommand("user_acc", conn))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@username", username_txt.Text);
                    com.Parameters.AddWithValue("@email", email_txt.Text);
                    com.Parameters.AddWithValue("@pwd", hashedPassword); // Store hashed password
                    com.Parameters.AddWithValue("@acctype", acctype); // Use acctype variable

                    com.ExecuteNonQuery();
                    MessageBox.Show("Congratulations! You have successfully created your Account!", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void loginhere_btn1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void loginhere_btn2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private bool IsusernameExists(string text)
        {
            using (SqlCommand checkusername = new SqlCommand("SELECT COUNT(*) FROM customer_table Where username = @username", conn))
            {
                conn.Open();
                checkusername.Parameters.AddWithValue("@username", text);
                int count = (int)checkusername.ExecuteScalar();
                return count > 0;
            }
        }

        private void cfpwd_txt_TextChanged(object sender, EventArgs e)
        {
            pwd_txt.BackColor = SystemColors.Window;
            cfpwd_txt.BackColor = SystemColors.Window;
        }

        private void pwd_txt_TextChanged(object sender, EventArgs e)
        {
            pwd_txt.BackColor = SystemColors.Window;
            cfpwd_txt.BackColor = SystemColors.Window;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {
            email_txt.BackColor = SystemColors.Window;
        }

        private void seepass_btn_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible)
            {
                pwd_txt.PasswordChar = '\0'; // Show password characters
                hidepass_btn.Visible = true;
                seepass_btn.Visible = false;
                isPasswordVisible = true;
            }
        }

        private void hidepass_btn_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible)
            {
                pwd_txt.PasswordChar = '\0'; // Show password characters
                hidepass_btn.Visible = true;
                seepass_btn.Visible = false;
                isPasswordVisible = true;
            }
        }

        private void seecfpass_btn_Click(object sender, EventArgs e)
        {
            if (!isPasswordVisible)
            {
                cfpwd_txt.PasswordChar = '\0'; // Show password characters
                hidecfpass_btn.Visible = true;
                seecfpass_btn.Visible = false;
                isPasswordVisible = true;
            }
        }

        private void hidecfpass_btn_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                cfpwd_txt.PasswordChar = '*'; // Hide password characters
                hidecfpass_btn.Visible = false;
                seecfpass_btn.Visible = true;
                isPasswordVisible = false;
            }
        }

        private void seepass_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isPasswordVisible)
            {
                pwd_txt.PasswordChar = '\0'; // Show password characters
                hidepass_btn.Visible = true;
                seepass_btn.Visible = false;
                isPasswordVisible = true;
            }
        }

        private void hidepass_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPasswordVisible)
            {
                pwd_txt.PasswordChar = '*'; // Hide password characters
                hidepass_btn.Visible = false;
                seepass_btn.Visible = true;
                isPasswordVisible = false;
            }
        }

        private void seecfpass_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isPasswordVisible)
            {
                cfpwd_txt.PasswordChar = '\0'; // Show password characters
                hidecfpass_btn.Visible = true;
                seecfpass_btn.Visible = false;
                isPasswordVisible = true;
            }
        }

       

        private void hidecfpass_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPasswordVisible)
            {
                cfpwd_txt.PasswordChar = '*'; // Hide password characters
                hidecfpass_btn.Visible = false;
                seecfpass_btn.Visible = true;
                isPasswordVisible = false;
            }
        }
    }
}
