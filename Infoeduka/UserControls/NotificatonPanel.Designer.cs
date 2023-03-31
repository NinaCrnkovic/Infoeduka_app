﻿namespace Infoeduka.UserControls
{
    partial class NotificationPanel
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
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCreated
            // 
            this.lblCreated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreated.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreated.Location = new System.Drawing.Point(0, 206);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(128, 34);
            this.lblCreated.TabIndex = 1;
            this.lblCreated.Text = "Kreirano: 21.01.2023. 17:20";
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChange.Location = new System.Drawing.Point(327, 206);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(133, 34);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Promijenjeno: 21.01.2023. 17:20";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Tag = "lblTitle";
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLecturer
            // 
            this.lblLecturer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLecturer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLecturer.Location = new System.Drawing.Point(286, 0);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(174, 34);
            this.lblLecturer.TabIndex = 1;
            this.lblLecturer.Text = "Ime prezime";
            this.lblLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.Black;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescription.Location = new System.Drawing.Point(0, 37);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(460, 166);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.Tag = "tbDescription";
            this.tbDescription.Text = "tbDescription";
            // 
            // NotificationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.lblTitle);
            this.Name = "NotificationPanel";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(460, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblChange;
        private Label lblCreated;
        private Label lblTitle;
        private Label lblLecturer;
        private TextBox tbDescription;
    }
}
