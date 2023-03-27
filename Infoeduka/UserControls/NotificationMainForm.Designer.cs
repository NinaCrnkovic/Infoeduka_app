﻿namespace Infoeduka.UserControls
{
    partial class NotificationMainForm
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
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ccbCourses = new Infoeduka.CustomDesign.CustomComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnMainNotifications = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCourse
            // 
            this.gbCourse.Controls.Add(this.panel2);
            this.gbCourse.Controls.Add(this.panel5);
            this.gbCourse.Controls.Add(this.panel4);
            this.gbCourse.Controls.Add(this.textBox1);
            this.gbCourse.Controls.Add(this.label4);
            this.gbCourse.Controls.Add(this.ccbCourses);
            this.gbCourse.Controls.Add(this.dtDate);
            this.gbCourse.Controls.Add(this.btnMainNotifications);
            this.gbCourse.Controls.Add(this.label2);
            this.gbCourse.Controls.Add(this.label1);
            this.gbCourse.Controls.Add(this.panel1);
            this.gbCourse.Controls.Add(this.tbEmail);
            this.gbCourse.Controls.Add(this.label3);
            this.gbCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbCourse.Location = new System.Drawing.Point(86, 14);
            this.gbCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCourse.Size = new System.Drawing.Size(811, 488);
            this.gbCourse.TabIndex = 4;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Obavijest";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(325, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(325, 246);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 1);
            this.panel5.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(325, 210);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 1);
            this.panel4.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(324, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 130);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(180, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Opis";
            // 
            // ccbCourses
            // 
            this.ccbCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.ccbCourses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.ccbCourses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbCourses.ForeColor = System.Drawing.Color.White;
            this.ccbCourses.FormattingEnabled = true;
            this.ccbCourses.Items.AddRange(new object[] {
            "Objektro orjentirano programiranje",
            "Programiranje u Javi",
            "Matematika"});
            this.ccbCourses.Location = new System.Drawing.Point(325, 215);
            this.ccbCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccbCourses.Name = "ccbCourses";
            this.ccbCourses.Size = new System.Drawing.Size(306, 30);
            this.ccbCourses.TabIndex = 22;
            // 
            // dtDate
            // 
            this.dtDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.dtDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtDate.Location = new System.Drawing.Point(324, 262);
            this.dtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(307, 29);
            this.dtDate.TabIndex = 21;
            // 
            // btnMainNotifications
            // 
            this.btnMainNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(32)))));
            this.btnMainNotifications.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMainNotifications.FlatAppearance.BorderSize = 0;
            this.btnMainNotifications.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.btnMainNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainNotifications.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMainNotifications.Location = new System.Drawing.Point(234, 431);
            this.btnMainNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainNotifications.Name = "btnMainNotifications";
            this.btnMainNotifications.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnMainNotifications.Size = new System.Drawing.Size(342, 34);
            this.btnMainNotifications.TabIndex = 19;
            this.btnMainNotifications.Text = "Spremi";
            this.btnMainNotifications.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(193, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv kolegija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(193, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum isteka";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(324, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 1);
            this.panel1.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.Location = new System.Drawing.Point(324, 25);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(262, 22);
            this.tbEmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(180, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv obavijesti";
            // 
            // NotificationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.gbCourse);
            this.Name = "NotificationMainForm";
            this.Size = new System.Drawing.Size(982, 517);
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbCourse;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private TextBox textBox1;
        private Label label4;
        private CustomDesign.CustomComboBox ccbCourses;
        private DateTimePicker dtDate;
        private Button btnMainNotifications;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox tbEmail;
        private Label label3;
    }
}