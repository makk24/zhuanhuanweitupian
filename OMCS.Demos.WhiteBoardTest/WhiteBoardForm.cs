using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OMCS.Passive;
using ESBasic;

namespace OMCS.Demos.WhiteBoardTest
{
    public partial class WhiteBoardForm : Form
    {       
        private string classRoomID;

        public WhiteBoardForm(string classRid, bool isTeacher )
        {
            InitializeComponent();            
           
            this.classRoomID = classRid;
            this.whiteBoardConnector1.IsManager = isTeacher;
            this.whiteBoardConnector1.WatchingOnly = !isTeacher;

            this.Text = string.Format("正在访问{0}的电子白板" ,this.classRoomID);
            this.whiteBoardConnector1.ConnectEnded += new CbGeneric<ConnectResult>(whiteBoardConnector1_ConnectEnded);           
            this.whiteBoardConnector1.BeginConnect(this.classRoomID);            
        }

      

        void whiteBoardConnector1_ConnectEnded(ConnectResult result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<ConnectResult>(this.whiteBoardConnector1_ConnectEnded), result);
            }
            else
            {
                if (result != ConnectResult.Succeed)
                {
                    MessageBox.Show("连接失败!" + result.ToString());
                    return;
                }               
            }
        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.whiteBoardConnector1.Disconnect();
        }
    }
}
