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
    public partial class PurchaseForm : Form
    {
        public bool isCancel = true;
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shop_dbDataSet.invoices_products' table. You can move, or remove it, as needed.
            invoicesTableAdapter1.FillBy3(shop_dbDataSet.invoices);
            lblInvoiceId.Text = shop_dbDataSet.invoices.Rows[0]["ID"].ToString();
            lbldate.Text = shop_dbDataSet.invoices.Rows[0]["order_date"].ToString();
            lblphone.Text = shop_dbDataSet.invoices.Rows[0]["costumer_phone"].ToString();

            costumersTableAdapter1.FillBy4(shop_dbDataSet.costumers, lblphone.Text);
            lblCostumerName.Text = shop_dbDataSet.costumers[0]["first_name"].ToString();
            lblFamily.Text = shop_dbDataSet.costumers[0]["last_name"].ToString();
            lblEmail.Text = shop_dbDataSet.costumers[0]["email"].ToString();
            invoices_productsTableAdapter.FillBy(shop_dbDataSet.invoices_products, long.Parse(lblInvoiceId.Text));
        }

        private void button3_Click(object sender, EventArgs e)
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

        
        private void submitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THE ORDER WAS SUCCESSFULLY ERGISTERED", "SUSSESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblpayble.Text = sum.ToString();
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

       

    }
}
