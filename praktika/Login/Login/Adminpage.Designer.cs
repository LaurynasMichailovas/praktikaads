namespace Login
{
    partial class Adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminpage));
            student_lastname = new TextBox();
            student_name = new TextBox();
            student_username = new TextBox();
            student_password = new TextBox();
            username = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            teacher_username = new TextBox();
            teacher_password = new TextBox();
            teacher_name = new TextBox();
            teacher_lastname = new TextBox();
            subject = new TextBox();
            addstudent = new Button();
            add_teacher = new Button();
            student_group = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            addsubject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // student_lastname
            // 
            student_lastname.Location = new Point(818, 196);
            student_lastname.Name = "student_lastname";
            student_lastname.Size = new Size(161, 23);
            student_lastname.TabIndex = 0;
            // 
            // student_name
            // 
            student_name.Location = new Point(658, 196);
            student_name.Name = "student_name";
            student_name.Size = new Size(154, 23);
            student_name.TabIndex = 2;
            // 
            // student_username
            // 
            student_username.Location = new Point(268, 196);
            student_username.Name = "student_username";
            student_username.Size = new Size(189, 23);
            student_username.TabIndex = 4;
            student_username.TextChanged += student_username_TextChanged;
            // 
            // student_password
            // 
            student_password.Location = new Point(463, 196);
            student_password.Name = "student_password";
            student_password.Size = new Size(189, 23);
            student_password.TabIndex = 5;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(331, 168);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 6;
            username.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 168);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(712, 168);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(863, 168);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(699, 86);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1008, 168);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "Group";
            // 
            // teacher_username
            // 
            teacher_username.Location = new Point(268, 236);
            teacher_username.Name = "teacher_username";
            teacher_username.Size = new Size(189, 23);
            teacher_username.TabIndex = 12;
            // 
            // teacher_password
            // 
            teacher_password.Location = new Point(463, 236);
            teacher_password.Name = "teacher_password";
            teacher_password.Size = new Size(189, 23);
            teacher_password.TabIndex = 13;
            // 
            // teacher_name
            // 
            teacher_name.Location = new Point(658, 236);
            teacher_name.Name = "teacher_name";
            teacher_name.Size = new Size(154, 23);
            teacher_name.TabIndex = 14;
            // 
            // teacher_lastname
            // 
            teacher_lastname.Location = new Point(818, 236);
            teacher_lastname.Name = "teacher_lastname";
            teacher_lastname.Size = new Size(161, 23);
            teacher_lastname.TabIndex = 15;
            // 
            // subject
            // 
            subject.Location = new Point(634, 113);
            subject.Name = "subject";
            subject.Size = new Size(189, 23);
            subject.TabIndex = 16;
            subject.TextChanged += textBox10_TextChanged;
            // 
            // addstudent
            // 
            addstudent.BackgroundImageLayout = ImageLayout.None;
            addstudent.Location = new Point(168, 196);
            addstudent.Name = "addstudent";
            addstudent.Size = new Size(75, 23);
            addstudent.TabIndex = 17;
            addstudent.Text = "add ";
            addstudent.UseVisualStyleBackColor = true;
            addstudent.Click += addstudent_Click;
            // 
            // add_teacher
            // 
            add_teacher.Location = new Point(168, 235);
            add_teacher.Name = "add_teacher";
            add_teacher.Size = new Size(75, 23);
            add_teacher.TabIndex = 18;
            add_teacher.Text = "add";
            add_teacher.UseVisualStyleBackColor = true;
            add_teacher.Click += add_teacher_Click;
            // 
            // student_group
            // 
            student_group.Location = new Point(985, 196);
            student_group.Name = "student_group";
            student_group.Size = new Size(100, 23);
            student_group.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(614, 312);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(684, 312);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(523, 312);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 22;
            label6.Text = "admin view";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 294);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 23;
            label7.Text = "students";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(928, 294);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 24;
            label8.Text = "teachers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(187, 27);
            button1.Name = "button1";
            button1.Size = new Size(111, 47);
            button1.TabIndex = 26;
            button1.Text = "Logoff";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addsubject
            // 
            addsubject.Location = new Point(543, 113);
            addsubject.Name = "addsubject";
            addsubject.Size = new Size(75, 23);
            addsubject.TabIndex = 27;
            addsubject.Text = "add";
            addsubject.UseVisualStyleBackColor = true;
            addsubject.Click += addsubject_Click;
            // 
            // Adminpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 636);
            Controls.Add(addsubject);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(student_group);
            Controls.Add(add_teacher);
            Controls.Add(addstudent);
            Controls.Add(subject);
            Controls.Add(teacher_lastname);
            Controls.Add(teacher_name);
            Controls.Add(teacher_password);
            Controls.Add(teacher_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(student_password);
            Controls.Add(student_username);
            Controls.Add(student_name);
            Controls.Add(student_lastname);
            Name = "Adminpage";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox student_lastname;
        private TextBox student_name;
        private TextBox student_username;
        private TextBox student_password;
        private Label username;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox teacher_username;
        private TextBox teacher_password;
        private TextBox teacher_name;
        private TextBox teacher_lastname;
        private TextBox subject;
        private Button addstudent;
        private Button add_teacher;
        private TextBox student_group;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button1;
        private Button addsubject;
    }
}