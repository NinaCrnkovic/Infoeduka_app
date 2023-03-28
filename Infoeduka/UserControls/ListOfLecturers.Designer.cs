namespace Infoeduka.UserControls
{
    partial class ListOfLecturers
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lvLecturers = new System.Windows.Forms.ListView();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.pnlList.Controls.Add(this.lblNaslov);
            this.pnlList.Controls.Add(this.lvLecturers);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1122, 689);
            this.pnlList.TabIndex = 2;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(495, 23);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(213, 28);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Pregled svih predavača";
            // 
            // lvLecturers
            // 
            this.lvLecturers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.lvLecturers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvLecturers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lvLecturers.Location = new System.Drawing.Point(71, 94);
            this.lvLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvLecturers.Name = "lvLecturers";
            this.lvLecturers.Size = new System.Drawing.Size(980, 550);
            this.lvLecturers.TabIndex = 0;
            this.lvLecturers.UseCompatibleStateImageBehavior = false;
            this.lvLecturers.View = System.Windows.Forms.View.Details;
            // 
            // ListOfLecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListOfLecturers";
            this.Size = new System.Drawing.Size(1122, 689);
            this.Load += new System.EventHandler(this.ListOfLecturers_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlList;
        private ListView lvLecturers;
        private Label lblNaslov;
    }
}
