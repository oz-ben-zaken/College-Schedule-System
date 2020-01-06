namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class DerecognitionOfHours_Form
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
            this.tabPage1_label = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.choose_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.decline_Buton = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // hours
            // 
            hours.Text = "hours to reduce";
            hours.Width = 125;
            // 
            // tabPage1_label
            // 
            this.tabPage1_label.AutoSize = true;
            this.tabPage1_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1_label.Location = new System.Drawing.Point(13, 20);
            this.tabPage1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tabPage1_label.Name = "tabPage1_label";
            this.tabPage1_label.Size = new System.Drawing.Size(428, 19);
            this.tabPage1_label.TabIndex = 3;
            this.tabPage1_label.Text = "List of teaching assistant with derecognition request:";
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
            this.listView.Location = new System.Drawing.Point(17, 55);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(535, 249);
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
            // choose_Button
            // 
            this.choose_Button.BackColor = System.Drawing.Color.Transparent;
            this.choose_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.choose_Button.ForeColor = System.Drawing.Color.White;
            this.choose_Button.Image = null;
            this.choose_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_Button.Location = new System.Drawing.Point(309, 323);
            this.choose_Button.Margin = new System.Windows.Forms.Padding(4);
            this.choose_Button.Name = "choose_Button";
            this.choose_Button.Size = new System.Drawing.Size(219, 31);
            this.choose_Button.TabIndex = 5;
            this.choose_Button.Text = "approve request";
            this.choose_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.choose_Button.Click += new System.EventHandler(this.choose_Button_Click);
            // 
            // decline_Buton
            // 
            this.decline_Buton.BackColor = System.Drawing.Color.Transparent;
            this.decline_Buton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.decline_Buton.ForeColor = System.Drawing.Color.White;
            this.decline_Buton.Image = null;
            this.decline_Buton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decline_Buton.Location = new System.Drawing.Point(44, 323);
            this.decline_Buton.Margin = new System.Windows.Forms.Padding(4);
            this.decline_Buton.Name = "decline_Buton";
            this.decline_Buton.Size = new System.Drawing.Size(219, 31);
            this.decline_Buton.TabIndex = 6;
            this.decline_Buton.Text = "decline request";
            this.decline_Buton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.decline_Buton.Click += new System.EventHandler(this.decline_Buton_Click);
            // 
            // DerecognitionOfHours_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 384);
            this.Controls.Add(this.decline_Buton);
            this.Controls.Add(this.choose_Button);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tabPage1_label);
            this.Name = "DerecognitionOfHours_Form";
            this.Text = "DerecognitionOfHours_Form";
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
        private Design.Buttons.iTalk_Button_2 choose_Button;
        private Design.Buttons.iTalk_Button_2 decline_Buton;
    }
}