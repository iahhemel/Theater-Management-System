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

namespace Theater_Management
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Resize += FormLogin_Resize;
        }
        private void FormLogin_Resize(object sender, EventArgs e)
        {
            this.panel1.Left = (this.ClientSize.Width - this.panel1.Width) / 2;
            this.panel1.Top = (this.ClientSize.Height - this.panel1.Height) / 2;
        }

        private void showpasschk_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkshowpass.Checked == true)
            {
                this.txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtpass.UseSystemPasswordChar = true;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.txtid.Clear();
            this.txtpass.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin_Resize(this, EventArgs.Empty);
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        } 

        // Login 
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string id = this.txtid.Text.Trim();
            string pass = this.txtpass.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both ID and Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.btnlogin.Enabled = false;
            try
            {
                using (DataAccess da = new DataAccess())
                {
                    string sql = "SELECT Id, Name, Password, Role FROM dbo.Users WHERE Id = @Id;";
                    DataTable dt = da.ExecuteQueryTable(sql, new SqlParameter("@Id", id));

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No account found with that ID. Please sign up first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow row = dt.Rows[0];
                    string storedPassword = row["Password"].ToString();

                    if (!string.Equals(storedPassword, pass, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string name = row["Name"].ToString();
                    string role = row["Role"].ToString();

                    Form nextForm;
                    if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase))
                        nextForm = new FormAdminDashboard(id, name);
                    else
                        nextForm = new FormUser(id, name);

                    nextForm.FormClosed += (s, args) =>
                    {
                        this.txtpass.Clear();
                        this.Show();
                    };

                    this.Hide();
                    nextForm.Show();
                }
            }
            catch (SqlException sqlExc)
            {
                MessageBox.Show("Could not connect to the database.\n" + sqlExc.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.btnlogin.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlelbl_Click(object sender, EventArgs e)
        {

        } 
    }
}