namespace Infoeduka.UserControls
{
    partial class ListOfCourses
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
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.lvCourses = new System.Windows.Forms.ListView();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pnlCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCourses
            // 
            this.pnlCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.pnlCourses.Controls.Add(this.lvCourses);
            this.pnlCourses.Controls.Add(this.lblNaslov);
            this.pnlCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCourses.Location = new System.Drawing.Point(0, 0);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(1122, 689);
            this.pnlCourses.TabIndex = 0;
            // 
            // lvCourses
            // 
            this.lvCourses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.lvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvCourses.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvCourses.Location = new System.Drawing.Point(71, 92);
            this.lvCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvCourses.Name = "lvCourses";
            this.lvCourses.Size = new System.Drawing.Size(981, 505);
            this.lvCourses.TabIndex = 3;
            this.lvCourses.UseCompatibleStateImageBehavior = false;
            this.lvCourses.View = System.Windows.Forms.View.Details;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(465, 42);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(192, 28);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Pregled svih kolegija";
            // 
            // ListOfCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCourses);
            this.Name = "ListOfCourses";
            this.Size = new System.Drawing.Size(1122, 689);
            this.Load += new System.EventHandler(this.ListOfCourses_Load);
            this.pnlCourses.ResumeLayout(false);
            this.pnlCourses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCourses;
        private Label lblNaslov;
        private ListView lvCourses;
    }
}
