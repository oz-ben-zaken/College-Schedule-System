﻿namespace Project_Team_20.SecretaryFolder
{
    partial class DerecognitionHours_Form
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
            this.listView = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1_label = new System.Windows.Forms.Label();
            this.choose_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursBox = new System.Windows.Forms.TextBox();
            job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // job
            // 
            job.Text = "job";
            job.Width = 125;
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
            this.listView.Location = new System.Drawing.Point(13, 47);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(580, 249);
            this.listView.TabIndex = 1;
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
            // tabPage1_label
            // 
            this.tabPage1_label.AutoSize = true;
            this.tabPage1_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1_label.Location = new System.Drawing.Point(9, 19);
            this.tabPage1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabPage1_label.Name = "tabPage1_label";
            this.tabPage1_label.Size = new System.Drawing.Size(223, 19);
            this.tabPage1_label.TabIndex = 2;
            this.tabPage1_label.Text = "Choose teaching assistant:";
            // 
            // choose_Button
            // 
            this.choose_Button.BackColor = System.Drawing.Color.Transparent;
            this.choose_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.choose_Button.ForeColor = System.Drawing.Color.White;
            this.choose_Button.Image = null;
            this.choose_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_Button.Location = new System.Drawing.Point(329, 347);
            this.choose_Button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_Button.Name = "choose_Button";
            this.choose_Button.Size = new System.Drawing.Size(219, 31);
            this.choose_Button.TabIndex = 3;
            this.choose_Button.Text = "reduce hours";
            this.choose_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.choose_Button.Click += new System.EventHandler(this.choose_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(9, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose amount of hours to reduce (no more than 4):";
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(493, 307);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(100, 22);
            this.hoursBox.TabIndex = 5;
            this.hoursBox.TextChanged += new System.EventHandler(this.hoursBox_TextChanged);
            // 
            // DerecognitionHours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 391);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choose_Button);
            this.Controls.Add(this.tabPage1_label);
            this.Controls.Add(this.listView);
            this.Name = "DerecognitionHours_Form";
            this.Text = "DerecognitionHours_Form";
            this.Load += new System.EventHandler(this.DerecognitionHours_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.Label tabPage1_label;
        private Design.Buttons.iTalk_Button_2 choose_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hoursBox;
    }
}