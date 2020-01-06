namespace Project_Team_20.LecturerFolder
{
    partial class SemestersToTeachLecturer_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.winter = new System.Windows.Forms.CheckBox();
            this.spring = new System.Windows.Forms.CheckBox();
            this.summer = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Choose 2 or 3 semesters";
            // 
            // winter
            // 
            this.winter.AutoSize = true;
            this.winter.Location = new System.Drawing.Point(106, 80);
            this.winter.Name = "winter";
            this.winter.Size = new System.Drawing.Size(54, 17);
            this.winter.TabIndex = 1;
            this.winter.Text = "winter";
            this.winter.UseVisualStyleBackColor = true;
            // 
            // spring
            // 
            this.spring.AutoSize = true;
            this.spring.Location = new System.Drawing.Point(106, 122);
            this.spring.Name = "spring";
            this.spring.Size = new System.Drawing.Size(54, 17);
            this.spring.TabIndex = 2;
            this.spring.Text = "spring";
            this.spring.UseVisualStyleBackColor = true;
            // 
            // summer
            // 
            this.summer.AutoSize = true;
            this.summer.Location = new System.Drawing.Point(106, 157);
            this.summer.Name = "summer";
            this.summer.Size = new System.Drawing.Size(62, 17);
            this.summer.TabIndex = 3;
            this.summer.Text = "summer";
            this.summer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SemestersToTeachLecturer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.summer);
            this.Controls.Add(this.spring);
            this.Controls.Add(this.winter);
            this.Controls.Add(this.textBox1);
            this.Name = "SemestersToTeachLecturer_Form";
            this.Text = "SemestersToTeachLecturer_Form";
            this.Load += new System.EventHandler(this.SemestersToTeachLecturer_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox winter;
        private System.Windows.Forms.CheckBox spring;
        private System.Windows.Forms.CheckBox summer;
        private System.Windows.Forms.Button button1;
    }
}