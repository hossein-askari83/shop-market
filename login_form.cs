using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_database
{
    public partial class login_form : Form
    {
        public bool succeeded = false;
        public login_form()
        {
            InitializeComponent();
            passwordtxtbox.PasswordChar = '*';
        }

        
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                adminstableTableAdapter.FillBy(adminsDataSet.adminstable, usernametxtbox.Text, passwordtxtbox.Text);
                if (adminsDataSet.adminstable.Rows.Count > 0)
                {
                    succeeded = true;
                    this.Close();
                }
                else
                    MessageBox.Show("useername or password is incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("something went wrong", "!", MessageBoxButtons.OK);
            }
        }


        private void login_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminsDataSet.adminstable' table. You can move, or remove it, as needed.
            this.adminstableTableAdapter.Fill(this.adminsDataSet.adminstable);
        }

        private void showpassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
                passwordtxtbox.PasswordChar = '\0';
            else
                passwordtxtbox.PasswordChar = '*';
        }

        
    }
}
