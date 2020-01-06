namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    partial class ChooseCoursesToTeach
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
            this.myCourses_listView = new System.Windows.Forms.ListView();
            this.myCourses_courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_groupBox = new System.Windows.Forms.GroupBox();
            this.allCourses_groupBox = new System.Windows.Forms.GroupBox();
            this.allCourses_listView = new System.Windows.Forms.ListView();
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.semesterTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightArrow_pictureBox = new System.Windows.Forms.PictureBox();
            this.leftArrow_pictureBox = new System.Windows.Forms.PictureBox();
            this.myCourses_yearTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_SemesterTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_isCourseOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iTalk_Button_21 = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.isOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_groupBox.SuspendLayout();
            this.allCourses_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myCourses_listView
            // 
            this.myCourses_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.myCourses_courseID,
            this.myCourses_courseName,
            this.myCourses_yearTaught,
            this.myCourses_SemesterTaught,
            this.myCourses_isCourseOpen});
            this.myCourses_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCourses_listView.Location = new System.Drawing.Point(3, 22);
            this.myCourses_listView.Name = "myCourses_listView";
            this.myCourses_listView.Size = new System.Drawing.Size(291, 274);
            this.myCourses_listView.TabIndex = 0;
            this.myCourses_listView.UseCompatibleStateImageBehavior = false;
            this.myCourses_listView.View = System.Windows.Forms.View.Details;
            // 
            // myCourses_courseID
            // 
            this.myCourses_courseID.Text = "Course ID";
            this.myCourses_courseID.Width = 89;
            // 
            // myCourses_courseName
            // 
            this.myCourses_courseName.Text = "Course Name";
            this.myCourses_courseName.Width = 112;
            // 
            // myCourses_groupBox
            // 
            this.myCourses_groupBox.Controls.Add(this.myCourses_listView);
            this.myCourses_groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.myCourses_groupBox.Location = new System.Drawing.Point(12, 25);
            this.myCourses_groupBox.Name = "myCourses_groupBox";
            this.myCourses_groupBox.Size = new System.Drawing.Size(297, 299);
            this.myCourses_groupBox.TabIndex = 1;
            this.myCourses_groupBox.TabStop = false;
            this.myCourses_groupBox.Text = "My Courses";
            this.myCourses_groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // allCourses_groupBox
            // 
            this.allCourses_groupBox.Controls.Add(this.allCourses_listView);
            this.allCourses_groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.allCourses_groupBox.Location = new System.Drawing.Point(371, 25);
            this.allCourses_groupBox.Name = "allCourses_groupBox";
            this.allCourses_groupBox.Size = new System.Drawing.Size(302, 299);
            this.allCourses_groupBox.TabIndex = 2;
            this.allCourses_groupBox.TabStop = false;
            this.allCourses_groupBox.Text = "All Courses";
            this.allCourses_groupBox.Enter += new System.EventHandler(this.allCourses_groupBox_Enter);
            // 
            // allCourses_listView
            // 
            this.allCourses_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseID,
            this.CourseName,
            this.Year,
            this.semesterTaught,
            this.isOpen});
            this.allCourses_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCourses_listView.Location = new System.Drawing.Point(3, 22);
            this.allCourses_listView.Name = "allCourses_listView";
            this.allCourses_listView.Size = new System.Drawing.Size(296, 274);
            this.allCourses_listView.TabIndex = 0;
            this.allCourses_listView.UseCompatibleStateImageBehavior = false;
            this.allCourses_listView.View = System.Windows.Forms.View.Details;
            // 
            // CourseID
            // 
            this.CourseID.Text = "Course ID";
            this.CourseID.Width = 82;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 121;
            // 
            // Year
            // 
            this.Year.Text = "Year Taught";
            // 
            // semesterTaught
            // 
            this.semesterTaught.Text = "Semester";
            // 
            // rightArrow_pictureBox
            // 
            this.rightArrow_pictureBox.Image = global::Project_Team_20.Properties.Resources.arrow_right;
            this.rightArrow_pictureBox.Location = new System.Drawing.Point(315, 166);
            this.rightArrow_pictureBox.Name = "rightArrow_pictureBox";
            this.rightArrow_pictureBox.Size = new System.Drawing.Size(49, 50);
            this.rightArrow_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightArrow_pictureBox.TabIndex = 4;
            this.rightArrow_pictureBox.TabStop = false;
            this.rightArrow_pictureBox.Click += new System.EventHandler(this.rightArrow_pictureBox_Click);
            // 
            // leftArrow_pictureBox
            // 
            this.leftArrow_pictureBox.Image = global::Project_Team_20.Properties.Resources.arrow_left;
            this.leftArrow_pictureBox.Location = new System.Drawing.Point(315, 96);
            this.leftArrow_pictureBox.Name = "leftArrow_pictureBox";
            this.leftArrow_pictureBox.Size = new System.Drawing.Size(49, 50);
            this.leftArrow_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftArrow_pictureBox.TabIndex = 3;
            this.leftArrow_pictureBox.TabStop = false;
            this.leftArrow_pictureBox.Click += new System.EventHandler(this.leftArrow_pictureBox_Click);
            // 
            // myCourses_yearTaught
            // 
            this.myCourses_yearTaught.Text = "Year Taught";
            // 
            // myCourses_SemesterTaught
            // 
            this.myCourses_SemesterTaught.Text = "Semester";
            // 
            // myCourses_isCourseOpen
            // 
            this.myCourses_isCourseOpen.Text = "Is Open";
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(198, 330);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_21.TabIndex = 5;
            this.iTalk_Button_21.Text = "Save Changes";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // isOpen
            // 
            this.isOpen.Text = "Is Open";
            // 
            // ChooseCoursesToTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.rightArrow_pictureBox);
            this.Controls.Add(this.leftArrow_pictureBox);
            this.Controls.Add(this.allCourses_groupBox);
            this.Controls.Add(this.myCourses_groupBox);
            this.Name = "ChooseCoursesToTeach";
            this.Text = "ChooseCoursesToTeach";
            this.Load += new System.EventHandler(this.ChooseCoursesToTeach_Load);
            this.myCourses_groupBox.ResumeLayout(false);
            this.allCourses_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView myCourses_listView;
        private System.Windows.Forms.GroupBox myCourses_groupBox;
        private System.Windows.Forms.GroupBox allCourses_groupBox;
        private System.Windows.Forms.ListView allCourses_listView;
        private System.Windows.Forms.PictureBox leftArrow_pictureBox;
        private System.Windows.Forms.PictureBox rightArrow_pictureBox;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader myCourses_courseID;
        private System.Windows.Forms.ColumnHeader myCourses_courseName;
        private Design.Buttons.iTalk_Button_2 iTalk_Button_21;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader semesterTaught;
        private System.Windows.Forms.ColumnHeader myCourses_yearTaught;
        private System.Windows.Forms.ColumnHeader myCourses_SemesterTaught;
        private System.Windows.Forms.ColumnHeader myCourses_isCourseOpen;
        private System.Windows.Forms.ColumnHeader isOpen;
    }
}