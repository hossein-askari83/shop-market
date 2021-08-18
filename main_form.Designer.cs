namespace shop_database
{
    partial class main_form
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
            this.showcostumerslistbtn = new System.Windows.Forms.Button();
            this.showinvoiceslistbtn = new System.Windows.Forms.Button();
            this.showproductslistbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showcostumerslistbtn
            // 
            this.showcostumerslistbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showcostumerslistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showcostumerslistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showcostumerslistbtn.Font = new System.Drawing.Font("Vazir", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcostumerslistbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showcostumerslistbtn.Location = new System.Drawing.Point(120, 51);
            this.showcostumerslistbtn.Name = "showcostumerslistbtn";
            this.showcostumerslistbtn.Size = new System.Drawing.Size(409, 94);
            this.showcostumerslistbtn.TabIndex = 0;
            this.showcostumerslistbtn.Text = "COMTUMERS LIST";
            this.showcostumerslistbtn.UseVisualStyleBackColor = false;
            this.showcostumerslistbtn.Click += new System.EventHandler(this.showcostumerslistbtn_Click);
            // 
            // showinvoiceslistbtn
            // 
            this.showinvoiceslistbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showinvoiceslistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showinvoiceslistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showinvoiceslistbtn.Font = new System.Drawing.Font("Vazir", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showinvoiceslistbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showinvoiceslistbtn.Location = new System.Drawing.Point(120, 409);
            this.showinvoiceslistbtn.Name = "showinvoiceslistbtn";
            this.showinvoiceslistbtn.Size = new System.Drawing.Size(409, 94);
            this.showinvoiceslistbtn.TabIndex = 0;
            this.showinvoiceslistbtn.Text = "INVOICES LIST";
            this.showinvoiceslistbtn.UseVisualStyleBackColor = false;
            this.showinvoiceslistbtn.Click += new System.EventHandler(this.showinvoiceslistbtn_Click);
            // 
            // showproductslistbtn
            // 
            this.showproductslistbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.showproductslistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showproductslistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showproductslistbtn.Font = new System.Drawing.Font("Vazir", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showproductslistbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showproductslistbtn.Location = new System.Drawing.Point(120, 229);
            this.showproductslistbtn.Name = "showproductslistbtn";
            this.showproductslistbtn.Size = new System.Drawing.Size(409, 94);
            this.showproductslistbtn.TabIndex = 0;
            this.showproductslistbtn.Text = "PRODUCTS LIST";
            this.showproductslistbtn.UseVisualStyleBackColor = false;
            this.showproductslistbtn.Click += new System.EventHandler(this.showproductslistbtn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 556);
            this.Controls.Add(this.showproductslistbtn);
            this.Controls.Add(this.showinvoiceslistbtn);
            this.Controls.Add(this.showcostumerslistbtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showcostumerslistbtn;
        private System.Windows.Forms.Button showinvoiceslistbtn;
        private System.Windows.Forms.Button showproductslistbtn;
    }
}

