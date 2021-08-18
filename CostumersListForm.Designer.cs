namespace shop_database
{
    partial class CostumersListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shop_dbDataSet = new shop_database.shop_dbDataSet();
            this.delete_costumers_btn = new System.Windows.Forms.Button();
            this.update_costumers_btn = new System.Windows.Forms.Button();
            this.insert_costumers_btn = new System.Windows.Forms.Button();
            this.costumersTableAdapter = new shop_database.shop_dbDataSetTableAdapters.costumersTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.search_by_combo_box = new System.Windows.Forms.ComboBox();
            this.search_text_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.costumersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costumersBindingSource
            // 
            this.costumersBindingSource.DataMember = "costumers";
            this.costumersBindingSource.DataSource = this.shopdbDataSetBindingSource;
            // 
            // shopdbDataSetBindingSource
            // 
            this.shopdbDataSetBindingSource.DataSource = this.shop_dbDataSet;
            this.shopdbDataSetBindingSource.Position = 0;
            // 
            // shop_dbDataSet
            // 
            this.shop_dbDataSet.DataSetName = "shop_dbDataSet";
            this.shop_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_costumers_btn
            // 
            this.delete_costumers_btn.BackColor = System.Drawing.Color.LightCoral;
            this.delete_costumers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_costumers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_costumers_btn.Location = new System.Drawing.Point(238, 541);
            this.delete_costumers_btn.Name = "delete_costumers_btn";
            this.delete_costumers_btn.Size = new System.Drawing.Size(135, 64);
            this.delete_costumers_btn.TabIndex = 9;
            this.delete_costumers_btn.Text = "DELETE";
            this.delete_costumers_btn.UseVisualStyleBackColor = false;
            this.delete_costumers_btn.Click += new System.EventHandler(this.delete_costumers_btn_Click);
            // 
            // update_costumers_btn
            // 
            this.update_costumers_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.update_costumers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_costumers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_costumers_btn.Location = new System.Drawing.Point(517, 541);
            this.update_costumers_btn.Name = "update_costumers_btn";
            this.update_costumers_btn.Size = new System.Drawing.Size(135, 64);
            this.update_costumers_btn.TabIndex = 9;
            this.update_costumers_btn.Text = "UPDATE";
            this.update_costumers_btn.UseVisualStyleBackColor = false;
            this.update_costumers_btn.Click += new System.EventHandler(this.update_costumers_btn_Click);
            // 
            // insert_costumers_btn
            // 
            this.insert_costumers_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.insert_costumers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_costumers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_costumers_btn.Location = new System.Drawing.Point(805, 541);
            this.insert_costumers_btn.Name = "insert_costumers_btn";
            this.insert_costumers_btn.Size = new System.Drawing.Size(135, 64);
            this.insert_costumers_btn.TabIndex = 9;
            this.insert_costumers_btn.Text = "INSERT";
            this.insert_costumers_btn.UseVisualStyleBackColor = false;
            this.insert_costumers_btn.Click += new System.EventHandler(this.insert_costumers_btn_Click);
            // 
            // costumersTableAdapter
            // 
            this.costumersTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "SEARCH BY : ";
            // 
            // search_by_combo_box
            // 
            this.search_by_combo_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_combo_box.FormattingEnabled = true;
            this.search_by_combo_box.Items.AddRange(new object[] {
            "NAME",
            "FAMILY",
            "PHONE",
            "EMAIL"});
            this.search_by_combo_box.Location = new System.Drawing.Point(228, 51);
            this.search_by_combo_box.Name = "search_by_combo_box";
            this.search_by_combo_box.Size = new System.Drawing.Size(191, 28);
            this.search_by_combo_box.TabIndex = 11;
            this.search_by_combo_box.Text = "fild name";
            this.search_by_combo_box.SelectedIndexChanged += new System.EventHandler(this.search_by_combo_box_SelectedIndexChanged);
            // 
            // search_text_box
            // 
            this.search_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text_box.Location = new System.Drawing.Point(461, 51);
            this.search_text_box.Multiline = true;
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(191, 28);
            this.search_text_box.TabIndex = 12;
            this.search_text_box.TextChanged += new System.EventHandler(this.search_text_box_TextChanged);
            // 
            // CostumersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 680);
            this.Controls.Add(this.search_text_box);
            this.Controls.Add(this.search_by_combo_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insert_costumers_btn);
            this.Controls.Add(this.update_costumers_btn);
            this.Controls.Add(this.delete_costumers_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CostumersListForm";
            this.Text = "CostumersListForm";
            this.Load += new System.EventHandler(this.CostumersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource shopdbDataSetBindingSource;
        private shop_dbDataSet shop_dbDataSet;
        private System.Windows.Forms.BindingSource costumersBindingSource;
        private shop_dbDataSetTableAdapters.costumersTableAdapter costumersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete_costumers_btn;
        internal System.Windows.Forms.Button update_costumers_btn;
        private System.Windows.Forms.Button insert_costumers_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox search_by_combo_box;
        private System.Windows.Forms.TextBox search_text_box;
    }
}