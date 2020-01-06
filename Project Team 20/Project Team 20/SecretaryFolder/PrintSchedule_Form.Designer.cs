namespace Project_Team_20.SecretaryFolder
{
    partial class PrintSchedule_Form
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
            this.schedule_listView = new System.Windows.Forms.ListView();
            this.workerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workerFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workerLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.workerPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoursToTeach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dayToTeach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // schedule_listView
            // 
            this.schedule_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workerID,
            this.workerFirstName,
            this.workerLastName,
            this.workerPosition,
            this.courseID,
            this.courseName,
            this.hoursToTeach,
            this.dayToTeach});
            this.schedule_listView.Location = new System.Drawing.Point(12, 12);
            this.schedule_listView.Name = "schedule_listView";
            this.schedule_listView.Size = new System.Drawing.Size(618, 245);
            this.schedule_listView.TabIndex = 1;
            this.schedule_listView.UseCompatibleStateImageBehavior = false;
            this.schedule_listView.View = System.Windows.Forms.View.Details;
            this.schedule_listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // workerID
            // 
            this.workerID.Text = "Worker ID";
            this.workerID.Width = 66;
            // 
            // workerFirstName
            // 
            this.workerFirstName.Text = "Worker First Name";
            this.workerFirstName.Width = 102;
            // 
            // workerLastName
            // 
            this.workerLastName.Text = "Worker Last Name";
            this.workerLastName.Width = 101;
            // 
            // workerPosition
            // 
            this.workerPosition.Text = "Worker Position";
            this.workerPosition.Width = 87;
            // 
            // courseID
            // 
            this.courseID.Text = "Course ID";
            // 
            // courseName
            // 
            this.courseName.DisplayIndex = 7;
            this.courseName.Text = "Course Name";
            this.courseName.Width = 76;
            // 
            // hoursToTeach
            // 
            this.hoursToTeach.DisplayIndex = 5;
            this.hoursToTeach.Text = "Hours";
            // 
            // dayToTeach
            // 
            this.dayToTeach.DisplayIndex = 6;
            this.dayToTeach.Text = "Day";
            // 
            // PrintSchedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 262);
            this.Controls.Add(this.schedule_listView);
            this.Name = "PrintSchedule_Form";
            this.Text = "PrintSchedule_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView schedule_listView;
        private System.Windows.Forms.ColumnHeader workerID;
        private System.Windows.Forms.ColumnHeader workerFirstName;
        private System.Windows.Forms.ColumnHeader workerLastName;
        private System.Windows.Forms.ColumnHeader workerPosition;
        private System.Windows.Forms.ColumnHeader courseID;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader hoursToTeach;
        private System.Windows.Forms.ColumnHeader dayToTeach;
    }
}