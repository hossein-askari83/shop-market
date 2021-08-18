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

namespace shop_database
{
    public partial class update_product_form : Form
    {
        public long newCategory_id, newPrice, newYear;
        public string newName, newColor;
        public long witchproduct;
        public bool isCancel = true;
        public update_product_form()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    newCategory_id = long.Parse(textBox1.Text);
                    newName = textBox2.Text;
                    newPrice = long.Parse(textBox3.Text);
                    newYear = long.Parse(textBox4.Text);
                    newColor = textBox5.Text;
                    isCancel = false;
                    this.Close();
                    witchproduct = long.Parse(Interaction.InputBox("Which product do you want to update?\n(WRITE PRODUCT ID) : ", "update product", "WRITE PRODUCT ID"));

                }

                else
                    MessageBox.Show("SOME FILDES ARE BLANK PLEASE FILL THEM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            { MessageBox.Show("SOME DATA TYPES IS NOT VALID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
