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
    public partial class update_invoice_form : Form
    {
        public string newCostumerPhone;
        public DateTime newOrderDate;
        public long witchivoice;
        public long witchinvoiceKeeper = 0;
        public bool isCancel = true;
        public update_invoice_form()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    newCostumerPhone= textBox1.Text;
                    bool isInt = false;
                    bool isexist = false;
                    try
                    {
                        long isPhoneInt = long.Parse(newCostumerPhone);
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
                            MessageBox.Show("THE COSTUMER PHONE IS NOT EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch { MessageBox.Show("ENTER A NUMBER IN PHONE INPUT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                    newOrderDate = DateTime.Parse(textBox2.Text);
                    if (isInt == true && isexist == true)
                    {
                        witchivoice = long.Parse(Interaction.InputBox("Which invoice do you want to update?\n(WRITE INVOICE ID) : ", "update invoice", "WRITE INVOICE ID"));
                        witchinvoiceKeeper = witchivoice;
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
