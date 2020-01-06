namespace Project_Team_20.TeachingAssistant_Folder
{
    partial class SemestersToTeach_Form
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
            this.winter = new System.Windows.Forms.CheckBox();
            this.spring = new System.Windows.Forms.CheckBox();
            this.summer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iTalk_Button_21 = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.SuspendLayout();
            // 
            // winter
            // 
            this.winter.AutoSize = true;
            this.winter.Location = new System.Drawing.Point(104, 62);
            this.winter.Margin = new System.Windows.Forms.Padding(2);
            this.winter.Name = "winter";
            this.winter.Size = new System.Drawing.Size(57, 17);
            this.winter.TabIndex = 0;
            this.winter.Text = "Winter";
            this.winter.UseVisualStyleBackColor = true;
            // 
            // spring
            // 
            this.spring.AutoSize = true;
            this.spring.Location = new System.Drawing.Point(104, 104);
            this.spring.Margin = new System.Windows.Forms.Padding(2);
            this.spring.Name = "spring";
            this.spring.Size = new System.Drawing.Size(56, 17);
            this.spring.TabIndex = 1;
            this.spring.Text = "Spring";
            this.spring.UseVisualStyleBackColor = true;
            // 
            // summer
            // 
            this.summer.AutoSize = true;
            this.summer.Location = new System.Drawing.Point(104, 146);
            this.summer.Margin = new System.Windows.Forms.Padding(2);
            this.summer.Name = "summer";
            this.summer.Size = new System.Drawing.Size(64, 17);
            this.summer.TabIndex = 2;
            this.summer.Text = "Summer";
            this.summer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose 2 semesters";
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(90, 190);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(70, 25);
            this.iTalk_Button_21.TabIndex = 5;
            this.iTalk_Button_21.Text = "Save";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // SemestersToTeach_Form
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(292, 247);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summer);
            this.Controls.Add(this.spring);
            this.Controls.Add(this.winter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SemestersToTeach_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SemestersToTeach_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.CheckBox winter;
        protected System.Windows.Forms.CheckBox spring;
        protected System.Windows.Forms.CheckBox summer;
        private Design.Buttons.iTalk_Button_2 iTalk_Button_21;
    }
}