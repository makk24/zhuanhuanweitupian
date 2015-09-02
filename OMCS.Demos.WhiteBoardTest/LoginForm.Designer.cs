namespace OMCS.Demos.WhiteBoardTest
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_classRoomID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_teacher = new System.Windows.Forms.RadioButton();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(216, 105);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(57, 23);
            this.button_login.TabIndex = 12;
            this.button_login.Text = "登  录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(93, 51);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.PasswordChar = '*';
            this.textBox_pwd.Size = new System.Drawing.Size(179, 21);
            this.textBox_pwd.TabIndex = 9;
            this.textBox_pwd.Text = "111111";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(93, 24);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(179, 21);
            this.textBox_id.TabIndex = 8;
            this.textBox_id.Text = "test01";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "登录密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户帐号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_classRoomID
            // 
            this.textBox_classRoomID.Location = new System.Drawing.Point(93, 78);
            this.textBox_classRoomID.Name = "textBox_classRoomID";
            this.textBox_classRoomID.Size = new System.Drawing.Size(179, 21);
            this.textBox_classRoomID.TabIndex = 9;
            this.textBox_classRoomID.Text = "C001";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "教室编号：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton_teacher
            // 
            this.radioButton_teacher.AutoSize = true;
            this.radioButton_teacher.Checked = true;
            this.radioButton_teacher.Location = new System.Drawing.Point(93, 109);
            this.radioButton_teacher.Name = "radioButton_teacher";
            this.radioButton_teacher.Size = new System.Drawing.Size(47, 16);
            this.radioButton_teacher.TabIndex = 13;
            this.radioButton_teacher.TabStop = true;
            this.radioButton_teacher.Text = "老师";
            this.radioButton_teacher.UseVisualStyleBackColor = true;
            // 
            // radioButton_student
            // 
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Location = new System.Drawing.Point(146, 109);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(47, 16);
            this.radioButton_student.TabIndex = 13;
            this.radioButton_student.Text = "学生";
            this.radioButton_student.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "转为图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 145);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_student);
            this.Controls.Add(this.radioButton_teacher);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_classRoomID);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_classRoomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_teacher;
        private System.Windows.Forms.RadioButton radioButton_student;
        private System.Windows.Forms.Button button1;
    }
}