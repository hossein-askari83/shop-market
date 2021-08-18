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
    public partial class Invoices_list_form : Form
    {
        public Invoices_list_form()
        {
            InitializeComponent();
        }

        private void Invoices_list_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shop_dbDataSet.invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);

        }

        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
            switch (search_by_combo_box.Text)
            {
                case "ID" :
                       if (search_text_box.Text != "")
                    {
                        try
                        {
                            invoicesTableAdapter.FillBy(shop_dbDataSet.invoices, long.Parse(search_text_box.Text));

                        }

                        catch
                        {
                        }
                           
                    }
                       else
                           this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);
                    break;

                case "COSTUMER PHONE":
                    if (search_text_box.Text != "")
                    {
                        try
                        {
                            invoicesTableAdapter.FillBy1(shop_dbDataSet.invoices, search_text_box.Text);

                        }

                        catch
                        {
                        }

                    }
                    else
                        this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);
                    break;
                case "ORDER_DATE":
                    if (search_text_box.Text != "")
                    {
                        try
                        {
                            invoicesTableAdapter.FillBy2(shop_dbDataSet.invoices, DateTime.Parse(search_text_box.Text));

                        }

                        catch
                        {
                        }

                    }
                    else
                        this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);

                    break;
                default:
                    {
                        if (search_text_box.Text != "")
                            MessageBox.Show("PLEASE SELECT A FILD NAME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        search_text_box.Text = "";
                        break;
                    }
            }
        }

        private void search_by_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_text_box.Text = "";
        }

        private void delete_invoices_btn_Click(object sender, EventArgs e)
        {
            string GetivoicetId = Interaction.InputBox("WRITE PRODUCT ID: ", "DELETE ROW", "PRODUCT ID");
            try
            {
                long productId = long.Parse(GetivoicetId);
                invoicesTableAdapter.DeleteQuery(productId);
                this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);
            }
            catch
            {
            }
        }
        public long s;
        private void update_invoices_btn_Click(object sender, EventArgs e)
        {
            {
           
                update_purchaseFoem update_puchaseFormInctanse = new update_purchaseFoem();
                update_puchaseFormInctanse.ShowDialog();
                this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);
            }
        }

        private void insert_invoices_btn_Click(object sender, EventArgs e)
        {
          
            insert_invoice_form insert_form = new insert_invoice_form();
            insert_form.ShowDialog();
            if (insert_form.isCancel != true)
            {
                try
                {
                    invoicesTableAdapter.InsertQuery(insert_form.phone, insert_form.order_date);
                    this.invoicesTableAdapter.Fill(this.shop_dbDataSet.invoices);
                    
                }
                catch
                { MessageBox.Show("SOMETHING WENT WRONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                PurchaseForm puchaseFormInctanse = new PurchaseForm();
                puchaseFormInctanse.ShowDialog();

                
            }
        }
    }
}

