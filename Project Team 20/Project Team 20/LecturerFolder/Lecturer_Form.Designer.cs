namespace Project_Team_20.LecturerFolder
{
    partial class Lecturer_Form
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(
                TeachingAssist_Form_FormClosing);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.Text = "Lecturer Preferences:";
            // 
            // PrintDetails_button1
            // 
            this.PrintDetails_button1.Text = "Print Details";
            // 
            // Lecturer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(410, 430);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lecturer_Form";
            this.Text = "Lecturer_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lecturer_Form_Closing);
            this.Load += new System.EventHandler(this.Lecturer_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}