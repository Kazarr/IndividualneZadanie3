namespace BankSystem
{
    partial class frmTransaction
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
            this.lblFirstNameRecieved = new System.Windows.Forms.Label();
            this.lblLastNameRecieved = new System.Windows.Forms.Label();
            this.lblIbanSend = new System.Windows.Forms.Label();
            this.lblFirstNameSend = new System.Windows.Forms.Label();
            this.lblLastNameSend = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblIbanRecieved = new System.Windows.Forms.Label();
            this.txtKS = new System.Windows.Forms.TextBox();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblVariableMark = new System.Windows.Forms.Label();
            this.lblSpecificMark = new System.Windows.Forms.Label();
            this.lblConstantMark = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNameRecieved
            // 
            this.lblFirstNameRecieved.AutoSize = true;
            this.lblFirstNameRecieved.Location = new System.Drawing.Point(219, 93);
            this.lblFirstNameRecieved.Name = "lblFirstNameRecieved";
            this.lblFirstNameRecieved.Size = new System.Drawing.Size(35, 13);
            this.lblFirstNameRecieved.TabIndex = 9;
            this.lblFirstNameRecieved.Text = "label4";
            // 
            // lblLastNameRecieved
            // 
            this.lblLastNameRecieved.AutoSize = true;
            this.lblLastNameRecieved.Location = new System.Drawing.Point(392, 93);
            this.lblLastNameRecieved.Name = "lblLastNameRecieved";
            this.lblLastNameRecieved.Size = new System.Drawing.Size(35, 13);
            this.lblLastNameRecieved.TabIndex = 10;
            this.lblLastNameRecieved.Text = "label4";
            // 
            // lblIbanSend
            // 
            this.lblIbanSend.AutoSize = true;
            this.lblIbanSend.Location = new System.Drawing.Point(7, 27);
            this.lblIbanSend.Name = "lblIbanSend";
            this.lblIbanSend.Size = new System.Drawing.Size(35, 13);
            this.lblIbanSend.TabIndex = 11;
            this.lblIbanSend.Text = "label4";
            // 
            // lblFirstNameSend
            // 
            this.lblFirstNameSend.AutoSize = true;
            this.lblFirstNameSend.Location = new System.Drawing.Point(7, 50);
            this.lblFirstNameSend.Name = "lblFirstNameSend";
            this.lblFirstNameSend.Size = new System.Drawing.Size(35, 13);
            this.lblFirstNameSend.TabIndex = 12;
            this.lblFirstNameSend.Text = "label4";
            // 
            // lblLastNameSend
            // 
            this.lblLastNameSend.AutoSize = true;
            this.lblLastNameSend.Location = new System.Drawing.Point(105, 50);
            this.lblLastNameSend.Name = "lblLastNameSend";
            this.lblLastNameSend.Size = new System.Drawing.Size(35, 13);
            this.lblLastNameSend.TabIndex = 13;
            this.lblLastNameSend.Text = "label4";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(219, 43);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(205, 20);
            this.txtIban.TabIndex = 14;
            this.txtIban.Leave += new System.EventHandler(this.txtIban_Leave);
            // 
            // lblIbanRecieved
            // 
            this.lblIbanRecieved.AutoSize = true;
            this.lblIbanRecieved.Location = new System.Drawing.Point(219, 27);
            this.lblIbanRecieved.Name = "lblIbanRecieved";
            this.lblIbanRecieved.Size = new System.Drawing.Size(32, 13);
            this.lblIbanRecieved.TabIndex = 15;
            this.lblIbanRecieved.Text = "IBAN";
            // 
            // txtKS
            // 
            this.txtKS.Location = new System.Drawing.Point(10, 260);
            this.txtKS.Name = "txtKS";
            this.txtKS.Size = new System.Drawing.Size(48, 20);
            this.txtKS.TabIndex = 16;
            // 
            // txtVS
            // 
            this.txtVS.Location = new System.Drawing.Point(10, 180);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(100, 20);
            this.txtVS.TabIndex = 17;
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(10, 220);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 20);
            this.txtSS.TabIndex = 18;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(164, 139);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 19;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(134, 220);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(163, 20);
            this.txtMessage.TabIndex = 20;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(353, 257);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(192, 123);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 23;
            this.lblAmount.Text = "Amount";
            // 
            // lblVariableMark
            // 
            this.lblVariableMark.AutoSize = true;
            this.lblVariableMark.Location = new System.Drawing.Point(7, 164);
            this.lblVariableMark.Name = "lblVariableMark";
            this.lblVariableMark.Size = new System.Drawing.Size(71, 13);
            this.lblVariableMark.TabIndex = 24;
            this.lblVariableMark.Text = "Variable mark";
            // 
            // lblSpecificMark
            // 
            this.lblSpecificMark.AutoSize = true;
            this.lblSpecificMark.Location = new System.Drawing.Point(7, 204);
            this.lblSpecificMark.Name = "lblSpecificMark";
            this.lblSpecificMark.Size = new System.Drawing.Size(71, 13);
            this.lblSpecificMark.TabIndex = 25;
            this.lblSpecificMark.Text = "Specific mark";
            // 
            // lblConstantMark
            // 
            this.lblConstantMark.AutoSize = true;
            this.lblConstantMark.Location = new System.Drawing.Point(7, 244);
            this.lblConstantMark.Name = "lblConstantMark";
            this.lblConstantMark.Size = new System.Drawing.Size(75, 13);
            this.lblConstantMark.TabIndex = 26;
            this.lblConstantMark.Text = "Constant mark";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(353, 257);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblConstantMark);
            this.Controls.Add(this.lblSpecificMark);
            this.Controls.Add(this.lblVariableMark);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.txtVS);
            this.Controls.Add(this.txtKS);
            this.Controls.Add(this.lblIbanRecieved);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblLastNameSend);
            this.Controls.Add(this.lblFirstNameSend);
            this.Controls.Add(this.lblIbanSend);
            this.Controls.Add(this.lblLastNameRecieved);
            this.Controls.Add(this.lblFirstNameRecieved);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstNameRecieved;
        private System.Windows.Forms.Label lblLastNameRecieved;
        private System.Windows.Forms.Label lblIbanSend;
        private System.Windows.Forms.Label lblFirstNameSend;
        private System.Windows.Forms.Label lblLastNameSend;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label lblIbanRecieved;
        private System.Windows.Forms.TextBox txtKS;
        private System.Windows.Forms.TextBox txtVS;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblVariableMark;
        private System.Windows.Forms.Label lblSpecificMark;
        private System.Windows.Forms.Label lblConstantMark;
        private System.Windows.Forms.Button btnDone;
    }
}