namespace Project_Team_20.SecretaryFolder
{
    partial class ExceptionHours_Form
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
            this.listView = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.choose_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.hoursBox = new System.Windows.Forms.TextBox();
            job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // job
            // 
            job.Text = "job";
            job.Width = 125;
            // 
            // tabPage1_label
            // 
            this.tabPage1_label.AutoSize = true;
            this.tabPage1_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1_label.Location = new System.Drawing.Point(13, 9);
            this.tabPage1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabPage1_label.Name = "tabPage1_label";
            this.tabPage1_label.Size = new System.Drawing.Size(135, 19);
            this.tabPage1_label.TabIndex = 3;
            this.tabPage1_label.Text = "Choose worker:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_name,
            this.last_name,
            this.id,
            this.age,
            this.user_name,
            job});
            this.listView.Location = new System.Drawing.Point(11, 44);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(580, 249);
            this.listView.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(7, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose amount of hours to increase (no more than 4):";
            // 
            // choose_Button
            // 
            this.choose_Button.BackColor = System.Drawing.Color.Transparent;
            this.choose_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.choose_Button.ForeColor = System.Drawing.Color.White;
            this.choose_Button.Image = null;
            this.choose_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_Button.Location = new System.Drawing.Point(325, 349);
            this.choose_Button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_Button.Name = "choose_Button";
            this.choose_Button.Size = new System.Drawing.Size(219, 31);
            this.choose_Button.TabIndex = 6;
            this.choose_Button.Text = "add hours";
            this.choose_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.choose_Button.Click += new System.EventHandler(this.choose_Button_Click);
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(491, 309);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(100, 22);
            this.hoursBox.TabIndex = 7;
            // 
            // ExceptionHours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 393);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.choose_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tabPage1_label);
            this.Name = "ExceptionHours_Form";
            this.Text = "ExceptionHours_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tabPage1_label;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.Label label1;
        private Design.Buttons.iTalk_Button_2 choose_Button;
        private System.Windows.Forms.TextBox hoursBox;
    }
}