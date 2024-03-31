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
    public partial class Admin_Dashboard : Form
    {
        private SqlConnection conn;
        private usersEntities db;
        public Admin_Dashboard()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-I3H1TD1\\SQLEXPRESS02;Initial Catalog=users;Integrated Security=True");
            db = new usersEntities();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsusernameExists(txtUsername.Text))
                {
                    MessageBox.Show("Account already exists. Please choose another user", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                if (txtPassword.Text == null || txtUsername.Text == null || cbType.SelectedItem == null)
                {
                    MessageBox.Show("Please fill out the fields", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (SqlCommand com = new SqlCommand("USERS", conn))
                    {
                        conn.Open();
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@userName", txtUsername.Text);
                        com.Parameters.AddWithValue("@userPassword", txtPassword.Text);
                        com.Parameters.AddWithValue("@UserType", cbType.SelectedItem.ToString());
                        com.ExecuteNonQuery();
                        loadusers();
                    }
                    MessageBox.Show("Selected rows created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuserId.Clear();
                }

            }
            catch (SqlException ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool IsusernameExists(string text)
        {
            using (SqlCommand checkUsername = new SqlCommand("SELECT COUNT(*) FROM UserAccount WHERE userName = @username", conn))
            {
                conn.Open();
                checkUsername.Parameters.AddWithValue("@username", txtUsername.Text);
                int count = (int)checkUsername.ExecuteScalar();
                return count > 0;
            }
        }

        private void loadusers()
        {
            using (db = new usersEntities())
            {
                var load = db.ViewUsers.ToList();
                tableAdmin.DataSource = load;
            }
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            loadusers();
            cbType.Items.Clear();
            cbType.Items.Add("Customer");
            cbType.Items.Add("Admin");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == null || txtUsername.Text == null || cbType.SelectedItem == null)
            {
                MessageBox.Show("Please fill out the fields", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (conn.State == ConnectionState.Open) { conn.Close(); }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to update selected rows?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateUsers", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@userId", txtuserId.Text);
                        cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                    }
                    loadusers();
                    MessageBox.Show("Selected rows updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == null || txtUsername.Text == null || cbType.SelectedItem == null)
            {
                MessageBox.Show("Please fill out the fields", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (conn.State == ConnectionState.Open) { conn.Close(); }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove selected rows?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlCommand com = new SqlCommand("deleteusers", conn))
                    {
                        conn.Open();
                        com.CommandType = CommandType.StoredProcedure;


                        com.Parameters.AddWithValue("@userId", txtuserId.Text);
                        com.Parameters.AddWithValue("@username", txtUsername.Text);
                        com.Parameters.AddWithValue("@userpassword", txtPassword.Text);
                        com.Parameters.AddWithValue("@UserType", cbType.SelectedItem.ToString());

                        com.ExecuteNonQuery();
                    }
                    loadusers();
                    MessageBox.Show("Selected rows removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuserId.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
            Login logs = new Login();
            logs.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (usersEntities db = new usersEntities())
            {
                string username = txtSearch.Text.Trim();
                this.tableAdmin.DataSource = db.ViewUsers.Where(x => x.username.Contains(username)).OrderBy(x => x.username).ToList();
            }
        }

        private void tableAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableAdmin.SelectedRows.Count > 0)
            {
                txtuserId.Text = tableAdmin.SelectedRows[0].Cells[0].Value.ToString();
                txtUsername.Text = tableAdmin.SelectedRows[0].Cells[1].Value.ToString();
                txtPassword.Text = tableAdmin.SelectedRows[0].Cells[2].Value.ToString();
                cbType.SelectedItem = tableAdmin.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void lblDeleteField_Click(object sender, EventArgs e)
        {
            txtuserId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
