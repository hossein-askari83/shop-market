namespace shop_database
{
    partial class update_purchaseFoem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoicesproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shop_dbDataSet = new shop_database.shop_dbDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblpayble = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.productsTableAdapter = new shop_database.shop_dbDataSetTableAdapters.productsTableAdapter();
            this.costumersTableAdapter1 = new shop_database.shop_dbDataSetTableAdapters.costumersTableAdapter();
            this.invoices_productsTableAdapter = new shop_database.shop_dbDataSetTableAdapters.invoices_productsTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCostumerName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFAmount = new System.Windows.Forms.TextBox();
            this.txtFGoodsCode = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.invoicesTableAdapter1 = new shop_database.shop_dbDataSetTableAdapters.invoicesTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.producttotalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dbDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(557, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 359);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PURCHASES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.productnumberDataGridViewTextBoxColumn,
            this.producttotalpriceDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.invoicesproductsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded_1);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved_1);
            // 
            // invoicesproductsBindingSource
            // 
            this.invoicesproductsBindingSource.DataMember = "invoices_products";
            this.invoicesproductsBindingSource.DataSource = this.shop_dbDataSet;
            // 
            // shop_dbDataSet
            // 
            this.shop_dbDataSet.DataSetName = "shop_dbDataSet";
            this.shop_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "SUBMIT IN PURCHASE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(279, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 23);
            this.label16.TabIndex = 3;
            this.label16.Text = "PRICE:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(322, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "NUMBER:";
            // 
            // lblPrice
            // 
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(351, 65);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.ForeColor = System.Drawing.Color.Red;
            this.lblProductName.Location = new System.Drawing.Point(154, 65);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(112, 23);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.ForeColor = System.Drawing.Color.Red;
            this.lblYear.Location = new System.Drawing.Point(257, 121);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 23);
            this.lblYear.TabIndex = 4;
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColor
            // 
            this.lblColor.ForeColor = System.Drawing.Color.Red;
            this.lblColor.Location = new System.Drawing.Point(77, 121);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(105, 23);
            this.lblColor.TabIndex = 4;
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(197, 124);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 23);
            this.label19.TabIndex = 3;
            this.label19.Text = "YEAR:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.lblpayble);
            this.groupBox5.Location = new System.Drawing.Point(557, 377);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 47);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(113, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 23);
            this.label20.TabIndex = 3;
            this.label20.Text = "PAYABLE:";
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(469, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 23);
            this.label22.TabIndex = 4;
            this.label22.Text = "$";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpayble
            // 
            this.lblpayble.ForeColor = System.Drawing.Color.Red;
            this.lblpayble.Location = new System.Drawing.Point(351, 15);
            this.lblpayble.Name = "lblpayble";
            this.lblpayble.Size = new System.Drawing.Size(112, 23);
            this.lblpayble.TabIndex = 4;
            this.lblpayble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(1133, 380);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(147, 44);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "SUBMIT FORM";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // costumersTableAdapter1
            // 
            this.costumersTableAdapter1.ClearBeforeFill = true;
            // 
            // invoices_productsTableAdapter
            // 
            this.invoices_productsTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "COLOR:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblphone);
            this.groupBox3.Controls.Add(this.lblFamily);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Controls.Add(this.lblCostumerName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 168);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // lblphone
            // 
            this.lblphone.ForeColor = System.Drawing.Color.Red;
            this.lblphone.Location = new System.Drawing.Point(166, 11);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(151, 23);
            this.lblphone.TabIndex = 4;
            this.lblphone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFamily
            // 
            this.lblFamily.ForeColor = System.Drawing.Color.Red;
            this.lblFamily.Location = new System.Drawing.Point(359, 69);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(153, 23);
            this.lblFamily.TabIndex = 4;
            this.lblFamily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(98, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(153, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCostumerName
            // 
            this.lblCostumerName.ForeColor = System.Drawing.Color.Red;
            this.lblCostumerName.Location = new System.Drawing.Point(87, 69);
            this.lblCostumerName.Name = "lblCostumerName";
            this.lblCostumerName.Size = new System.Drawing.Size(164, 23);
            this.lblCostumerName.TabIndex = 4;
            this.lblCostumerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "EMAIL:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "COSTUMER PHONE:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "FAMILY:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "NAME:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbldate);
            this.groupBox2.Controls.Add(this.lblInvoiceId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Red;
            this.lbldate.Location = new System.Drawing.Point(99, 18);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(122, 20);
            this.lbldate.TabIndex = 4;
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceId.ForeColor = System.Drawing.Color.Red;
            this.lblInvoiceId.Location = new System.Drawing.Point(358, 19);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(105, 20);
            this.lblInvoiceId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "INVOICE_ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATE :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblPrice);
            this.groupBox4.Controls.Add(this.lblProductName);
            this.groupBox4.Controls.Add(this.lblYear);
            this.groupBox4.Controls.Add(this.lblColor);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtFAmount);
            this.groupBox4.Controls.Add(this.txtFGoodsCode);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 168);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "PRODUCT NAME:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "PRODUCT ID:";
            // 
            // txtFAmount
            // 
            this.txtFAmount.Location = new System.Drawing.Point(413, 15);
            this.txtFAmount.Multiline = true;
            this.txtFAmount.Name = "txtFAmount";
            this.txtFAmount.Size = new System.Drawing.Size(102, 26);
            this.txtFAmount.TabIndex = 1;
            this.txtFAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFGoodsCode
            // 
            this.txtFGoodsCode.Location = new System.Drawing.Point(132, 15);
            this.txtFGoodsCode.Multiline = true;
            this.txtFGoodsCode.Name = "txtFGoodsCode";
            this.txtFGoodsCode.Size = new System.Drawing.Size(144, 26);
            this.txtFGoodsCode.TabIndex = 1;
            this.txtFGoodsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(282, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "»";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // invoicesTableAdapter1
            // 
            this.invoicesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::shop_database.Properties.Resources.delete_sign__v2;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = global::shop_database.Properties.Resources.delete_sign__v21;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 25;
            // 
            // producttotalpriceDataGridViewTextBoxColumn
            // 
            this.producttotalpriceDataGridViewTextBoxColumn.DataPropertyName = "product_total_price";
            this.producttotalpriceDataGridViewTextBoxColumn.HeaderText = "product_total_price";
            this.producttotalpriceDataGridViewTextBoxColumn.Name = "producttotalpriceDataGridViewTextBoxColumn";
            this.producttotalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnumberDataGridViewTextBoxColumn
            // 
            this.productnumberDataGridViewTextBoxColumn.DataPropertyName = "product_number";
            this.productnumberDataGridViewTextBoxColumn.HeaderText = "product_number";
            this.productnumberDataGridViewTextBoxColumn.Name = "productnumberDataGridViewTextBoxColumn";
            this.productnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "product_price";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceidDataGridViewTextBoxColumn
            // 
            this.invoiceidDataGridViewTextBoxColumn.DataPropertyName = "invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.HeaderText = "invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.Name = "invoiceidDataGridViewTextBoxColumn";
            this.invoiceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // update_purchaseFoem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "update_purchaseFoem";
            this.Text = "update_purchaseFoem";
            this.Load += new System.EventHandler(this.update_purchaseFoem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shop_dbDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invoicesproductsBindingSource;
        private shop_dbDataSet shop_dbDataSet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblpayble;
        private System.Windows.Forms.Button submitBtn;
        private shop_dbDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private shop_dbDataSetTableAdapters.costumersTableAdapter costumersTableAdapter1;
        private shop_dbDataSetTableAdapters.invoices_productsTableAdapter invoices_productsTableAdapter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCostumerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFAmount;
        private System.Windows.Forms.TextBox txtFGoodsCode;
        private System.Windows.Forms.Button button3;
        private shop_dbDataSetTableAdapters.invoicesTableAdapter invoicesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producttotalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}