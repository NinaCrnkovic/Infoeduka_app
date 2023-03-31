namespace Infoeduka.UserControls
{
    partial class NotificationEditOrDeletePanel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.btnForEditOrDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 34);
            this.lblTitle.TabIndex = 3;
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
            this.lblLecturer.TabIndex = 4;
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
            this.tbDescription.Size = new System.Drawing.Size(460, 161);
            this.tbDescription.TabIndex = 5;
            this.tbDescription.Tag = "tbDescription";
            this.tbDescription.Text = "tbDescription";
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChange.Location = new System.Drawing.Point(327, 201);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(133, 39);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Promijenjeno: 21.01.2023. 17:20";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreated
            // 
            this.lblCreated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreated.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreated.Location = new System.Drawing.Point(0, 201);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(127, 39);
            this.lblCreated.TabIndex = 7;
            this.lblCreated.Text = "Kreirano: 21.01.2023. 17:20";
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnForEditOrDelete
            // 
            this.btnForEditOrDelete.BackColor = System.Drawing.Color.Black;
            this.btnForEditOrDelete.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForEditOrDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnForEditOrDelete.Location = new System.Drawing.Point(133, 201);
            this.btnForEditOrDelete.Name = "btnForEditOrDelete";
            this.btnForEditOrDelete.Size = new System.Drawing.Size(188, 32);
            this.btnForEditOrDelete.TabIndex = 9;
            this.btnForEditOrDelete.Text = "button1";
            this.btnForEditOrDelete.UseVisualStyleBackColor = false;
            // 
            // NotificationEditOrDeletePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.btnForEditOrDelete);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.lblTitle);
            this.Name = "NotificationEditOrDeletePanel";
            this.Size = new System.Drawing.Size(460, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblLecturer;
        private TextBox tbDescription;
        private Label lblChange;
        private Label lblCreated;
        private Button btnForEditOrDelete;
    }
}
