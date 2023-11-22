namespace Login
{
    partial class Loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            pictureBox1 = new PictureBox();
            buttonLogin = new Button();
            student_user = new TextBox();
            student_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            teacher_user = new TextBox();
            teacher_password = new TextBox();
            admin_user = new TextBox();
            admin_password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            login2 = new Button();
            login3 = new Button();
            passwordbox = new TextBox();
            userbox = new TextBox();
            textlogin = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(675, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(291, 281);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "LOGIN ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // student_user
            // 
            student_user.Location = new Point(207, 234);
            student_user.Multiline = true;
            student_user.Name = "student_user";
            student_user.RightToLeft = RightToLeft.No;
            student_user.Size = new Size(246, 20);
            student_user.TabIndex = 4;
            student_user.TextChanged += student_TextChanged;
            // 
            // student_password
            // 
            student_password.Location = new Point(207, 260);
            student_password.Name = "student_password";
            student_password.Size = new Size(246, 23);
            student_password.TabIndex = 5;
            student_password.TextChanged += passwordtext_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 246);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "User";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 277);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // teacher_user
            // 
            teacher_user.Location = new Point(207, 339);
            teacher_user.Multiline = true;
            teacher_user.Name = "teacher_user";
            teacher_user.RightToLeft = RightToLeft.No;
            teacher_user.Size = new Size(246, 20);
            teacher_user.TabIndex = 9;
            teacher_user.TextChanged += teacher_TextChanged;
            // 
            // teacher_password
            // 
            teacher_password.Location = new Point(207, 365);
            teacher_password.Multiline = true;
            teacher_password.Name = "teacher_password";
            teacher_password.RightToLeft = RightToLeft.No;
            teacher_password.Size = new Size(246, 20);
            teacher_password.TabIndex = 10;
            teacher_password.TextChanged += teacherp_TextChanged;
            // 
            // admin_user
            // 
            admin_user.Location = new Point(207, 435);
            admin_user.Multiline = true;
            admin_user.Name = "admin_user";
            admin_user.RightToLeft = RightToLeft.No;
            admin_user.Size = new Size(246, 20);
            admin_user.TabIndex = 11;
            admin_user.TextChanged += admin_TextChanged;
            // 
            // admin_password
            // 
            admin_password.Location = new Point(207, 461);
            admin_password.Multiline = true;
            admin_password.Name = "admin_password";
            admin_password.RightToLeft = RightToLeft.No;
            admin_password.Size = new Size(246, 20);
            admin_password.TabIndex = 12;
            admin_password.TextChanged += adminp_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 370);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 339);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 440);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 15;
            label5.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 466);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 16;
            label6.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(612, 611);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // login2
            // 
            login2.Location = new Point(291, 383);
            login2.Name = "login2";
            login2.Size = new Size(75, 23);
            login2.TabIndex = 18;
            login2.Text = "LOGIN";
            login2.UseVisualStyleBackColor = true;
            login2.Click += login2_Click;
            // 
            // login3
            // 
            login3.Location = new Point(291, 487);
            login3.Name = "login3";
            login3.Size = new Size(75, 23);
            login3.TabIndex = 19;
            login3.Text = "LOGIN";
            login3.UseVisualStyleBackColor = true;
            login3.Click += login3_Click;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(329, 601);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(100, 23);
            passwordbox.TabIndex = 20;
            // 
            // userbox
            // 
            userbox.Location = new Point(329, 572);
            userbox.Name = "userbox";
            userbox.Size = new Size(100, 23);
            userbox.TabIndex = 21;
            // 
            // textlogin
            // 
            textlogin.Location = new Point(354, 648);
            textlogin.Name = "textlogin";
            textlogin.Size = new Size(75, 23);
            textlogin.TabIndex = 22;
            textlogin.Text = "button2";
            textlogin.UseVisualStyleBackColor = true;
            textlogin.Click += loginButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(315, 216);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 23;
            label7.Text = "user";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(315, 321);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 24;
            label8.Text = "teacher";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(315, 417);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 25;
            label9.Text = "admin";
            // 
            // Loginpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(688, 716);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textlogin);
            Controls.Add(userbox);
            Controls.Add(passwordbox);
            Controls.Add(login3);
            Controls.Add(login2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(admin_password);
            Controls.Add(admin_user);
            Controls.Add(teacher_password);
            Controls.Add(teacher_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(student_password);
            Controls.Add(student_user);
            Controls.Add(buttonLogin);
            Controls.Add(pictureBox1);
            Name = "Loginpage";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonLogin;
        private TextBox usertext;
        private TextBox passwordtext;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox student_user;
        private TextBox student_password;
        private TextBox teacher_user;
        private TextBox teacher_password;
        private TextBox admin_user;
        private TextBox admin_password;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button login2;
        private Button login3;
        private TextBox passwordbox;
        private TextBox userbox;
        private Button textlogin;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
