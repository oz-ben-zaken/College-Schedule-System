namespace Project_Team_20.SecretaryFolder
{
    partial class Assign_Form
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
            System.Windows.Forms.ColumnHeader job;
            this.tabPage1_label = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.choose_tabPage = new System.Windows.Forms.TabPage();
            this.choose_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.chooseWorker_listView = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assignCourse_tabPage = new System.Windows.Forms.TabPage();
            this.otherCourses_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.otherCourses_label = new System.Windows.Forms.Label();
            this.assignCourse_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.workerCourses_listView = new System.Windows.Forms.ListView();
            this.myCourses_courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_yearTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_SemesterTaught = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myCourses_isCourseOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coursesWantToTeach_label = new System.Windows.Forms.Label();
            this.assignDay_tabPage = new System.Windows.Forms.TabPage();
            this.Assign_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.otherDays_listView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.preferredDays_listView = new System.Windows.Forms.ListView();
            this.DayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preferredDays_label = new System.Windows.Forms.Label();
            this.assignHours_tabPage = new System.Windows.Forms.TabPage();
            this.preferredHoursTo_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.preferredHoursFrom_Label = new System.Windows.Forms.Label();
            this.to_minutes_textBox = new System.Windows.Forms.TextBox();
            this.to_hour_textBox = new System.Windows.Forms.TextBox();
            this.from_minutes_textBox = new System.Windows.Forms.TextBox();
            this.from_hour_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assignHours_button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.choose_tabPage.SuspendLayout();
            this.assignCourse_tabPage.SuspendLayout();
            this.assignDay_tabPage.SuspendLayout();
            this.assignHours_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // job
            // 
            job.Text = "job";
            job.Width = 135;
            // 
            // tabPage1_label
            // 
            this.tabPage1_label.AutoSize = true;
            this.tabPage1_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1_label.Location = new System.Drawing.Point(11, 3);
            this.tabPage1_label.Name = "tabPage1_label";
            this.tabPage1_label.Size = new System.Drawing.Size(180, 16);
            this.tabPage1_label.TabIndex = 0;
            this.tabPage1_label.Text = "Choose Lecturer To Assign:";
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.choose_tabPage);
            this.tabControl.Controls.Add(this.assignCourse_tabPage);
            this.tabControl.Controls.Add(this.assignDay_tabPage);
            this.tabControl.Controls.Add(this.assignHours_tabPage);
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(559, 375);
            this.tabControl.TabIndex = 1;
            // 
            // choose_tabPage
            // 
            this.choose_tabPage.Controls.Add(this.choose_Button);
            this.choose_tabPage.Controls.Add(this.chooseWorker_listView);
            this.choose_tabPage.Controls.Add(this.tabPage1_label);
            this.choose_tabPage.Location = new System.Drawing.Point(4, 25);
            this.choose_tabPage.Name = "choose_tabPage";
            this.choose_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.choose_tabPage.Size = new System.Drawing.Size(551, 346);
            this.choose_tabPage.TabIndex = 0;
            this.choose_tabPage.Text = "Choose";
            this.choose_tabPage.UseVisualStyleBackColor = true;
            // 
            // choose_Button
            // 
            this.choose_Button.BackColor = System.Drawing.Color.Transparent;
            this.choose_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.choose_Button.ForeColor = System.Drawing.Color.White;
            this.choose_Button.Image = null;
            this.choose_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_Button.Location = new System.Drawing.Point(131, 312);
            this.choose_Button.Name = "choose_Button";
            this.choose_Button.Size = new System.Drawing.Size(240, 25);
            this.choose_Button.TabIndex = 2;
            this.choose_Button.Text = "Choose Lecturer";
            this.choose_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.choose_Button.Click += new System.EventHandler(this.choose_Button_Click);
            // 
            // chooseWorker_listView
            // 
            this.chooseWorker_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_name,
            this.last_name,
            this.id,
            this.age,
            this.user_name,
            job});
            this.chooseWorker_listView.Location = new System.Drawing.Point(11, 22);
            this.chooseWorker_listView.Name = "chooseWorker_listView";
            this.chooseWorker_listView.Size = new System.Drawing.Size(495, 269);
            this.chooseWorker_listView.TabIndex = 1;
            this.chooseWorker_listView.UseCompatibleStateImageBehavior = false;
            this.chooseWorker_listView.View = System.Windows.Forms.View.Details;
            // 
            // first_name
            // 
            this.first_name.Text = "first name";
            this.first_name.Width = 76;
            // 
            // last_name
            // 
            this.last_name.Text = "last name";
            this.last_name.Width = 79;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 83;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 37;
            // 
            // user_name
            // 
            this.user_name.Text = "user name";
            this.user_name.Width = 75;
            // 
            // assignCourse_tabPage
            // 
            this.assignCourse_tabPage.Controls.Add(this.otherCourses_listView);
            this.assignCourse_tabPage.Controls.Add(this.otherCourses_label);
            this.assignCourse_tabPage.Controls.Add(this.assignCourse_Button);
            this.assignCourse_tabPage.Controls.Add(this.workerCourses_listView);
            this.assignCourse_tabPage.Controls.Add(this.coursesWantToTeach_label);
            this.assignCourse_tabPage.Location = new System.Drawing.Point(4, 25);
            this.assignCourse_tabPage.Name = "assignCourse_tabPage";
            this.assignCourse_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignCourse_tabPage.Size = new System.Drawing.Size(551, 346);
            this.assignCourse_tabPage.TabIndex = 1;
            this.assignCourse_tabPage.Text = "Assign Course";
            this.assignCourse_tabPage.UseVisualStyleBackColor = true;
            // 
            // otherCourses_listView
            // 
            this.otherCourses_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherCourses_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.otherCourses_listView.Location = new System.Drawing.Point(11, 180);
            this.otherCourses_listView.Name = "otherCourses_listView";
            this.otherCourses_listView.Size = new System.Drawing.Size(456, 126);
            this.otherCourses_listView.TabIndex = 5;
            this.otherCourses_listView.UseCompatibleStateImageBehavior = false;
            this.otherCourses_listView.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Semester";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Is Open";
            this.columnHeader5.Width = 68;
            // 
            // otherCourses_label
            // 
            this.otherCourses_label.AutoSize = true;
            this.otherCourses_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.otherCourses_label.Location = new System.Drawing.Point(8, 157);
            this.otherCourses_label.Name = "otherCourses_label";
            this.otherCourses_label.Size = new System.Drawing.Size(101, 16);
            this.otherCourses_label.TabIndex = 4;
            this.otherCourses_label.Text = "Other Courses:";
            // 
            // assignCourse_Button
            // 
            this.assignCourse_Button.BackColor = System.Drawing.Color.Transparent;
            this.assignCourse_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.assignCourse_Button.ForeColor = System.Drawing.Color.White;
            this.assignCourse_Button.Image = null;
            this.assignCourse_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignCourse_Button.Location = new System.Drawing.Point(249, 312);
            this.assignCourse_Button.Name = "assignCourse_Button";
            this.assignCourse_Button.Size = new System.Drawing.Size(159, 25);
            this.assignCourse_Button.TabIndex = 3;
            this.assignCourse_Button.Text = "Assign Course";
            this.assignCourse_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.assignCourse_Button.Click += new System.EventHandler(this.assignCourse_Button_Click);
            // 
            // workerCourses_listView
            // 
            this.workerCourses_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerCourses_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.myCourses_courseID,
            this.myCourses_courseName,
            this.myCourses_yearTaught,
            this.myCourses_SemesterTaught,
            this.myCourses_isCourseOpen});
            this.workerCourses_listView.Location = new System.Drawing.Point(11, 27);
            this.workerCourses_listView.Name = "workerCourses_listView";
            this.workerCourses_listView.Size = new System.Drawing.Size(456, 123);
            this.workerCourses_listView.TabIndex = 1;
            this.workerCourses_listView.UseCompatibleStateImageBehavior = false;
            this.workerCourses_listView.View = System.Windows.Forms.View.Details;
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
            this.myCourses_yearTaught.Width = 100;
            // 
            // myCourses_SemesterTaught
            // 
            this.myCourses_SemesterTaught.Text = "Semester";
            this.myCourses_SemesterTaught.Width = 85;
            // 
            // myCourses_isCourseOpen
            // 
            this.myCourses_isCourseOpen.Text = "Is Open";
            this.myCourses_isCourseOpen.Width = 68;
            // 
            // coursesWantToTeach_label
            // 
            this.coursesWantToTeach_label.AutoSize = true;
            this.coursesWantToTeach_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.coursesWantToTeach_label.Location = new System.Drawing.Point(8, 8);
            this.coursesWantToTeach_label.Name = "coursesWantToTeach_label";
            this.coursesWantToTeach_label.Size = new System.Drawing.Size(223, 16);
            this.coursesWantToTeach_label.TabIndex = 0;
            this.coursesWantToTeach_label.Text = "Courses Lecturer Wants To Teach:";
            // 
            // assignDay_tabPage
            // 
            this.assignDay_tabPage.Controls.Add(this.Assign_Button);
            this.assignDay_tabPage.Controls.Add(this.otherDays_listView);
            this.assignDay_tabPage.Controls.Add(this.label1);
            this.assignDay_tabPage.Controls.Add(this.preferredDays_listView);
            this.assignDay_tabPage.Controls.Add(this.preferredDays_label);
            this.assignDay_tabPage.Location = new System.Drawing.Point(4, 25);
            this.assignDay_tabPage.Name = "assignDay_tabPage";
            this.assignDay_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignDay_tabPage.Size = new System.Drawing.Size(551, 346);
            this.assignDay_tabPage.TabIndex = 2;
            this.assignDay_tabPage.Text = "Assign Day";
            this.assignDay_tabPage.UseVisualStyleBackColor = true;
            // 
            // Assign_Button
            // 
            this.Assign_Button.BackColor = System.Drawing.Color.Transparent;
            this.Assign_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Assign_Button.ForeColor = System.Drawing.Color.White;
            this.Assign_Button.Image = null;
            this.Assign_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Assign_Button.Location = new System.Drawing.Point(19, 313);
            this.Assign_Button.Name = "Assign_Button";
            this.Assign_Button.Size = new System.Drawing.Size(159, 25);
            this.Assign_Button.TabIndex = 5;
            this.Assign_Button.Text = "Assign Day";
            this.Assign_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Assign_Button.Click += new System.EventHandler(this.Assign_Button_Click);
            // 
            // otherDays_listView
            // 
            this.otherDays_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.otherDays_listView.Location = new System.Drawing.Point(43, 196);
            this.otherDays_listView.Name = "otherDays_listView";
            this.otherDays_listView.Size = new System.Drawing.Size(87, 97);
            this.otherDays_listView.TabIndex = 4;
            this.otherDays_listView.UseCompatibleStateImageBehavior = false;
            this.otherDays_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(16, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Other Days To Teach:";
            // 
            // preferredDays_listView
            // 
            this.preferredDays_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DayColumn});
            this.preferredDays_listView.Location = new System.Drawing.Point(43, 48);
            this.preferredDays_listView.Name = "preferredDays_listView";
            this.preferredDays_listView.Size = new System.Drawing.Size(87, 97);
            this.preferredDays_listView.TabIndex = 2;
            this.preferredDays_listView.UseCompatibleStateImageBehavior = false;
            this.preferredDays_listView.View = System.Windows.Forms.View.Details;
            // 
            // DayColumn
            // 
            this.DayColumn.Width = 83;
            // 
            // preferredDays_label
            // 
            this.preferredDays_label.AutoSize = true;
            this.preferredDays_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.preferredDays_label.Location = new System.Drawing.Point(16, 16);
            this.preferredDays_label.Name = "preferredDays_label";
            this.preferredDays_label.Size = new System.Drawing.Size(167, 16);
            this.preferredDays_label.TabIndex = 1;
            this.preferredDays_label.Text = "Preferred Days To Teach:";
            // 
            // assignHours_tabPage
            // 
            this.assignHours_tabPage.Controls.Add(this.preferredHoursTo_Label);
            this.assignHours_tabPage.Controls.Add(this.label7);
            this.assignHours_tabPage.Controls.Add(this.preferredHoursFrom_Label);
            this.assignHours_tabPage.Controls.Add(this.to_minutes_textBox);
            this.assignHours_tabPage.Controls.Add(this.to_hour_textBox);
            this.assignHours_tabPage.Controls.Add(this.from_minutes_textBox);
            this.assignHours_tabPage.Controls.Add(this.from_hour_textBox);
            this.assignHours_tabPage.Controls.Add(this.label4);
            this.assignHours_tabPage.Controls.Add(this.label5);
            this.assignHours_tabPage.Controls.Add(this.label3);
            this.assignHours_tabPage.Controls.Add(this.label2);
            this.assignHours_tabPage.Controls.Add(this.assignHours_button);
            this.assignHours_tabPage.Location = new System.Drawing.Point(4, 25);
            this.assignHours_tabPage.Name = "assignHours_tabPage";
            this.assignHours_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.assignHours_tabPage.Size = new System.Drawing.Size(551, 346);
            this.assignHours_tabPage.TabIndex = 3;
            this.assignHours_tabPage.Text = "Assign Hours";
            this.assignHours_tabPage.UseVisualStyleBackColor = true;
            // 
            // preferredHoursTo_Label
            // 
            this.preferredHoursTo_Label.AutoSize = true;
            this.preferredHoursTo_Label.Location = new System.Drawing.Point(79, 58);
            this.preferredHoursTo_Label.Name = "preferredHoursTo_Label";
            this.preferredHoursTo_Label.Size = new System.Drawing.Size(16, 13);
            this.preferredHoursTo_Label.TabIndex = 18;
            this.preferredHoursTo_Label.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "-";
            // 
            // preferredHoursFrom_Label
            // 
            this.preferredHoursFrom_Label.AutoSize = true;
            this.preferredHoursFrom_Label.Location = new System.Drawing.Point(21, 58);
            this.preferredHoursFrom_Label.Name = "preferredHoursFrom_Label";
            this.preferredHoursFrom_Label.Size = new System.Drawing.Size(27, 13);
            this.preferredHoursFrom_Label.TabIndex = 16;
            this.preferredHoursFrom_Label.Text = "from";
            // 
            // to_minutes_textBox
            // 
            this.to_minutes_textBox.Location = new System.Drawing.Point(96, 249);
            this.to_minutes_textBox.Name = "to_minutes_textBox";
            this.to_minutes_textBox.Size = new System.Drawing.Size(31, 20);
            this.to_minutes_textBox.TabIndex = 15;
            // 
            // to_hour_textBox
            // 
            this.to_hour_textBox.Location = new System.Drawing.Point(57, 249);
            this.to_hour_textBox.Name = "to_hour_textBox";
            this.to_hour_textBox.Size = new System.Drawing.Size(31, 20);
            this.to_hour_textBox.TabIndex = 14;
            // 
            // from_minutes_textBox
            // 
            this.from_minutes_textBox.Location = new System.Drawing.Point(96, 202);
            this.from_minutes_textBox.Name = "from_minutes_textBox";
            this.from_minutes_textBox.Size = new System.Drawing.Size(31, 20);
            this.from_minutes_textBox.TabIndex = 13;
            // 
            // from_hour_textBox
            // 
            this.from_hour_textBox.Location = new System.Drawing.Point(57, 202);
            this.from_hour_textBox.Name = "from_hour_textBox";
            this.from_hour_textBox.Size = new System.Drawing.Size(31, 20);
            this.from_hour_textBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Assign Hours To Teach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preferred Hours To Teach:";
            // 
            // assignHours_button
            // 
            this.assignHours_button.BackColor = System.Drawing.Color.Transparent;
            this.assignHours_button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.assignHours_button.ForeColor = System.Drawing.Color.White;
            this.assignHours_button.Image = null;
            this.assignHours_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assignHours_button.Location = new System.Drawing.Point(21, 313);
            this.assignHours_button.Name = "assignHours_button";
            this.assignHours_button.Size = new System.Drawing.Size(159, 25);
            this.assignHours_button.TabIndex = 6;
            this.assignHours_button.Text = "Assign Hours";
            this.assignHours_button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.assignHours_button.Click += new System.EventHandler(this.assignHours_button_Click);
            // 
            // Assign_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 379);
            this.Controls.Add(this.tabControl);
            this.Name = "Assign_Form";
            this.Text = "AssignLecturer_Form";
            this.tabControl.ResumeLayout(false);
            this.choose_tabPage.ResumeLayout(false);
            this.choose_tabPage.PerformLayout();
            this.assignCourse_tabPage.ResumeLayout(false);
            this.assignCourse_tabPage.PerformLayout();
            this.assignDay_tabPage.ResumeLayout(false);
            this.assignDay_tabPage.PerformLayout();
            this.assignHours_tabPage.ResumeLayout(false);
            this.assignHours_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tabPage1_label;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage choose_tabPage;
        private System.Windows.Forms.TabPage assignCourse_tabPage;
        private Design.Buttons.iTalk_Button_2 choose_Button;
        private System.Windows.Forms.ListView chooseWorker_listView;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.Label coursesWantToTeach_label;
        private System.Windows.Forms.ListView workerCourses_listView;
        private System.Windows.Forms.ColumnHeader myCourses_courseID;
        private System.Windows.Forms.ColumnHeader myCourses_courseName;
        private System.Windows.Forms.ColumnHeader myCourses_yearTaught;
        private System.Windows.Forms.ColumnHeader myCourses_SemesterTaught;
        private System.Windows.Forms.ColumnHeader myCourses_isCourseOpen;
        private Design.Buttons.iTalk_Button_2 assignCourse_Button;
        private System.Windows.Forms.ListView otherCourses_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label otherCourses_label;
        private System.Windows.Forms.TabPage assignDay_tabPage;
        private System.Windows.Forms.ListView preferredDays_listView;
        private System.Windows.Forms.Label preferredDays_label;
        private System.Windows.Forms.ColumnHeader DayColumn;
        private Design.Buttons.iTalk_Button_2 Assign_Button;
        private System.Windows.Forms.ListView otherDays_listView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage assignHours_tabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Design.Buttons.iTalk_Button_2 assignHours_button;
        private System.Windows.Forms.TextBox to_minutes_textBox;
        private System.Windows.Forms.TextBox to_hour_textBox;
        private System.Windows.Forms.TextBox from_minutes_textBox;
        private System.Windows.Forms.TextBox from_hour_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label preferredHoursFrom_Label;
        private System.Windows.Forms.Label preferredHoursTo_Label;
        private System.Windows.Forms.Label label7;
    }
}