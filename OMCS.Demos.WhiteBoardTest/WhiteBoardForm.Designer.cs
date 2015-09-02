namespace OMCS.Demos.WhiteBoardTest
{
    partial class WhiteBoardForm
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
            this.whiteBoardConnector1 = new OMCS.Passive.WhiteBoard.WhiteBoardConnector();
            this.SuspendLayout();
            // 
            // whiteBoardConnector1
            // 
            this.whiteBoardConnector1.AutoReconnect = true;
            this.whiteBoardConnector1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.whiteBoardConnector1.BackImageOfPage = null;
            this.whiteBoardConnector1.ContextMenuEnglish = false;
            this.whiteBoardConnector1.Cursor = System.Windows.Forms.Cursors.No;
            this.whiteBoardConnector1.DisplayPageBorder = true;
            this.whiteBoardConnector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteBoardConnector1.FocusOnNewViewByOther = true;
            this.whiteBoardConnector1.IsManager = true;
            this.whiteBoardConnector1.Location = new System.Drawing.Point(0, 0);
            this.whiteBoardConnector1.Margin = new System.Windows.Forms.Padding(4);
            this.whiteBoardConnector1.MinimumSize = new System.Drawing.Size(530, 200);
            this.whiteBoardConnector1.Name = "whiteBoardConnector1";
            this.whiteBoardConnector1.PageSize = new System.Drawing.Size(800, 600);
            this.whiteBoardConnector1.Size = new System.Drawing.Size(814, 639);
            this.whiteBoardConnector1.TabIndex = 0;
            this.whiteBoardConnector1.Timeout4LoadContent = 120;
            this.whiteBoardConnector1.WaitOwnerOnlineSpanInSecs = 0;
            this.whiteBoardConnector1.WatchingOnly = false;
            // 
            // WhiteBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 639);
            this.Controls.Add(this.whiteBoardConnector1);
            this.Name = "WhiteBoardForm";
            this.Text = "电子白板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Passive.WhiteBoard.WhiteBoardConnector whiteBoardConnector1;




    }
}