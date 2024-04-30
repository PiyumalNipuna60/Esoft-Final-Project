namespace MyProject
{
    partial class signInForm
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
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtPassword = new TextBox();
            label6 = new Label();
            txtContactNo = new TextBox();
            label5 = new Label();
            loginButton = new Button();
            clearButton = new Button();
            signInButton = new Button();
            txtAddress = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources._3827cb626a2b21ecb27d1ad4c4e42726;
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(143, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(505, 468);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Javanese Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 384);
            label3.Name = "label3";
            label3.Size = new Size(259, 91);
            label3.TabIndex = 5;
            label3.Text = "WELCOME";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtContactNo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(loginButton);
            groupBox2.Controls.Add(clearButton);
            groupBox2.Controls.Add(signInButton);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(640, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 469);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 304);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(361, 27);
            txtPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 281);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 9;
            label6.Text = "password";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(94, 179);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(361, 27);
            txtContactNo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 156);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 7;
            label5.Text = "contact no";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.IndianRed;
            loginButton.Location = new Point(450, 429);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 34);
            loginButton.TabIndex = 6;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Bisque;
            clearButton.Location = new Point(94, 370);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(124, 42);
            clearButton.TabIndex = 5;
            clearButton.Text = "clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.LightBlue;
            signInButton.Location = new Point(314, 370);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(141, 42);
            signInButton.TabIndex = 4;
            signInButton.Text = "sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 241);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(361, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(94, 116);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(361, 27);
            txtUserName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 218);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "user name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 0;
            label1.Text = "Sign IN";
            label1.Click += label1_Click;
            // 
            // signInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 575);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "signInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signInForm";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox2;
        private Button loginButton;
        private Button clearButton;
        private Button signInButton;
        private TextBox txtAddress;
        private TextBox txtUserName;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtContactNo;
        private Label label5;
    }
}