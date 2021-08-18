namespace shop_database
{
    partial class products_list_form
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfConstructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shop_dbDataSet = new shop_database.shop_dbDataSet();
            this.search_text_box = new System.Windows.Forms.TextBox();
            this.search_by_combo_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_products_btn = new System.Windows.Forms.Button();
            this.update_products_btn = new System.Windows.Forms.Button();
            this.delete_products_btn = new System.Windows.Forms.Button();
            this.productsTableAdapter = new shop_database.shop_dbDataSetTableAdapters.productsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priseDataGridViewTextBoxColumn,
            this.yearOfConstructionDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priseDataGridViewTextBoxColumn
            // 
            this.priseDataGridViewTextBoxColumn.DataPropertyName = "prise";
            this.priseDataGridViewTextBoxColumn.HeaderText = "prise";
            this.priseDataGridViewTextBoxColumn.Name = "priseDataGridViewTextBoxColumn";
            this.priseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearOfConstructionDataGridViewTextBoxColumn
            // 
            this.yearOfConstructionDataGridViewTextBoxColumn.DataPropertyName = "year of construction";
            this.yearOfConstructionDataGridViewTextBoxColumn.HeaderText = "year of construction";
            this.yearOfConstructionDataGridViewTextBoxColumn.Name = "yearOfConstructionDataGridViewTextBoxColumn";
            this.yearOfConstructionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.shop_dbDataSet;
            // 
            // shop_dbDataSet
            // 
            this.shop_dbDataSet.DataSetName = "shop_dbDataSet";
            this.shop_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search_text_box
            // 
            this.search_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text_box.Location = new System.Drawing.Point(450, 51);
            this.search_text_box.Multiline = true;
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(179, 28);
            this.search_text_box.TabIndex = 21;
            this.search_text_box.TextChanged += new System.EventHandler(this.search_text_box_TextChanged);
            // 
            // search_by_combo_box
            // 
            this.search_by_combo_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_combo_box.FormattingEnabled = true;
            this.search_by_combo_box.Items.AddRange(new object[] {
            "ID",
            "CATEGORY",
            "NAME",
            "PRICE",
            "YEAR",
            "COLOR"});
            this.search_by_combo_box.Location = new System.Drawing.Point(224, 51);
            this.search_by_combo_box.Name = "search_by_combo_box";
            this.search_by_combo_box.Size = new System.Drawing.Size(179, 28);
            this.search_by_combo_box.TabIndex = 20;
            this.search_by_combo_box.Text = "fild name";
            this.search_by_combo_box.SelectedIndexChanged += new System.EventHandler(this.search_by_combo_box_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "SEARCH BY : ";
            // 
            // insert_products_btn
            // 
            this.insert_products_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.insert_products_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_products_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_products_btn.Location = new System.Drawing.Point(805, 541);
            this.insert_products_btn.Name = "insert_products_btn";
            this.insert_products_btn.Size = new System.Drawing.Size(135, 64);
            this.insert_products_btn.TabIndex = 22;
            this.insert_products_btn.Text = "INSERT";
            this.insert_products_btn.UseVisualStyleBackColor = false;
            this.insert_products_btn.Click += new System.EventHandler(this.insert_products_btn_Click);
            // 
            // update_products_btn
            // 
            this.update_products_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.update_products_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_products_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_products_btn.Location = new System.Drawing.Point(517, 541);
            this.update_products_btn.Name = "update_products_btn";
            this.update_products_btn.Size = new System.Drawing.Size(135, 64);
            this.update_products_btn.TabIndex = 23;
            this.update_products_btn.Text = "UPDATE";
            this.update_products_btn.UseVisualStyleBackColor = false;
            this.update_products_btn.Click += new System.EventHandler(this.update_products_btn_Click);
            // 
            // delete_products_btn
            // 
            this.delete_products_btn.BackColor = System.Drawing.Color.LightCoral;
            this.delete_products_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_products_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_products_btn.Location = new System.Drawing.Point(238, 541);
            this.delete_products_btn.Name = "delete_products_btn";
            this.delete_products_btn.Size = new System.Drawing.Size(135, 64);
            this.delete_products_btn.TabIndex = 24;
            this.delete_products_btn.Text = "DELETE";
            this.delete_products_btn.UseVisualStyleBackColor = false;
            this.delete_products_btn.Click += new System.EventHandler(this.delete_products_btn_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // products_list_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 680);
            this.Controls.Add(this.insert_products_btn);
            this.Controls.Add(this.update_products_btn);
            this.Controls.Add(this.delete_products_btn);
            this.Controls.Add(this.search_text_box);
            this.Controls.Add(this.search_by_combo_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "products_list_form";
            this.Text = "products_list_form";
            this.Load += new System.EventHandler(this.products_list_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shop_dbDataSet shop_dbDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private shop_dbDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfConstructionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox search_text_box;
        private System.Windows.Forms.ComboBox search_by_combo_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert_products_btn;
        internal System.Windows.Forms.Button update_products_btn;
        private System.Windows.Forms.Button delete_products_btn;

    }
}