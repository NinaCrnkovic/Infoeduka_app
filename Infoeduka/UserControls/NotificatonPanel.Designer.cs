namespace Infoeduka.UserControls
{
    partial class NotificatonPanel
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
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pnlNotificationHeader = new System.Windows.Forms.Panel();
            this.pnlNotificationFooter = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.tbDescripton = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            this.pnlNotificationHeader.SuspendLayout();
            this.pnlNotificationFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Black;
            this.pnlBack.Controls.Add(this.tbDescripton);
            this.pnlBack.Controls.Add(this.pnlNotificationFooter);
            this.pnlBack.Controls.Add(this.pnlNotificationHeader);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(460, 240);
            this.pnlBack.TabIndex = 0;
            // 
            // pnlNotificationHeader
            // 
            this.pnlNotificationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.pnlNotificationHeader.Controls.Add(this.lblLecturer);
            this.pnlNotificationHeader.Controls.Add(this.lblTitle);
            this.pnlNotificationHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotificationHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlNotificationHeader.Name = "pnlNotificationHeader";
            this.pnlNotificationHeader.Size = new System.Drawing.Size(460, 34);
            this.pnlNotificationHeader.TabIndex = 0;
            // 
            // pnlNotificationFooter
            // 
            this.pnlNotificationFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.pnlNotificationFooter.Controls.Add(this.lblChange);
            this.pnlNotificationFooter.Controls.Add(this.lblCreated);
            this.pnlNotificationFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNotificationFooter.Location = new System.Drawing.Point(0, 206);
            this.pnlNotificationFooter.Name = "pnlNotificationFooter";
            this.pnlNotificationFooter.Size = new System.Drawing.Size(460, 34);
            this.pnlNotificationFooter.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Naziv";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLecturer
            // 
            this.lblLecturer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLecturer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLecturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLecturer.Location = new System.Drawing.Point(286, 0);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(174, 34);
            this.lblLecturer.TabIndex = 1;
            this.lblLecturer.Text = "Ime prezime";
            this.lblLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreated
            // 
            this.lblCreated.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCreated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreated.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreated.Location = new System.Drawing.Point(0, 0);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(128, 34);
            this.lblCreated.TabIndex = 1;
            this.lblCreated.Text = "Kreirano: 21.01.2023. 17:20";
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescripton
            // 
            this.tbDescripton.BackColor = System.Drawing.Color.Black;
            this.tbDescripton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescripton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescripton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescripton.Location = new System.Drawing.Point(0, 34);
            this.tbDescripton.Multiline = true;
            this.tbDescripton.Name = "tbDescripton";
            this.tbDescripton.Size = new System.Drawing.Size(460, 172);
            this.tbDescripton.TabIndex = 2;
            // 
            // lblChange
            // 
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChange.Location = new System.Drawing.Point(327, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(133, 34);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Promijenjeno: 21.01.2023. 17:20";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificatonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "NotificatonPanel";
            this.Size = new System.Drawing.Size(460, 240);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.pnlNotificationHeader.ResumeLayout(false);
            this.pnlNotificationFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBack;
        private Panel pnlNotificationHeader;
        private Panel pnlNotificationFooter;
        private TextBox tbDescripton;
        private Label lblChange;
        private Label lblCreated;
        private Label lblLecturer;
        private Label lblTitle;
    }
}
