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
    public partial class main_form : Form
    {
        
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {   
            login_form loginform = new login_form();
            loginform.ShowDialog();
            if (!loginform.succeeded)
                this.Close();
        }

        private void showcostumerslistbtn_Click(object sender, EventArgs e)
        {
            CostumersListForm costumerslistform_instansce = new CostumersListForm();
            costumerslistform_instansce.ShowDialog();
        }

        private void showproductslistbtn_Click(object sender, EventArgs e)
        {
            products_list_form productsListForm_instance = new products_list_form();
            productsListForm_instance.ShowDialog();
        }

        private void showinvoiceslistbtn_Click(object sender, EventArgs e)
        {
            Invoices_list_form invoicesListForm_inctance = new Invoices_list_form();
            invoicesListForm_inctance.ShowDialog();
        }

        private void showPurchaseform_Click(object sender, EventArgs e)
        {
            PurchaseForm Purchaseform = new PurchaseForm();
            Purchaseform.ShowDialog();
        }
        
    }
}
