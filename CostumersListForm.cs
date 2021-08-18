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
    public partial class CostumersListForm : Form
    {
        public CostumersListForm()
        {
            InitializeComponent();
        }

        private void CostumersListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shop_dbDataSet.costumers' table. You can move, or remove it, as needed.
            this.costumersTableAdapter.Fill(this.shop_dbDataSet.costumers);
            

        }

        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
            
            switch (search_by_combo_box.Text)
            {
                case "NAME":
                    
                        costumersTableAdapter.FillBy(shop_dbDataSet.costumers, search_text_box.Text);
                        break;
                    
                case "FAMILY":
                    
                        costumersTableAdapter.FillBy1(shop_dbDataSet.costumers, search_text_box.Text);
                        break;
                    
                case "PHONE":
                    
                        costumersTableAdapter.FillBy2(shop_dbDataSet.costumers, search_text_box.Text);
                        break;
                    
                case "EMAIL":
                    
                        costumersTableAdapter.FillBy3(shop_dbDataSet.costumers, search_text_box.Text);
                        break;

                default:
                        {
                            if (search_text_box.Text != "")
                                MessageBox.Show("PLEASE SELECT A FILD NAME","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            search_text_box.Text = "";
                            break;
                        }
                
            }
        }

        private void search_by_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_text_box.Text = "";
        }

        private void delete_costumers_btn_Click(object sender, EventArgs e)
        {
            string GetCostumerPhone= Interaction.InputBox("WRITE COSTUMER PHONE : ", "DELETE ROW", "COSTUMER PHONE");
            costumersTableAdapter.DeleteQuery(GetCostumerPhone);
            this.costumersTableAdapter.Fill(this.shop_dbDataSet.costumers);
        }

        private void update_costumers_btn_Click(object sender, EventArgs e)
        {
            costumer_update_form update_form = new  costumer_update_form();
            update_form.ShowDialog();
            try
            {
                if (update_form.isCancel != true)
                {
                    costumersTableAdapter.UpdateQuery(update_form.newFirstName, update_form.newLastName, update_form.newPhone, update_form.newEmail, update_form.witchCostumer);
                    this.costumersTableAdapter.Fill(this.shop_dbDataSet.costumers);
                }
            }
            catch
            { MessageBox.Show("SOMETHING WENT WRONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void insert_costumers_btn_Click(object sender, EventArgs e)
        {
             costumer_insert_form insert_form = new  costumer_insert_form();
            insert_form.ShowDialog();
            try
            {
                if (insert_form.isCancel != true)
                {
                    costumersTableAdapter.InsertQuery(insert_form.newFirstName,insert_form.newLastName,insert_form.newPhone,insert_form.newEmail);
                    this.costumersTableAdapter.Fill(this.shop_dbDataSet.costumers);
                }
            }
            catch
            { MessageBox.Show("SOMETHING WENT WRONG", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        
      

       
    }
}

