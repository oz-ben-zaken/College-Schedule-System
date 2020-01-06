namespace Project_Team_20
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.x_pictureBox = new System.Windows.Forms.PictureBox();
            this.minimize_pictureBox = new System.Windows.Forms.PictureBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar = new Project_Team_20.Design.ProgressBar.CircularProgressBar();
            this.login_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            ((System.ComponentModel.ISupportInitialize)(this.x_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // x_pictureBox
            // 
            this.x_pictureBox.Image = global::Project_Team_20.Properties.Resources._020;
            this.x_pictureBox.Location = new System.Drawing.Point(203, 12);
            this.x_pictureBox.Name = "x_pictureBox";
            this.x_pictureBox.Size = new System.Drawing.Size(31, 18);
            this.x_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.x_pictureBox.TabIndex = 0;
            this.x_pictureBox.TabStop = false;
            this.x_pictureBox.Click += new System.EventHandler(this.x_pictureBox_Click);
            // 
            // minimize_pictureBox
            // 
            this.minimize_pictureBox.Image = global::Project_Team_20.Properties.Resources._022;
            this.minimize_pictureBox.Location = new System.Drawing.Point(166, 12);
            this.minimize_pictureBox.Name = "minimize_pictureBox";
            this.minimize_pictureBox.Size = new System.Drawing.Size(31, 18);
            this.minimize_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_pictureBox.TabIndex = 1;
            this.minimize_pictureBox.TabStop = false;
            this.minimize_pictureBox.Click += new System.EventHandler(this.minimize_pictureBox_Click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(16, 113);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(55, 13);
            this.Username_label.TabIndex = 2;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(16, 150);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(75, 113);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(100, 20);
            this.username_textBox.TabIndex = 4;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(75, 150);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 20);
            this.password_textBox.TabIndex = 5;
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularProgressBar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.circularProgressBar.Location = new System.Drawing.Point(63, 229);
            this.circularProgressBar.Maximum = ((long)(100));
            this.circularProgressBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.circularProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.circularProgressBar.ProgressShape = Project_Team_20.Design.ProgressBar.CircularProgressBar._ProgressShape.Round;
            this.circularProgressBar.Size = new System.Drawing.Size(112, 112);
            this.circularProgressBar.TabIndex = 8;
            this.circularProgressBar.Value = ((long)(0));
            this.circularProgressBar.Load += new System.EventHandler(this.circularProgressBar_Load);
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.Transparent;
            this.login_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.login_Button.ForeColor = System.Drawing.Color.White;
            this.login_Button.Image = null;
            this.login_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_Button.Location = new System.Drawing.Point(75, 203);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(100, 20);
            this.login_Button.TabIndex = 7;
            this.login_Button.Text = "Login";
            this.login_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(240, 347);
            this.ControlBox = false;
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.minimize_pictureBox);
            this.Controls.Add(this.x_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.x_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x_pictureBox;
        private System.Windows.Forms.PictureBox minimize_pictureBox;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private Design.Buttons.iTalk_Button_2 login_Button;
        private Design.ProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Timer progressTimer;
    }
}