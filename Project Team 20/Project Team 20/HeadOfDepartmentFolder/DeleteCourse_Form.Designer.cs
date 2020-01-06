namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class DeleteCourse_Form
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
            this.listView = new System.Windows.Forms.ListView();
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SemesterTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = new System.Windows.Forms.Label();
            this.deleteCourse_button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseID,
            this.CourseName,
            this.YearTaught,
            this.SemesterTaught,
            this.isOpen});
            this.listView.Location = new System.Drawing.Point(16, 52);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(662, 330);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // CourseID
            // 
            this.CourseID.Text = "Course ID";
            this.CourseID.Width = 139;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 92;
            // 
            // YearTaught
            // 
            this.YearTaught.Text = "Year Taught";
            this.YearTaught.Width = 89;
            // 
            // SemesterTaught
            // 
            this.SemesterTaught.Text = "Semester Taught";
            this.SemesterTaught.Width = 92;
            // 
            // isOpen
            // 
            this.isOpen.Text = "open/close";
            this.isOpen.Width = 88;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.title.Location = new System.Drawing.Point(163, 11);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(143, 24);
            this.title.TabIndex = 8;
            this.title.Text = "Delete Course";
            // 
            // deleteCourse_button
            // 
            this.deleteCourse_button.BackColor = System.Drawing.Color.Transparent;
            this.deleteCourse_button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.deleteCourse_button.ForeColor = System.Drawing.Color.White;
            this.deleteCourse_button.Image = null;
            this.deleteCourse_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteCourse_button.Location = new System.Drawing.Point(168, 393);
            this.deleteCourse_button.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCourse_button.Name = "deleteCourse_button";
            this.deleteCourse_button.Size = new System.Drawing.Size(180, 30);
            this.deleteCourse_button.TabIndex = 9;
            this.deleteCourse_button.Text = "Delete Course";
            this.deleteCourse_button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.deleteCourse_button.Click += new System.EventHandler(this.deleteCourse_button_Click);
            // 
            // DeleteCourse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 437);
            this.Controls.Add(this.deleteCourse_button);
            this.Controls.Add(this.title);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteCourse_Form";
            this.Text = "DeleteCourse_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader YearTaught;
        private System.Windows.Forms.ColumnHeader SemesterTaught;
        private Design.Buttons.iTalk_Button_2 deleteCourse_button;
        private System.Windows.Forms.ColumnHeader isOpen;
    }
}