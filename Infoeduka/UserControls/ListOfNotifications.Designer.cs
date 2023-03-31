namespace Infoeduka.UserControls
{
    partial class ListOfNotifications
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpHolderForNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpHolderForNotifications
            // 
            this.flpHolderForNotifications.AutoScroll = true;
            this.flpHolderForNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.flpHolderForNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHolderForNotifications.Location = new System.Drawing.Point(0, 0);
            this.flpHolderForNotifications.Margin = new System.Windows.Forms.Padding(30);
            this.flpHolderForNotifications.MaximumSize = new System.Drawing.Size(981, 518);
            this.flpHolderForNotifications.Name = "flpHolderForNotifications";
            this.flpHolderForNotifications.Padding = new System.Windows.Forms.Padding(10, 20, 10, 200);
            this.flpHolderForNotifications.Size = new System.Drawing.Size(981, 518);
            this.flpHolderForNotifications.TabIndex = 0;
            // 
            // ListOfNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpHolderForNotifications);
            this.Name = "ListOfNotifications";
            this.Size = new System.Drawing.Size(981, 521);
            this.Load += new System.EventHandler(this.ListOfNotifications_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpHolderForNotifications;
    }
}
