namespace Project_Team_20
{
    partial class BasicUser_Form
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
            this.RegisterBasicUser_button = new System.Windows.Forms.Button();
            this.EditDetails_BasicUser_button = new System.Windows.Forms.Button();
            this.DisplayReceived_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterBasicUser_button
            // 
            this.RegisterBasicUser_button.Location = new System.Drawing.Point(16, 15);
            this.RegisterBasicUser_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegisterBasicUser_button.Name = "RegisterBasicUser_button";
            this.RegisterBasicUser_button.Size = new System.Drawing.Size(172, 28);
            this.RegisterBasicUser_button.TabIndex = 0;
            this.RegisterBasicUser_button.Text = "Register BasicUser";
            this.RegisterBasicUser_button.UseVisualStyleBackColor = true;
            this.RegisterBasicUser_button.Click += new System.EventHandler(this.RegisterBasicUser_button_Click);
            // 
            // EditDetails_BasicUser_button
            // 
            this.EditDetails_BasicUser_button.Location = new System.Drawing.Point(17, 52);
            this.EditDetails_BasicUser_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditDetails_BasicUser_button.Name = "EditDetails_BasicUser_button";
            this.EditDetails_BasicUser_button.Size = new System.Drawing.Size(171, 28);
            this.EditDetails_BasicUser_button.TabIndex = 1;
            this.EditDetails_BasicUser_button.Text = "Edit Details";
            this.EditDetails_BasicUser_button.UseVisualStyleBackColor = true;
            this.EditDetails_BasicUser_button.Click += new System.EventHandler(this.EditDetails_BasicUser_button_Click);
            // 
            // DisplayReceived_button
            // 
            this.DisplayReceived_button.Location = new System.Drawing.Point(72, 133);
            this.DisplayReceived_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayReceived_button.Name = "DisplayReceived_button";
            this.DisplayReceived_button.Size = new System.Drawing.Size(100, 28);
            this.DisplayReceived_button.TabIndex = 2;
            this.DisplayReceived_button.Text = " Display Received User";
            this.DisplayReceived_button.UseVisualStyleBackColor = true;
            this.DisplayReceived_button.Click += new System.EventHandler(this.DisplayReceived_button_Click);
            // 
            // BasicUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.DisplayReceived_button);
            this.Controls.Add(this.EditDetails_BasicUser_button);
            this.Controls.Add(this.RegisterBasicUser_button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BasicUser_Form";
            this.Text = "BasicUser_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterBasicUser_button;
        private System.Windows.Forms.Button EditDetails_BasicUser_button;
        private System.Windows.Forms.Button DisplayReceived_button;
    }
}