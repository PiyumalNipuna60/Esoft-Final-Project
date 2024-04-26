namespace MyProject
{
    partial class homePage
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnView = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRegister = new Button();
            groupBox4 = new GroupBox();
            txtNic = new TextBox();
            label13 = new Label();
            txtParentName = new TextBox();
            label14 = new Label();
            txtParentContact = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            txtHomeNo = new TextBox();
            label6 = new Label();
            txtMobileNo = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            cmbRegNo = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Gender = new Label();
            dateTimePicker = new DateTimePicker();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFistName = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(291, 43);
            label1.Name = "label1";
            label1.Size = new Size(250, 38);
            label1.TabIndex = 0;
            label1.Text = "Skill International";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnView);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cmbRegNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(51, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 852);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registation";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnView
            // 
            btnView.Location = new Point(375, 811);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 20;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(612, 811);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(262, 811);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 811);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(41, 811);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtNic);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtParentName);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(txtParentContact);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(33, 615);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(673, 181);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Perant Details";
            // 
            // txtNic
            // 
            txtNic.Location = new Point(141, 87);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(272, 27);
            txtNic.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(24, 91);
            label13.Name = "label13";
            label13.Size = new Size(44, 20);
            label13.TabIndex = 17;
            label13.Text = "NIC : ";
            // 
            // txtParentName
            // 
            txtParentName.Location = new Point(141, 40);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(272, 27);
            txtParentName.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(23, 44);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 15;
            label14.Text = "Perant name : ";
            // 
            // txtParentContact
            // 
            txtParentContact.Location = new Point(145, 134);
            txtParentContact.Name = "txtParentContact";
            txtParentContact.Size = new Size(146, 27);
            txtParentContact.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(24, 138);
            label12.Name = "label12";
            label12.Size = new Size(116, 20);
            label12.TabIndex = 5;
            label12.Text = "Parent Contact : ";
            label12.Click += label12_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtHomeNo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtMobileNo);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtAddress);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(33, 364);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 222);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txtHomeNo
            // 
            txtHomeNo.Location = new Point(402, 169);
            txtHomeNo.Name = "txtHomeNo";
            txtHomeNo.Size = new Size(168, 27);
            txtHomeNo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(291, 172);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 13;
            label6.Text = "Home No : ";
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(141, 166);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(122, 27);
            txtMobileNo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(25, 169);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 7;
            label7.Text = "mobile No : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(272, 27);
            txtEmail.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(24, 125);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 5;
            label8.Text = "Email : ";
            label8.Click += label8_Click;
            // 
            // txtAddress
            // 
            txtAddress.AccessibleRole = AccessibleRole.None;
            txtAddress.CausesValidation = false;
            txtAddress.Location = new Point(141, 42);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(272, 61);
            txtAddress.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(24, 46);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 3;
            label9.Text = "Address : ";
            label9.Click += label9_Click;
            // 
            // cmbRegNo
            // 
            cmbRegNo.FormattingEnabled = true;
            cmbRegNo.Location = new Point(318, 47);
            cmbRegNo.Name = "cmbRegNo";
            cmbRegNo.Size = new Size(168, 28);
            cmbRegNo.TabIndex = 2;
            cmbRegNo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(224, 49);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Reg No";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(Gender);
            groupBox2.Controls.Add(dateTimePicker);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtFistName);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(33, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 234);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(229, 185);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(138, 185);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI", 9F);
            Gender.Location = new Point(25, 182);
            Gender.Name = "Gender";
            Gender.Size = new Size(68, 20);
            Gender.TabIndex = 9;
            Gender.Text = "Gender : ";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(141, 134);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(258, 27);
            dateTimePicker.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(25, 137);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 7;
            label5.Text = "Date Of Birth :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(141, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(272, 27);
            txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(24, 93);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 5;
            label4.Text = "Last name : ";
            // 
            // txtFistName
            // 
            txtFistName.Location = new Point(141, 42);
            txtFistName.Name = "txtFistName";
            txtFistName.Size = new Size(272, 27);
            txtFistName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(24, 46);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "First name : ";
            label3.Click += label3_Click;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(844, 992);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "homePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "homePage";
            Load += homePage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox cmbRegNo;
        private Label label3;
        private TextBox txtFistName;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private Label Gender;
        private DateTimePicker dateTimePicker;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox4;
        private TextBox txtNic;
        private Label label13;
        private TextBox txtParentName;
        private Label label14;
        private TextBox txtParentContact;
        private Label label12;
        private GroupBox groupBox3;
        private TextBox txtHomeNo;
        private Label label6;
        private TextBox txtMobileNo;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtAddress;
        private Label label9;
        private Button btnUpdate;
        private Button btnRegister;
        private Button btnClear;
        private Button btnDelete;
        private Button btnView;
    }
}