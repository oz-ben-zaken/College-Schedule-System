namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    partial class NewMinTimeBetweenClasses_Form
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(30, 58);
            this.hScrollBar1.Maximum = 60;
            this.hScrollBar1.Minimum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(222, 20);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(117, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose minimum time between classes";
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.Transparent;
            this.save_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.save_Button.ForeColor = System.Drawing.Color.White;
            this.save_Button.Image = null;
            this.save_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_Button.Location = new System.Drawing.Point(88, 117);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(110, 26);
            this.save_Button.TabIndex = 3;
            this.save_Button.Text = "Save";
            this.save_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // NewMinTimeBetweenClasses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "NewMinTimeBetweenClasses_Form";
            this.Text = "NewMinTimeBetweenClasses_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Design.Buttons.iTalk_Button_2 save_Button;
    }
}