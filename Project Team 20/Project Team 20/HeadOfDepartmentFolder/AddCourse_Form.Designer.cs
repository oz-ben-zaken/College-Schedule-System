namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class AddCourse_Form
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
            this.courseName_textBox = new System.Windows.Forms.TextBox();
            this.courseName_label = new System.Windows.Forms.Label();
            this.yearTaught_label = new System.Windows.Forms.Label();
            this.yearTaught_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.semesterTaught_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.semesterTaught_label = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.iTalk_Button_21 = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.SuspendLayout();
            // 
            // courseName_textBox
            // 
            this.courseName_textBox.Location = new System.Drawing.Point(161, 78);
            this.courseName_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseName_textBox.Name = "courseName_textBox";
            this.courseName_textBox.Size = new System.Drawing.Size(132, 22);
            this.courseName_textBox.TabIndex = 0;
            this.courseName_textBox.TextChanged += new System.EventHandler(this.courseName_textBox_TextChanged);
            // 
            // courseName_label
            // 
            this.courseName_label.AutoSize = true;
            this.courseName_label.Location = new System.Drawing.Point(59, 78);
            this.courseName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseName_label.Name = "courseName_label";
            this.courseName_label.Size = new System.Drawing.Size(94, 17);
            this.courseName_label.TabIndex = 1;
            this.courseName_label.Text = "Course Name";
            // 
            // yearTaught_label
            // 
            this.yearTaught_label.AutoSize = true;
            this.yearTaught_label.Location = new System.Drawing.Point(65, 119);
            this.yearTaught_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearTaught_label.Name = "yearTaught_label";
            this.yearTaught_label.Size = new System.Drawing.Size(87, 17);
            this.yearTaught_label.TabIndex = 2;
            this.yearTaught_label.Text = "Year Taught";
            // 
            // yearTaught_checkedListBox
            // 
            this.yearTaught_checkedListBox.FormattingEnabled = true;
            this.yearTaught_checkedListBox.Items.AddRange(new object[] {
            "First Year\t",
            "Second Year",
            "Third Year"});
            this.yearTaught_checkedListBox.Location = new System.Drawing.Point(161, 119);
            this.yearTaught_checkedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTaught_checkedListBox.Name = "yearTaught_checkedListBox";
            this.yearTaught_checkedListBox.Size = new System.Drawing.Size(159, 55);
            this.yearTaught_checkedListBox.TabIndex = 4;
            // 
            // semesterTaught_checkedListBox
            // 
            this.semesterTaught_checkedListBox.FormattingEnabled = true;
            this.semesterTaught_checkedListBox.Items.AddRange(new object[] {
            "First Semester",
            "Second Semester",
            "Third Semester"});
            this.semesterTaught_checkedListBox.Location = new System.Drawing.Point(161, 202);
            this.semesterTaught_checkedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.semesterTaught_checkedListBox.Name = "semesterTaught_checkedListBox";
            this.semesterTaught_checkedListBox.Size = new System.Drawing.Size(159, 55);
            this.semesterTaught_checkedListBox.TabIndex = 5;
            // 
            // semesterTaught_label
            // 
            this.semesterTaught_label.AutoSize = true;
            this.semesterTaught_label.Location = new System.Drawing.Point(36, 202);
            this.semesterTaught_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semesterTaught_label.Name = "semesterTaught_label";
            this.semesterTaught_label.Size = new System.Drawing.Size(117, 17);
            this.semesterTaught_label.TabIndex = 6;
            this.semesterTaught_label.Text = "Semester Taught";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(93, 30);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(167, 24);
            this.title.TabIndex = 7;
            this.title.Text = "Add New Course";
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(161, 278);
            this.iTalk_Button_21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(151, 30);
            this.iTalk_Button_21.TabIndex = 8;
            this.iTalk_Button_21.Text = "Add Course";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // AddCourse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.title);
            this.Controls.Add(this.semesterTaught_label);
            this.Controls.Add(this.semesterTaught_checkedListBox);
            this.Controls.Add(this.yearTaught_checkedListBox);
            this.Controls.Add(this.yearTaught_label);
            this.Controls.Add(this.courseName_label);
            this.Controls.Add(this.courseName_textBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCourse_Form";
            this.Text = "AddCourse_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseName_textBox;
        private System.Windows.Forms.Label courseName_label;
        private System.Windows.Forms.Label yearTaught_label;
        private System.Windows.Forms.CheckedListBox yearTaught_checkedListBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label semesterTaught_label;
        private System.Windows.Forms.CheckedListBox semesterTaught_checkedListBox;
        private Design.Buttons.iTalk_Button_2 iTalk_Button_21;
    }
}