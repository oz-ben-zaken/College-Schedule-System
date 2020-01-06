using System.Threading;
using System.Windows.Forms;

namespace Project_Team_20
{
    partial class TeachingAssist_Form
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(
                TeachingAssist_Form_FormClosing);

            this.CourseToTeach_button = new System.Windows.Forms.Button();
            this.DaysToTeach_button = new System.Windows.Forms.Button();
            this.HoursToTeach_button = new System.Windows.Forms.Button();
            this.TimeBetweenClassses_button = new System.Windows.Forms.Button();
            this.NumOfDays_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChooceOfficeHours_button = new System.Windows.Forms.Button();
            this.ChangeOfficeHours_button = new System.Windows.Forms.Button();
            this.PrintSchedule_button = new System.Windows.Forms.Button();
            this.searchLecturer_button = new System.Windows.Forms.Button();
            this.SearchTeachingAssist_button = new System.Windows.Forms.Button();
            this.SemestersToTeach_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PrintDetails_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseToTeach_button
            // 
            this.CourseToTeach_button.Location = new System.Drawing.Point(17, 189);
            this.CourseToTeach_button.Name = "CourseToTeach_button";
            this.CourseToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.CourseToTeach_button.TabIndex = 0;
            this.CourseToTeach_button.Text = "Choose Courses to Teach";
            this.CourseToTeach_button.UseVisualStyleBackColor = true;
            this.CourseToTeach_button.Click += new System.EventHandler(this.CourseToTeach_button_Click);
            // 
            // DaysToTeach_button
            // 
            this.DaysToTeach_button.Location = new System.Drawing.Point(17, 218);
            this.DaysToTeach_button.Name = "DaysToTeach_button";
            this.DaysToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.DaysToTeach_button.TabIndex = 1;
            this.DaysToTeach_button.Text = "Choose Days to Teach";
            this.DaysToTeach_button.UseVisualStyleBackColor = true;
            this.DaysToTeach_button.Click += new System.EventHandler(this.DaysToTeach_button_Click);
            // 
            // HoursToTeach_button
            // 
            this.HoursToTeach_button.Location = new System.Drawing.Point(17, 247);
            this.HoursToTeach_button.Name = "HoursToTeach_button";
            this.HoursToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.HoursToTeach_button.TabIndex = 2;
            this.HoursToTeach_button.Text = "Choose Hours to Teach";
            this.HoursToTeach_button.UseVisualStyleBackColor = true;
            this.HoursToTeach_button.Click += new System.EventHandler(this.HoursToTeach_button_Click);
            // 
            // TimeBetweenClassses_button
            // 
            this.TimeBetweenClassses_button.Location = new System.Drawing.Point(17, 276);
            this.TimeBetweenClassses_button.Name = "TimeBetweenClassses_button";
            this.TimeBetweenClassses_button.Size = new System.Drawing.Size(150, 23);
            this.TimeBetweenClassses_button.TabIndex = 3;
            this.TimeBetweenClassses_button.Text = "Time Between Classes";
            this.TimeBetweenClassses_button.UseVisualStyleBackColor = true;
            this.TimeBetweenClassses_button.Click += new System.EventHandler(this.TimeBetweenClassses_button_Click);
            // 
            // NumOfDays_button
            // 
            this.NumOfDays_button.Location = new System.Drawing.Point(17, 305);
            this.NumOfDays_button.Name = "NumOfDays_button";
            this.NumOfDays_button.Size = new System.Drawing.Size(150, 23);
            this.NumOfDays_button.TabIndex = 4;
            this.NumOfDays_button.Text = "Number Of Days to Teach";
            this.NumOfDays_button.UseVisualStyleBackColor = true;
            this.NumOfDays_button.Click += new System.EventHandler(this.NumOfDays_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teaching Assistance Preferences:";
            // 
            // ChooceOfficeHours_button
            // 
            this.ChooceOfficeHours_button.Location = new System.Drawing.Point(17, 363);
            this.ChooceOfficeHours_button.Name = "ChooceOfficeHours_button";
            this.ChooceOfficeHours_button.Size = new System.Drawing.Size(150, 23);
            this.ChooceOfficeHours_button.TabIndex = 7;
            this.ChooceOfficeHours_button.Text = "Choose Office Hours";
            this.ChooceOfficeHours_button.UseVisualStyleBackColor = true;
            this.ChooceOfficeHours_button.Click += new System.EventHandler(this.ChooceOfficeHours_button_Click);
            // 
            // ChangeOfficeHours_button
            // 
            this.ChangeOfficeHours_button.Location = new System.Drawing.Point(208, 189);
            this.ChangeOfficeHours_button.Name = "ChangeOfficeHours_button";
            this.ChangeOfficeHours_button.Size = new System.Drawing.Size(150, 23);
            this.ChangeOfficeHours_button.TabIndex = 8;
            this.ChangeOfficeHours_button.Text = "Change Office Hours";
            this.ChangeOfficeHours_button.UseVisualStyleBackColor = true;
            this.ChangeOfficeHours_button.Click += new System.EventHandler(this.ChangeOfficeHours_button_Click);
            // 
            // PrintSchedule_button
            // 
            this.PrintSchedule_button.Location = new System.Drawing.Point(208, 218);
            this.PrintSchedule_button.Name = "PrintSchedule_button";
            this.PrintSchedule_button.Size = new System.Drawing.Size(150, 23);
            this.PrintSchedule_button.TabIndex = 9;
            this.PrintSchedule_button.Text = "Print Schedule";
            this.PrintSchedule_button.UseVisualStyleBackColor = true;
            this.PrintSchedule_button.Click += new System.EventHandler(this.PrintSchedule_button_Click);
            // 
            // searchLecturer_button
            // 
            this.searchLecturer_button.Location = new System.Drawing.Point(208, 247);
            this.searchLecturer_button.Name = "searchLecturer_button";
            this.searchLecturer_button.Size = new System.Drawing.Size(150, 23);
            this.searchLecturer_button.TabIndex = 10;
            this.searchLecturer_button.Text = "Search Lecturer";
            this.searchLecturer_button.UseVisualStyleBackColor = true;
            this.searchLecturer_button.Click += new System.EventHandler(this.searchLecturer_button_Click);
            // 
            // SearchTeachingAssist_button
            // 
            this.SearchTeachingAssist_button.Location = new System.Drawing.Point(208, 276);
            this.SearchTeachingAssist_button.Name = "SearchTeachingAssist_button";
            this.SearchTeachingAssist_button.Size = new System.Drawing.Size(150, 23);
            this.SearchTeachingAssist_button.TabIndex = 11;
            this.SearchTeachingAssist_button.Text = "Search Teaching Assist";
            this.SearchTeachingAssist_button.UseVisualStyleBackColor = true;
            this.SearchTeachingAssist_button.Click += new System.EventHandler(this.SearchTeachingAssist_button_Click);
            // 
            // SemestersToTeach_button
            // 
            this.SemestersToTeach_button.Location = new System.Drawing.Point(17, 334);
            this.SemestersToTeach_button.Name = "SemestersToTeach_button";
            this.SemestersToTeach_button.Size = new System.Drawing.Size(150, 23);
            this.SemestersToTeach_button.TabIndex = 12;
            this.SemestersToTeach_button.Text = "Semesters to Teach";
            this.SemestersToTeach_button.UseVisualStyleBackColor = true;
            this.SemestersToTeach_button.Click += new System.EventHandler(this.SemestersToTeach_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Print Constraints";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrintDetails_button1
            // 
            this.PrintDetails_button1.Location = new System.Drawing.Point(208, 305);
            this.PrintDetails_button1.Name = "PrintDetails_button1";
            this.PrintDetails_button1.Size = new System.Drawing.Size(150, 23);
            this.PrintDetails_button1.TabIndex = 16;
            this.PrintDetails_button1.Text = "PrintDetails";
            this.PrintDetails_button1.UseVisualStyleBackColor = true;
            this.PrintDetails_button1.Click += new System.EventHandler(this.PrintDetails_button1_Click);
            // 
            // TeachingAssist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(420, 448);
            this.Controls.Add(this.PrintDetails_button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SemestersToTeach_button);
            this.Controls.Add(this.SearchTeachingAssist_button);
            this.Controls.Add(this.searchLecturer_button);
            this.Controls.Add(this.PrintSchedule_button);
            this.Controls.Add(this.ChangeOfficeHours_button);
            this.Controls.Add(this.ChooceOfficeHours_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfDays_button);
            this.Controls.Add(this.TimeBetweenClassses_button);
            this.Controls.Add(this.HoursToTeach_button);
            this.Controls.Add(this.DaysToTeach_button);
            this.Controls.Add(this.CourseToTeach_button);
            this.Name = "TeachingAssist_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachingAssist_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachingAssist_Form_Closing);
            this.Load += new System.EventHandler(this.TeachingAssist_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button CourseToTeach_button;
        protected System.Windows.Forms.Button DaysToTeach_button;
        protected System.Windows.Forms.Button HoursToTeach_button;
        protected System.Windows.Forms.Button TimeBetweenClassses_button;
        protected System.Windows.Forms.Button NumOfDays_button;
        protected System.Windows.Forms.Button ChooceOfficeHours_button;
        protected System.Windows.Forms.Button ChangeOfficeHours_button;
        protected System.Windows.Forms.Button PrintSchedule_button;
        protected System.Windows.Forms.Button searchLecturer_button;
        protected System.Windows.Forms.Button SearchTeachingAssist_button;
        protected System.Windows.Forms.Button SemestersToTeach_button;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button PrintDetails_button1;
    }
}