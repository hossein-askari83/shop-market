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
    public partial class update_purchaseFoem : Form
    {
        public update_purchaseFoem()
        {
            InitializeComponent();
        }

        private void update_purchaseFoem_Load(object sender, EventArgs e)
        {
            update_invoice_form update_form = new update_invoice_form();
            update_form.ShowDialog();
            if (update_form.isCancel == false)
            {
                try
                {

                    invoicesTableAdapter1.UpdateQuery(update_form.newCostumerPhone, update_form.newOrderDate, update_form.witchivoice);
                    invoicesTableAdapter1.FillBy4(shop_dbDataSet.invoices, update_form.witchivoice);
                    lblInvoiceId.Text = shop_dbDataSet.invoices.Rows[0]["ID"].ToString();
                    lbldate.Text = shop_dbDataSet.invoices.Rows[0]["order_date"].ToString();
                    lblphone.Text = shop_dbDataSet.invoices.Rows[0]["costumer_phone"].ToString();

                    costumersTableAdapter1.FillBy4(shop_dbDataSet.costumers, lblphone.Text);
                    lblCostumerName.Text = shop_dbDataSet.costumers[0]["first_name"].ToString();
                    lblFamily.Text = shop_dbDataSet.costumers[0]["last_name"].ToString();
                    lblEmail.Text = shop_dbDataSet.costumers[0]["email"].ToString();
                    invoices_productsTableAdapter.FillBy(shop_dbDataSet.invoices_products, long.Parse(lblInvoiceId.Text));
                }
                catch
                { MessageBox.Show("SOMETHING WENT WRONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
                this.Close();
            
            }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            if (txtFGoodsCode.Text != "")
            {
                productsTableAdapter.FillBy6(shop_dbDataSet.products, long.Parse(txtFGoodsCode.Text));
                if (shop_dbDataSet.products.Rows.Count > 0)
                {
                    lblProductName.Text = shop_dbDataSet.products.Rows[0]["name"].ToString();
                    lblPrice.Text = shop_dbDataSet.products.Rows[0]["prise"].ToString();
                    lblColor.Text = shop_dbDataSet.products.Rows[0]["color"].ToString();
                    lblYear.Text = shop_dbDataSet.products.Rows[0]["year of construction"].ToString();
                }
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblpayble.Text = sum.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (lblProductName.Text != "" && txtFAmount.Text != "")
            {
                int total_price = int.Parse(txtFAmount.Text) * int.Parse(lblPrice.Text);
                invoices_productsTableAdapter.InsertQuery(long.Parse(lblInvoiceId.Text), long.Parse(txtFGoodsCode.Text), lblProductName.Text, txtFAmount.Text, lblPrice.Text, total_price.ToString());
                invoices_productsTableAdapter.FillBy(shop_dbDataSet.invoices_products, long.Parse(lblInvoiceId.Text));
            }
            else
                MessageBox.Show("PLEASE SELECT PRODUCT ID AND NUMBER OF IT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("THE ORDER WAS SUCCESSFULLY UPDATED", "SUSSESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                long productid = long.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                long invoiceid = long.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                invoices_productsTableAdapter.DeleteQuery(invoiceid, productid);
                invoices_productsTableAdapter.FillBy(shop_dbDataSet.invoices_products, long.Parse(lblInvoiceId.Text));
            }
        }

        private void dataGridView1_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblpayble.Text = sum.ToString();
        }

        private void dataGridView1_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblpayble.Text = sum.ToString();
        }
    }
}


