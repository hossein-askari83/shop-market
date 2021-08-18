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
    public partial class insert_invoice_form : Form
    {
        public DateTime order_date;
        public string phone;
        public bool isCancel = true;
        public insert_invoice_form()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    phone = textBox1.Text;
                    bool isInt = false;
                    bool isexist = false;
                    try 
                    { 
                        long isPhoneInt = long.Parse(phone);
                        isInt = true;
                        try
                        {
                            string isphoneexist = textBox1.Text;
                            costumersTableAdapter1.FillBy4(shop_dbDataSet1.costumers, isphoneexist);
                            string isnameexist = shop_dbDataSet1.costumers.Rows[0]["first_name"].ToString();
                            isexist = true;
                        }
                        catch
                        {
                            MessageBox.Show("THE COSTUMER PHONE IS NOT EXIST","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch { MessageBox.Show("ENTER A NUMBER IN PHONE INPUT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    order_date = DateTime.Parse(textBox2.Text);
                    if (isInt == true && isexist == true)
                    {
                        isCancel = false;
                        this.Close();
                    }
                }

                else
                    MessageBox.Show("SOME FILDES ARE BLANK PLEASE FILL THEM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { MessageBox.Show("ORDER DATE DATA TYPE IS NOT VALID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
        }
    }
}
