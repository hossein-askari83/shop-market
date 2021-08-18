namespace shop_database
{
    partial class login_form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsDataSet = new shop_database.adminsDataSet();
            this.adminstableTableAdapter = new shop_database.adminsDataSetTableAdapters.adminstableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shop_database.Properties.Resources._1081856_200;
            this.pictureBox1.Location = new System.Drawing.Point(20, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxtbox.Location = new System.Drawing.Point(493, 118);
            this.usernametxtbox.Multiline = true;
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(236, 26);
            this.usernametxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD :";
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxtbox.Location = new System.Drawing.Point(493, 174);
            this.passwordtxtbox.Multiline = true;
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.Size = new System.Drawing.Size(236, 26);
            this.passwordtxtbox.TabIndex = 1;
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword.Location = new System.Drawing.Point(332, 232);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(147, 24);
            this.showpassword.TabIndex = 3;
            this.showpassword.Text = "show password";
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged_1);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(378, 289);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(132, 37);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOG IN ";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.Crimson;
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(576, 289);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(132, 37);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(325, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "WELCOME";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "adminstable";
            this.bindingSource.DataSource = this.adminsDataSet;
            // 
            // adminsDataSet
            // 
            this.adminsDataSet.DataSetName = "adminsDataSet";
            this.adminsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminstableTableAdapter
            // 
            this.adminstableTableAdapter.ClearBeforeFill = true;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(823, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_form";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.login_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource;
        private adminsDataSet adminsDataSet;
        private adminsDataSetTableAdapters.adminstableTableAdapter adminstableTableAdapter;

    }
}