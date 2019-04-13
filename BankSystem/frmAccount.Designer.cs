namespace BankSystem
{
    partial class frmAccount
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lblActualOverflow = new System.Windows.Forms.Label();
            this.lblOverFlowLimit = new System.Windows.Forms.Label();
            this.txtOverFlowLimit = new System.Windows.Forms.TextBox();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAcutalOverFlowValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(315, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(475, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(314, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(478, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 16;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(315, 98);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 17;
            this.lblAdress.Text = "Adress";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(314, 115);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(280, 20);
            this.txtAdress.TabIndex = 18;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(315, 138);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(314, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 20;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(428, 138);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(63, 13);
            this.lblPostalCode.TabIndex = 21;
            this.lblPostalCode.Text = "Postal code";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(431, 154);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 22;
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(315, 192);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(53, 13);
            this.lblIdNumber.TabIndex = 23;
            this.lblIdNumber.Text = "IdNumber";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(314, 209);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIdNumber.TabIndex = 24;
            // 
            // lblActualOverflow
            // 
            this.lblActualOverflow.AutoSize = true;
            this.lblActualOverflow.Location = new System.Drawing.Point(12, 113);
            this.lblActualOverflow.Name = "lblActualOverflow";
            this.lblActualOverflow.Size = new System.Drawing.Size(80, 13);
            this.lblActualOverflow.TabIndex = 5;
            this.lblActualOverflow.Text = "Actual overflow";
            // 
            // lblOverFlowLimit
            // 
            this.lblOverFlowLimit.AutoSize = true;
            this.lblOverFlowLimit.Location = new System.Drawing.Point(146, 113);
            this.lblOverFlowLimit.Name = "lblOverFlowLimit";
            this.lblOverFlowLimit.Size = new System.Drawing.Size(69, 13);
            this.lblOverFlowLimit.TabIndex = 6;
            this.lblOverFlowLimit.Text = "Overflow limit";
            // 
            // txtOverFlowLimit
            // 
            this.txtOverFlowLimit.Location = new System.Drawing.Point(149, 129);
            this.txtOverFlowLimit.Name = "txtOverFlowLimit";
            this.txtOverFlowLimit.Size = new System.Drawing.Size(100, 20);
            this.txtOverFlowLimit.TabIndex = 8;
            // 
            // lblIBAN
            // 
            this.lblIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIBAN.Location = new System.Drawing.Point(12, 41);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(297, 20);
            this.lblIBAN.TabIndex = 9;
            this.lblIBAN.Tag = "";
            this.lblIBAN.Text = "labelSIbanom";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(11, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(297, 20);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Tag = "";
            this.lblAmount.Text = "labelSoZostakom";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Enabled = false;
            this.dtpCreationDate.Location = new System.Drawing.Point(12, 232);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(184, 20);
            this.dtpCreationDate.TabIndex = 11;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(13, 216);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(70, 13);
            this.lblCreationDate.TabIndex = 12;
            this.lblCreationDate.Text = "Creation date";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(519, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAcutalOverFlowValue
            // 
            this.lblAcutalOverFlowValue.AutoSize = true;
            this.lblAcutalOverFlowValue.Location = new System.Drawing.Point(13, 132);
            this.lblAcutalOverFlowValue.Name = "lblAcutalOverFlowValue";
            this.lblAcutalOverFlowValue.Size = new System.Drawing.Size(35, 13);
            this.lblAcutalOverFlowValue.TabIndex = 27;
            this.lblAcutalOverFlowValue.Text = "label1";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.lblAcutalOverFlowValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.lblIdNumber);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.dtpCreationDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.txtOverFlowLimit);
            this.Controls.Add(this.lblOverFlowLimit);
            this.Controls.Add(this.lblActualOverflow);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblActualOverflow;
        private System.Windows.Forms.Label lblOverFlowLimit;
        private System.Windows.Forms.TextBox txtOverFlowLimit;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAcutalOverFlowValue;
    }
}