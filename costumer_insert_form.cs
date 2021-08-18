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
    public partial class costumer_insert_form : Form
    {
        public string newFirstName, newLastName, newPhone, newEmail;
        public bool isCancel = true;
        public costumer_insert_form()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                newFirstName = textBox1.Text;
                newLastName = textBox2.Text;
                newPhone = textBox3.Text;
                bool isInt = false;
                try 
                { 
                    int isPhoneInt = int.Parse(newPhone);
                    isInt = true;
                }
                catch { MessageBox.Show("ENTER A NUMBER IN PHONE INPUT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                newEmail = textBox4.Text;
                if (isInt == true)
                {
                    isCancel = false;
                    this.Close();
                }
            }
            else
                MessageBox.Show("SOME FILDES ARE BLANK PLEASE FILL THEM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
