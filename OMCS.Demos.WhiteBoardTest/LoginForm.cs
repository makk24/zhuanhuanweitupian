using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMCS.Demos.WhiteBoardTest
{
    public partial class LoginForm : Form
    {      
        public LoginForm( )
        {
            InitializeComponent();

            Random ran = new Random();
            this.textBox_id.Text = "tester" + ran.Next(100).ToString("00");
        }

        private string currentUserID;
        public string CurrentUserID
        {
            get { return currentUserID; }            
        }

        public string ClassRoomID
        {
            get
            {
                return this.textBox_classRoomID.Text;
            }
        }

        public bool IsTeacher
        {
            get
            {
                return this.radioButton_teacher.Checked;
            }
        }
               
        private void button_login_Click(object sender, EventArgs e)
        {
            string userID = this.textBox_id.Text.Trim();
            if (userID.Length > 10)
            {
                MessageBox.Show("ID长度必须小于10.");
                return;
            }

            this.currentUserID = userID;
            this.DialogResult = DialogResult.OK;           
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }       
    }
}
