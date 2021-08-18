using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace shop_database
{
    public partial class costumer_update_form : Form
    {
        public string newFirstName , newLastName , newPhone , newEmail;
        public string witchCostumer;
        public bool isCancel = true;

        public costumer_update_form()
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
                bool isint = false;
                try 
                {
                    int isPhoneInt = int.Parse(newPhone);
                    isint = true;
                }
                catch { MessageBox.Show("ENTER A NUMBER IN PHONE INPUT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                newEmail = textBox4.Text;
                if (isint == true)
                {
                    isCancel = false;
                    this.Close();
                    witchCostumer = Interaction.InputBox("Which customer do you want to update?\n(WRITE COSTUMER PHONE) : ", "update costumer", "WRITE COSTUMER PHONE");
                }
               
            }
            else
                MessageBox.Show("SOME FILDES ARE BLANK PLEASE FILL THEM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
     }
}

