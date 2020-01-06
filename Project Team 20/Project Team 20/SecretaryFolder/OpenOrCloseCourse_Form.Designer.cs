namespace Project_Team_20.SecretaryFolder
{
    partial class OpenOrCloseCourse_Form
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
            this.closedCourses_groupBox = new System.Windows.Forms.GroupBox();
            this.closeCourses_listView = new System.Windows.Forms.ListView();
            this.myCourses_courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_yearTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_SemesterTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openCourses_groupBox = new System.Windows.Forms.GroupBox();
            this.openCourses_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightArrow_pictureBox = new System.Windows.Forms.PictureBox();
            this.leftArrow_pictureBox = new System.Windows.Forms.PictureBox();
            this.iTalk_Button_21 = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.closedCourses_groupBox.SuspendLayout();
            this.openCourses_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closedCourses_groupBox
            // 
            this.closedCourses_groupBox.Controls.Add(this.closeCourses_listView);
            this.closedCourses_groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.closedCourses_groupBox.Location = new System.Drawing.Point(12, 18);
            this.closedCourses_groupBox.Name = "closedCourses_groupBox";
            this.closedCourses_groupBox.Size = new System.Drawing.Size(307, 277);
            this.closedCourses_groupBox.TabIndex = 2;
            this.closedCourses_groupBox.TabStop = false;
            this.closedCourses_groupBox.Text = "Close Courses";
            // 
            // closeCourses_listView
            // 
            this.closeCourses_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.myCourses_courseID,
            this.myCourses_courseName,
            this.myCourses_yearTaught,
            this.myCourses_SemesterTaught});
            this.closeCourses_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeCourses_listView.Location = new System.Drawing.Point(3, 22);
            this.closeCourses_listView.Name = "closeCourses_listView";
            this.closeCourses_listView.Size = new System.Drawing.Size(301, 252);
            this.closeCourses_listView.TabIndex = 0;
            this.closeCourses_listView.UseCompatibleStateImageBehavior = false;
            this.closeCourses_listView.View = System.Windows.Forms.View.Details;
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
            // myCourses_yearTaught
            // 
            this.myCourses_yearTaught.Text = "Year Taught";
            this.myCourses_yearTaught.Width = 94;
            // 
            // myCourses_SemesterTaught
            // 
            this.myCourses_SemesterTaught.Text = "Semester";
            this.myCourses_SemesterTaught.Width = 81;
            // 
            // openCourses_groupBox
            // 
            this.openCourses_groupBox.Controls.Add(this.openCourses_listView);
            this.openCourses_groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.openCourses_groupBox.Location = new System.Drawing.Point(468, 18);
            this.openCourses_groupBox.Name = "openCourses_groupBox";
            this.openCourses_groupBox.Size = new System.Drawing.Size(302, 277);
            this.openCourses_groupBox.TabIndex = 3;
            this.openCourses_groupBox.TabStop = false;
            this.openCourses_groupBox.Text = "Open Courses";
            // 
            // openCourses_listView
            // 
            this.openCourses_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.openCourses_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openCourses_listView.Location = new System.Drawing.Point(3, 22);
            this.openCourses_listView.Name = "openCourses_listView";
            this.openCourses_listView.Size = new System.Drawing.Size(296, 252);
            this.openCourses_listView.TabIndex = 0;
            this.openCourses_listView.UseCompatibleStateImageBehavior = false;
            this.openCourses_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course ID";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year Taught";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Semester";
            this.columnHeader4.Width = 81;
            // 
            // rightArrow_pictureBox
            // 
            this.rightArrow_pictureBox.Image = global::Project_Team_20.Properties.Resources.arrow_right;
            this.rightArrow_pictureBox.Location = new System.Drawing.Point(367, 186);
            this.rightArrow_pictureBox.Name = "rightArrow_pictureBox";
            this.rightArrow_pictureBox.Size = new System.Drawing.Size(49, 50);
            this.rightArrow_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightArrow_pictureBox.TabIndex = 6;
            this.rightArrow_pictureBox.TabStop = false;
            this.rightArrow_pictureBox.Click += new System.EventHandler(this.rightArrow_pictureBox_Click);
            // 
            // leftArrow_pictureBox
            // 
            this.leftArrow_pictureBox.Image = global::Project_Team_20.Properties.Resources.arrow_left;
            this.leftArrow_pictureBox.Location = new System.Drawing.Point(367, 116);
            this.leftArrow_pictureBox.Name = "leftArrow_pictureBox";
            this.leftArrow_pictureBox.Size = new System.Drawing.Size(49, 50);
            this.leftArrow_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftArrow_pictureBox.TabIndex = 5;
            this.leftArrow_pictureBox.TabStop = false;
            this.leftArrow_pictureBox.Click += new System.EventHandler(this.leftArrow_pictureBox_Click);
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(310, 301);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_21.TabIndex = 7;
            this.iTalk_Button_21.Text = "Save Changes";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // OpenOrCloseCourse_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.rightArrow_pictureBox);
            this.Controls.Add(this.leftArrow_pictureBox);
            this.Controls.Add(this.openCourses_groupBox);
            this.Controls.Add(this.closedCourses_groupBox);
            this.Name = "OpenOrCloseCourse_Form";
            this.Text = "OpenOrCloseCourse_Form";
            this.closedCourses_groupBox.ResumeLayout(false);
            this.openCourses_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox closedCourses_groupBox;
        private System.Windows.Forms.ListView closeCourses_listView;
        private System.Windows.Forms.ColumnHeader myCourses_courseID;
        private System.Windows.Forms.ColumnHeader myCourses_courseName;
        private System.Windows.Forms.ColumnHeader myCourses_yearTaught;
        private System.Windows.Forms.ColumnHeader myCourses_SemesterTaught;
        private System.Windows.Forms.GroupBox openCourses_groupBox;
        private System.Windows.Forms.ListView openCourses_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox rightArrow_pictureBox;
        private System.Windows.Forms.PictureBox leftArrow_pictureBox;
        private Design.Buttons.iTalk_Button_2 iTalk_Button_21;
    }
}