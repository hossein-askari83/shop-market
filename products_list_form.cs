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
    public partial class products_list_form : Form
    {
        public products_list_form()
        {
            InitializeComponent();
        }

        private void products_list_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shop_dbDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
        }

        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
            switch (search_by_combo_box.Text)
            {
                case "ID":

                    if (search_text_box.Text != "")
                    {
                        try
                        {
                            productsTableAdapter.FillBy1(shop_dbDataSet.products, long.Parse(search_text_box.Text));
                        }
                        catch{}
                    }

                    else
                        this.productsTableAdapter.Fill(this.shop_dbDataSet.products);

                    break;

                case "CATEGORY":

                    if (search_text_box.Text != "")
                    {
                        try
                        {
                            productsTableAdapter.FillBy(shop_dbDataSet.products, long.Parse(search_text_box.Text));

                        }

                        catch
                        {
                        }
                    }
                    else
                        this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
                    break;

                case "NAME":

                    try
                    {
                        productsTableAdapter.FillBy2(shop_dbDataSet.products, search_text_box.Text);
                       
                    }

                    catch
                    {
                    }
                    break;

                case "PRICE":

                    if (search_text_box.Text != "")
                    {
                        try
                        {
                            productsTableAdapter.FillBy3(shop_dbDataSet.products, long.Parse(search_text_box.Text));

                        }

                        catch
                        {
                        }
                    }
                    else
                        this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
                    break;
                case "YEAR":

                    if (search_text_box.Text != "")
                    {
                        try
                        {
                            productsTableAdapter.FillBy4(shop_dbDataSet.products, long.Parse(search_text_box.Text));

                        }

                        catch
                        {
                        }
                    }
                    else
                        this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
                    break;

                case "COLOR":

                    try
                    {
                        productsTableAdapter.FillBy5(shop_dbDataSet.products,search_text_box.Text);
                       
                    }

                    catch
                    {
                    }
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

        private void delete_products_btn_Click(object sender, EventArgs e)
        {

            string GetproductId = Interaction.InputBox("WRITE PRODUCT ID: ", "DELETE ROW", "PRODUCT ID");
            try
            {
                long productId = long.Parse(GetproductId);
                productsTableAdapter.DeleteQuery(productId);
                this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
            }
            catch
            {
            }
        }
        private void update_products_btn_Click(object sender, EventArgs e)
        {
            update_product_form update_form = new update_product_form();
            update_form.ShowDialog();
            try
            {
                if (update_form.isCancel != true)
                {
                    productsTableAdapter.UpdateQuery(update_form.newCategory_id, update_form.newName, update_form.newPrice, update_form.newYear, update_form.newColor, update_form.witchproduct);
                    this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
                }
            }
            catch
            { MessageBox.Show("SOMETHING WENT WRONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void insert_products_btn_Click(object sender, EventArgs e)
        {
            insert_product_form insert_form = new insert_product_form();
            insert_form.ShowDialog();
            try
            {
                if (insert_form.isCancel != true)
                {
                    productsTableAdapter.InsertQuery(insert_form.newCategory_id, insert_form.newName, insert_form.newPrice, insert_form.newYear, insert_form.newColor);
                    this.productsTableAdapter.Fill(this.shop_dbDataSet.products);
                }
            }
            catch
            { MessageBox.Show("SOMETHING WENT WRONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
