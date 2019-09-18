namespace Service_Ticket_Desktop_Application
{
    partial class frmNewTicket
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
            this.dteDateIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInventoryItem = new System.Windows.Forms.TextBox();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpNewClient = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rdoExistingClient = new System.Windows.Forms.RadioButton();
            this.rdoNewClient = new System.Windows.Forms.RadioButton();
            this.btnToday = new System.Windows.Forms.Button();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnFindByPhone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnShowHidePassword = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpExistingClient = new System.Windows.Forms.GroupBox();
            this.lstExistingClients = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpNewClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpExistingClient.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dteDateIn
            // 
            this.dteDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteDateIn.Location = new System.Drawing.Point(9, 74);
            this.dteDateIn.Name = "dteDateIn";
            this.dteDateIn.Size = new System.Drawing.Size(85, 20);
            this.dteDateIn.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Drop Off Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(189, 133);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 20);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 20);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtInventoryItem
            // 
            this.txtInventoryItem.Location = new System.Drawing.Point(9, 133);
            this.txtInventoryItem.Name = "txtInventoryItem";
            this.txtInventoryItem.Size = new System.Drawing.Size(111, 20);
            this.txtInventoryItem.TabIndex = 0;
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(9, 32);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(237, 95);
            this.lstInventory.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Description of Problem";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 32);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(253, 119);
            this.txtDescription.TabIndex = 0;
            // 
            // grpNewClient
            // 
            this.grpNewClient.Controls.Add(this.label3);
            this.grpNewClient.Controls.Add(this.label5);
            this.grpNewClient.Controls.Add(this.txtFirstName);
            this.grpNewClient.Controls.Add(this.label4);
            this.grpNewClient.Controls.Add(this.txtLastName);
            this.grpNewClient.Controls.Add(this.txtPhoneNumber);
            this.grpNewClient.Enabled = false;
            this.grpNewClient.Location = new System.Drawing.Point(175, 39);
            this.grpNewClient.Name = "grpNewClient";
            this.grpNewClient.Size = new System.Drawing.Size(144, 141);
            this.grpNewClient.TabIndex = 3;
            this.grpNewClient.TabStop = false;
            this.grpNewClient.Text = "New Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(9, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(126, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(9, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(9, 110);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(126, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // rdoExistingClient
            // 
            this.rdoExistingClient.AutoSize = true;
            this.rdoExistingClient.Enabled = false;
            this.rdoExistingClient.Location = new System.Drawing.Point(46, 16);
            this.rdoExistingClient.Name = "rdoExistingClient";
            this.rdoExistingClient.Size = new System.Drawing.Size(83, 17);
            this.rdoExistingClient.TabIndex = 0;
            this.rdoExistingClient.TabStop = true;
            this.rdoExistingClient.Text = "Use Existing";
            this.rdoExistingClient.UseVisualStyleBackColor = true;
            this.rdoExistingClient.CheckedChanged += new System.EventHandler(this.RdoExistingClient_CheckedChanged);
            // 
            // rdoNewClient
            // 
            this.rdoNewClient.AutoSize = true;
            this.rdoNewClient.Enabled = false;
            this.rdoNewClient.Location = new System.Drawing.Point(203, 16);
            this.rdoNewClient.Name = "rdoNewClient";
            this.rdoNewClient.Size = new System.Drawing.Size(89, 17);
            this.rdoNewClient.TabIndex = 1;
            this.rdoNewClient.TabStop = true;
            this.rdoNewClient.Text = "Register New";
            this.rdoNewClient.UseVisualStyleBackColor = true;
            this.rdoNewClient.CheckedChanged += new System.EventHandler(this.RdoNewClient_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(100, 74);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(53, 20);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(9, 32);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSearchPhoneNumber.TabIndex = 0;
            // 
            // btnFindByPhone
            // 
            this.btnFindByPhone.Location = new System.Drawing.Point(115, 32);
            this.btnFindByPhone.Name = "btnFindByPhone";
            this.btnFindByPhone.Size = new System.Drawing.Size(75, 20);
            this.btnFindByPhone.TabIndex = 1;
            this.btnFindByPhone.Text = "Find";
            this.btnFindByPhone.UseVisualStyleBackColor = true;
            this.btnFindByPhone.Click += new System.EventHandler(this.BtnFindByPhone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnShowHidePassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dteDateIn);
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.btnFindByPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSearchPhoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.Location = new System.Drawing.Point(115, 116);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(56, 21);
            this.btnShowHidePassword.TabIndex = 3;
            this.btnShowHidePassword.Text = "Hide";
            this.btnShowHidePassword.UseVisualStyleBackColor = true;
            this.btnShowHidePassword.Click += new System.EventHandler(this.BtnShowHidePassword_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoExistingClient);
            this.groupBox2.Controls.Add(this.grpNewClient);
            this.groupBox2.Controls.Add(this.rdoNewClient);
            this.groupBox2.Controls.Add(this.grpExistingClient);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // grpExistingClient
            // 
            this.grpExistingClient.Controls.Add(this.lstExistingClients);
            this.grpExistingClient.Enabled = false;
            this.grpExistingClient.Location = new System.Drawing.Point(6, 39);
            this.grpExistingClient.Name = "grpExistingClient";
            this.grpExistingClient.Size = new System.Drawing.Size(163, 141);
            this.grpExistingClient.TabIndex = 2;
            this.grpExistingClient.TabStop = false;
            this.grpExistingClient.Text = "Existing Client";
            // 
            // lstExistingClients
            // 
            this.lstExistingClients.FormattingEnabled = true;
            this.lstExistingClients.Location = new System.Drawing.Point(6, 18);
            this.lstExistingClients.Name = "lstExistingClients";
            this.lstExistingClients.Size = new System.Drawing.Size(149, 108);
            this.lstExistingClients.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstInventory);
            this.groupBox3.Controls.Add(this.txtInventoryItem);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 163);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(275, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 163);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(471, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(309, 375);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // frmNewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 403);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNewTicket";
            this.Text = "New Service Ticket";
            this.grpNewClient.ResumeLayout(false);
            this.grpNewClient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpExistingClient.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dteDateIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInventoryItem;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpNewClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rdoExistingClient;
        private System.Windows.Forms.RadioButton rdoNewClient;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.TextBox txtSearchPhoneNumber;
        private System.Windows.Forms.Button btnFindByPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grpExistingClient;
        private System.Windows.Forms.ListBox lstExistingClients;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Button btnShowHidePassword;
    }
}

