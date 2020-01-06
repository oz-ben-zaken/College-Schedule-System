namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    partial class ChooseHoursToTeach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.from_hour_textBox = new System.Windows.Forms.TextBox();
            this.from_minutes_textBox = new System.Windows.Forms.TextBox();
            this.to_hour_textBox = new System.Windows.Forms.TextBox();
            this.to_minutes_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose hours to teach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Image = null;
            this.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_button.Location = new System.Drawing.Point(52, 177);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(105, 23);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Save";
            this.save_button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // from_hour_textBox
            // 
            this.from_hour_textBox.Location = new System.Drawing.Point(52, 53);
            this.from_hour_textBox.Name = "from_hour_textBox";
            this.from_hour_textBox.Size = new System.Drawing.Size(31, 20);
            this.from_hour_textBox.TabIndex = 6;
            // 
            // from_minutes_textBox
            // 
            this.from_minutes_textBox.Location = new System.Drawing.Point(91, 53);
            this.from_minutes_textBox.Name = "from_minutes_textBox";
            this.from_minutes_textBox.Size = new System.Drawing.Size(31, 20);
            this.from_minutes_textBox.TabIndex = 7;
            // 
            // to_hour_textBox
            // 
            this.to_hour_textBox.Location = new System.Drawing.Point(52, 100);
            this.to_hour_textBox.Name = "to_hour_textBox";
            this.to_hour_textBox.Size = new System.Drawing.Size(31, 20);
            this.to_hour_textBox.TabIndex = 8;
            // 
            // to_minutes_textBox
            // 
            this.to_minutes_textBox.Location = new System.Drawing.Point(91, 100);
            this.to_minutes_textBox.Name = "to_minutes_textBox";
            this.to_minutes_textBox.Size = new System.Drawing.Size(31, 20);
            this.to_minutes_textBox.TabIndex = 9;
            // 
            // ChooseHoursToTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 262);
            this.Controls.Add(this.to_minutes_textBox);
            this.Controls.Add(this.to_hour_textBox);
            this.Controls.Add(this.from_minutes_textBox);
            this.Controls.Add(this.from_hour_textBox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChooseHoursToTeach";
            this.Text = "ChooseHoursToTeach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Design.Buttons.iTalk_Button_2 save_button;
        private System.Windows.Forms.TextBox from_hour_textBox;
        private System.Windows.Forms.TextBox from_minutes_textBox;
        private System.Windows.Forms.TextBox to_hour_textBox;
        private System.Windows.Forms.TextBox to_minutes_textBox;
    }
}