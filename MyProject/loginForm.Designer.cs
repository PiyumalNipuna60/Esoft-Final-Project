namespace MyProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            loginButton = new Button();
            password = new TextBox();
            userName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            signInButton = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(0, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1350, 622);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources._3827cb626a2b21ecb27d1ad4c4e42726;
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(141, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(505, 468);
            groupBox3.TabIndex = 1;
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
            groupBox2.Controls.Add(signInButton);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(loginButton);
            groupBox2.Controls.Add(password);
            groupBox2.Controls.Add(userName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(638, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 469);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(450, 429);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 6;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Location = new Point(94, 289);
            button1.Name = "button1";
            button1.Size = new Size(124, 42);
            button1.TabIndex = 5;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightBlue;
            loginButton.Location = new Point(314, 289);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(141, 42);
            loginButton.TabIndex = 4;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(94, 220);
            password.Name = "password";
            password.Size = new Size(361, 27);
            password.TabIndex = 3;
            // 
            // userName
            // 
            userName.Location = new Point(94, 153);
            userName.Name = "userName";
            userName.Size = new Size(361, 27);
            userName.TabIndex = 2;
            userName.TextChanged += userName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 197);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "password";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 130);
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
            label1.Size = new Size(72, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.Coral;
            signInButton.Location = new Point(350, 429);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(94, 34);
            signInButton.TabIndex = 7;
            signInButton.Text = "sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 617);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button loginButton;
        private TextBox password;
        private TextBox userName;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button signInButton;
    }
}
