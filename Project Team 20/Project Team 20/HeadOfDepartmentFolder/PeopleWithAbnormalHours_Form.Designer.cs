namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class PeopleWithAbnormalHours_Form
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
            System.Windows.Forms.ColumnHeader hours;
            this.listView = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resetHours_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_name,
            this.last_name,
            this.id,
            this.age,
            this.user_name,
            hours});
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(549, 309);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // first_name
            // 
            this.first_name.Text = "first name";
            this.first_name.Width = 70;
            // 
            // last_name
            // 
            this.last_name.Text = "last name";
            this.last_name.Width = 73;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 66;
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
            // hours
            // 
            hours.Text = "current hours";
            hours.Width = 125;
            // 
            // resetHours_Button
            // 
            this.resetHours_Button.BackColor = System.Drawing.Color.Transparent;
            this.resetHours_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.resetHours_Button.ForeColor = System.Drawing.Color.White;
            this.resetHours_Button.Image = null;
            this.resetHours_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetHours_Button.Location = new System.Drawing.Point(185, 330);
            this.resetHours_Button.Margin = new System.Windows.Forms.Padding(4);
            this.resetHours_Button.Name = "resetHours_Button";
            this.resetHours_Button.Size = new System.Drawing.Size(189, 31);
            this.resetHours_Button.TabIndex = 6;
            this.resetHours_Button.Text = "reset hours";
            this.resetHours_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.resetHours_Button.Click += new System.EventHandler(this.resetHours_Button_Click);
            // 
            // PeopleWithAbnormalHours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.resetHours_Button);
            this.Controls.Add(this.listView);
            this.Name = "PeopleWithAbnormalHours_Form";
            this.Text = "PeopleWithAbnormalHours_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader user_name;
        private Design.Buttons.iTalk_Button_2 resetHours_Button;
    }
}