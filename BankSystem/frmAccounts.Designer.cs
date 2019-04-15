namespace BankSystem
{
    partial class frmAccounts
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
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilterAccountNumber = new System.Windows.Forms.TextBox();
            this.txtFilterAccountFirstName = new System.Windows.Forms.TextBox();
            this.lblFilterAccountNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtFilterAccountLastName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Location = new System.Drawing.Point(256, 221);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(75, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(136, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 91);
            this.label4.TabIndex = 11;
            this.label4.Text = "^\r\nButton na menežovanie aktuálne zvoleného účtu v gride";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterAccountNumber
            // 
            this.txtFilterAccountNumber.Location = new System.Drawing.Point(12, 25);
            this.txtFilterAccountNumber.Name = "txtFilterAccountNumber";
            this.txtFilterAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFilterAccountNumber.TabIndex = 12;
            this.txtFilterAccountNumber.TextChanged += new System.EventHandler(this.txtFilterAccountNumber_TextChanged);
            // 
            // txtFilterAccountFirstName
            // 
            this.txtFilterAccountFirstName.Location = new System.Drawing.Point(141, 25);
            this.txtFilterAccountFirstName.Name = "txtFilterAccountFirstName";
            this.txtFilterAccountFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFilterAccountFirstName.TabIndex = 13;
            this.txtFilterAccountFirstName.TextChanged += new System.EventHandler(this.txtFilterAccountFirstName_TextChanged);
            // 
            // lblFilterAccountNumber
            // 
            this.lblFilterAccountNumber.AutoSize = true;
            this.lblFilterAccountNumber.Location = new System.Drawing.Point(9, 9);
            this.lblFilterAccountNumber.Name = "lblFilterAccountNumber";
            this.lblFilterAccountNumber.Size = new System.Drawing.Size(85, 13);
            this.lblFilterAccountNumber.TabIndex = 14;
            this.lblFilterAccountNumber.Text = "Account number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(138, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "First name";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(12, 51);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.Size = new System.Drawing.Size(560, 164);
            this.dgvAccounts.TabIndex = 16;
            this.dgvAccounts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_RowEnter);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(244, 9);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(56, 13);
            this.lblLastname.TabIndex = 18;
            this.lblLastname.Text = "Last name";
            // 
            // txtFilterAccountLastName
            // 
            this.txtFilterAccountLastName.Location = new System.Drawing.Point(247, 25);
            this.txtFilterAccountLastName.Name = "txtFilterAccountLastName";
            this.txtFilterAccountLastName.Size = new System.Drawing.Size(100, 20);
            this.txtFilterAccountLastName.TabIndex = 17;
            this.txtFilterAccountLastName.TextChanged += new System.EventHandler(this.txtFilterAccountLastName_TextChanged);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtFilterAccountLastName);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFilterAccountNumber);
            this.Controls.Add(this.txtFilterAccountFirstName);
            this.Controls.Add(this.txtFilterAccountNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdManageAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilterAccountNumber;
        private System.Windows.Forms.TextBox txtFilterAccountFirstName;
        private System.Windows.Forms.Label lblFilterAccountNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtFilterAccountLastName;
    }
}