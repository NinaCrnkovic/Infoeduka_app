namespace Infoeduka.UserControls
{
    partial class CoursesMainForm
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
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpLecturersOnCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.flpAllLecturers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbEcts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCourse.SuspendLayout();
            this.gbCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCourse
            // 
            this.pnlCourse.Controls.Add(this.gbCourse);
            this.pnlCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(1122, 689);
            this.pnlCourse.TabIndex = 0;
            // 
            // gbCourse
            // 
            this.gbCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCourse.Controls.Add(this.label5);
            this.gbCourse.Controls.Add(this.label4);
            this.gbCourse.Controls.Add(this.flpLecturersOnCourse);
            this.gbCourse.Controls.Add(this.flpAllLecturers);
            this.gbCourse.Controls.Add(this.btnSaveCourse);
            this.gbCourse.Controls.Add(this.panel3);
            this.gbCourse.Controls.Add(this.tbEcts);
            this.gbCourse.Controls.Add(this.label2);
            this.gbCourse.Controls.Add(this.panel2);
            this.gbCourse.Controls.Add(this.tbCode);
            this.gbCourse.Controls.Add(this.label1);
            this.gbCourse.Controls.Add(this.panel4);
            this.gbCourse.Controls.Add(this.tbCourseName);
            this.gbCourse.Controls.Add(this.label3);
            this.gbCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCourse.Location = new System.Drawing.Point(98, 19);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(927, 651);
            this.gbCourse.TabIndex = 4;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Kolegij";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(578, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Predavači na kolegiju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(196, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Svi predavači";
            // 
            // flpLecturersOnCourse
            // 
            this.flpLecturersOnCourse.AllowDrop = true;
            this.flpLecturersOnCourse.AutoScroll = true;
            this.flpLecturersOnCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLecturersOnCourse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLecturersOnCourse.Location = new System.Drawing.Point(514, 186);
            this.flpLecturersOnCourse.Name = "flpLecturersOnCourse";
            this.flpLecturersOnCourse.Size = new System.Drawing.Size(308, 364);
            this.flpLecturersOnCourse.TabIndex = 21;
            this.flpLecturersOnCourse.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpLecturersOnCourse_DragDrop);
            this.flpLecturersOnCourse.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpLecturersOnCourse_DragEnter);
            // 
            // flpAllLecturers
            // 
            this.flpAllLecturers.AutoScroll = true;
            this.flpAllLecturers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllLecturers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAllLecturers.Location = new System.Drawing.Point(104, 186);
            this.flpAllLecturers.Name = "flpAllLecturers";
            this.flpAllLecturers.Size = new System.Drawing.Size(308, 364);
            this.flpAllLecturers.TabIndex = 20;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
            this.btnSaveCourse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveCourse.FlatAppearance.BorderSize = 0;
            this.btnSaveCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btnSaveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveCourse.Location = new System.Drawing.Point(267, 575);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveCourse.Size = new System.Drawing.Size(391, 45);
            this.btnSaveCourse.TabIndex = 19;
            this.btnSaveCourse.Text = "Spremi";
            this.btnSaveCourse.UseVisualStyleBackColor = false;
            this.btnSaveCourse.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(701, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 1);
            this.panel3.TabIndex = 11;
            // 
            // tbEcts
            // 
            this.tbEcts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbEcts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEcts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEcts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbEcts.Location = new System.Drawing.Point(701, 90);
            this.tbEcts.Name = "tbEcts";
            this.tbEcts.Size = new System.Drawing.Size(121, 27);
            this.tbEcts.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(514, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Broj ECTS bodova";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(246, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 1);
            this.panel2.TabIndex = 8;
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCode.Location = new System.Drawing.Point(246, 84);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(166, 27);
            this.tbCode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(104, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Šifra kolegija";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(267, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 1);
            this.panel4.TabIndex = 5;
            // 
            // tbCourseName
            // 
            this.tbCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCourseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCourseName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCourseName.Location = new System.Drawing.Point(267, 24);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(555, 27);
            this.tbCourseName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(104, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv kolegija";
            // 
            // CoursesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.pnlCourse);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CoursesMainForm";
            this.Size = new System.Drawing.Size(1122, 689);
            this.Load += new System.EventHandler(this.CoursesMainForm_Load);
            this.pnlCourse.ResumeLayout(false);
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCourse;
        private GroupBox gbCourse;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flpLecturersOnCourse;
        private FlowLayoutPanel flpAllLecturers;
        private Button btnSaveCourse;
        private Panel panel3;
        private TextBox tbEcts;
        private Label label2;
        private Panel panel2;
        private TextBox tbCode;
        private Label label1;
        private Panel panel4;
        private TextBox tbCourseName;
        private Label label3;
    }
}
