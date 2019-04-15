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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFilterAccountNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
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
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(12, 51);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Size = new System.Drawing.Size(560, 164);
            this.dgvAccounts.TabIndex = 16;
            this.dgvAccounts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_RowEnter);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFilterAccountNumber);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFilterAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAccounts;
    }
}