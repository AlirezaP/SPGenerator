namespace SPGenarator
{
    partial class MainForm
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
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnCreateCrud = new System.Windows.Forms.Button();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.btnScriptForm = new System.Windows.Forms.Button();
            this.gbSpName = new System.Windows.Forms.GroupBox();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.chbSpName = new System.Windows.Forms.CheckBox();
            this.gbSpName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(605, 88);
            this.btnLoadTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(100, 28);
            this.btnLoadTable.TabIndex = 0;
            this.btnLoadTable.Text = "LoadTables";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(132, 16);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(573, 22);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "Data Source=.\\ap;Initial Catalog=sms;Integrated Security=True;Connect Timeout=15;" +
    "Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubne" +
    "tFailover=False";
            // 
            // btnCreateCrud
            // 
            this.btnCreateCrud.Location = new System.Drawing.Point(577, 160);
            this.btnCreateCrud.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCrud.Name = "btnCreateCrud";
            this.btnCreateCrud.Size = new System.Drawing.Size(128, 28);
            this.btnCreateCrud.TabIndex = 3;
            this.btnCreateCrud.Text = "Create CRUD";
            this.btnCreateCrud.UseVisualStyleBackColor = true;
            this.btnCreateCrud.Click += new System.EventHandler(this.btnCreateCrud_Click);
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(132, 48);
            this.cmbTable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(160, 24);
            this.cmbTable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connection String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table";
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Location = new System.Drawing.Point(605, 54);
            this.btnAddConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(100, 28);
            this.btnAddConnection.TabIndex = 7;
            this.btnAddConnection.Text = "AddConnection";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // btnScriptForm
            // 
            this.btnScriptForm.Location = new System.Drawing.Point(605, 124);
            this.btnScriptForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnScriptForm.Name = "btnScriptForm";
            this.btnScriptForm.Size = new System.Drawing.Size(100, 28);
            this.btnScriptForm.TabIndex = 8;
            this.btnScriptForm.Text = "View Script";
            this.btnScriptForm.UseVisualStyleBackColor = true;
            this.btnScriptForm.Click += new System.EventHandler(this.btnScriptForm_Click);
            // 
            // gbSpName
            // 
            this.gbSpName.Controls.Add(this.label12);
            this.gbSpName.Controls.Add(this.label13);
            this.gbSpName.Controls.Add(this.label14);
            this.gbSpName.Controls.Add(this.txtDeleteName);
            this.gbSpName.Controls.Add(this.label9);
            this.gbSpName.Controls.Add(this.label10);
            this.gbSpName.Controls.Add(this.label11);
            this.gbSpName.Controls.Add(this.txtUpdateName);
            this.gbSpName.Controls.Add(this.label6);
            this.gbSpName.Controls.Add(this.label7);
            this.gbSpName.Controls.Add(this.label8);
            this.gbSpName.Controls.Add(this.txtInsertName);
            this.gbSpName.Controls.Add(this.label5);
            this.gbSpName.Controls.Add(this.label4);
            this.gbSpName.Controls.Add(this.label3);
            this.gbSpName.Controls.Add(this.txtListName);
            this.gbSpName.Enabled = false;
            this.gbSpName.Location = new System.Drawing.Point(6, 127);
            this.gbSpName.Name = "gbSpName";
            this.gbSpName.Size = new System.Drawing.Size(537, 182);
            this.gbSpName.TabIndex = 9;
            this.gbSpName.TabStop = false;
            this.gbSpName.Text = "SP Name";
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(90, 30);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(166, 22);
            this.txtListName.TabIndex = 0;
            this.txtListName.Text = "Sel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "_TableName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Sample: Sel_User)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "List SP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert SP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "(Sample: Inc_User)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "_TableName";
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(90, 69);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(166, 22);
            this.txtInsertName.TabIndex = 10;
            this.txtInsertName.Text = "Inc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Update SP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "(Sample: Upd_User)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "_TableName";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(90, 107);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(166, 22);
            this.txtUpdateName.TabIndex = 14;
            this.txtUpdateName.Text = "Upd";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Delete SP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "(Sample: Del_User)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 150);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "_TableName";
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Location = new System.Drawing.Point(90, 147);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(166, 22);
            this.txtDeleteName.TabIndex = 18;
            this.txtDeleteName.Text = "Del";
            // 
            // chbSpName
            // 
            this.chbSpName.AutoSize = true;
            this.chbSpName.Location = new System.Drawing.Point(20, 100);
            this.chbSpName.Name = "chbSpName";
            this.chbSpName.Size = new System.Drawing.Size(74, 21);
            this.chbSpName.TabIndex = 10;
            this.chbSpName.Text = "Enable";
            this.chbSpName.UseVisualStyleBackColor = true;
            this.chbSpName.CheckedChanged += new System.EventHandler(this.chbSpName_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 317);
            this.Controls.Add(this.chbSpName);
            this.Controls.Add(this.gbSpName);
            this.Controls.Add(this.btnScriptForm);
            this.Controls.Add(this.btnAddConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.btnCreateCrud);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnLoadTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AP SpGenerator";
            this.gbSpName.ResumeLayout(false);
            this.gbSpName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnCreateCrud;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.Button btnScriptForm;
        private System.Windows.Forms.GroupBox gbSpName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.CheckBox chbSpName;
    }
}

