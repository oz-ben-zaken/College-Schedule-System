namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class AddWorker_Form
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
            this.TeachingAssist = new System.Windows.Forms.Button();
            this.Lecturer = new System.Windows.Forms.Button();
            this.Secretary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeachingAssist
            // 
            this.TeachingAssist.Location = new System.Drawing.Point(12, 64);
            this.TeachingAssist.Name = "TeachingAssist";
            this.TeachingAssist.Size = new System.Drawing.Size(116, 44);
            this.TeachingAssist.TabIndex = 0;
            this.TeachingAssist.Text = "TeachingAssist";
            this.TeachingAssist.UseVisualStyleBackColor = true;
            this.TeachingAssist.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lecturer
            // 
            this.Lecturer.Location = new System.Drawing.Point(140, 64);
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Size = new System.Drawing.Size(116, 45);
            this.Lecturer.TabIndex = 1;
            this.Lecturer.Text = "Lecturer";
            this.Lecturer.UseVisualStyleBackColor = true;
            this.Lecturer.Click += new System.EventHandler(this.Lecturer_Click);
            // 
            // Secretary
            // 
            this.Secretary.Location = new System.Drawing.Point(271, 64);
            this.Secretary.Name = "Secretary";
            this.Secretary.Size = new System.Drawing.Size(116, 45);
            this.Secretary.TabIndex = 2;
            this.Secretary.Text = "Secretary";
            this.Secretary.UseVisualStyleBackColor = true;
            this.Secretary.Click += new System.EventHandler(this.Secretary_Click);
            // 
            // AddWorker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 174);
            this.Controls.Add(this.Secretary);
            this.Controls.Add(this.Lecturer);
            this.Controls.Add(this.TeachingAssist);
            this.Name = "AddWorker_Form";
            this.Text = "AddWorker_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TeachingAssist;
        private System.Windows.Forms.Button Lecturer;
        private System.Windows.Forms.Button Secretary;
    }
}