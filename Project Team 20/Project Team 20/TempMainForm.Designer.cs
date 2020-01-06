using System.Drawing;

namespace Project_Team_20
{
    partial class TempMainForm
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
            this.Secretary_Menu = new System.Windows.Forms.Button();
            this.HeadOfDepartment_Menu = new System.Windows.Forms.Button();
            this.Lecturer_Menu = new System.Windows.Forms.Button();
            this.TeachingAssistant_Menu = new System.Windows.Forms.Button();
            this.TestSQLConnection_button = new System.Windows.Forms.Button();
            this.newSql_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Secretary_Menu
            // 
            this.Secretary_Menu.Location = new System.Drawing.Point(29, 215);
            this.Secretary_Menu.Name = "Secretary_Menu";
            this.Secretary_Menu.Size = new System.Drawing.Size(75, 35);
            this.Secretary_Menu.TabIndex = 1;
            this.Secretary_Menu.Text = "Secretary Menu";
            this.Secretary_Menu.UseVisualStyleBackColor = true;
            this.Secretary_Menu.Click += new System.EventHandler(this.Secretary_Menu_Click);
            // 
            // HeadOfDepartment_Menu
            // 
            this.HeadOfDepartment_Menu.Location = new System.Drawing.Point(29, 12);
            this.HeadOfDepartment_Menu.Name = "HeadOfDepartment_Menu";
            this.HeadOfDepartment_Menu.Size = new System.Drawing.Size(75, 48);
            this.HeadOfDepartment_Menu.TabIndex = 2;
            this.HeadOfDepartment_Menu.Text = "Head Of Department Menu";
            this.HeadOfDepartment_Menu.UseVisualStyleBackColor = true;
            this.HeadOfDepartment_Menu.Click += new System.EventHandler(this.HeadOfDepartment_Menu_Click);
            // 
            // Lecturer_Menu
            // 
            this.Lecturer_Menu.Location = new System.Drawing.Point(29, 81);
            this.Lecturer_Menu.Name = "Lecturer_Menu";
            this.Lecturer_Menu.Size = new System.Drawing.Size(75, 36);
            this.Lecturer_Menu.TabIndex = 3;
            this.Lecturer_Menu.Text = "Lecturer Menu";
            this.Lecturer_Menu.UseVisualStyleBackColor = true;
            this.Lecturer_Menu.Click += new System.EventHandler(this.Lecturer_Menu_Click);
            // 
            // TeachingAssistant_Menu
            // 
            this.TeachingAssistant_Menu.Location = new System.Drawing.Point(29, 136);
            this.TeachingAssistant_Menu.Name = "TeachingAssistant_Menu";
            this.TeachingAssistant_Menu.Size = new System.Drawing.Size(75, 58);
            this.TeachingAssistant_Menu.TabIndex = 4;
            this.TeachingAssistant_Menu.Text = "Teaching Assistant Menu";
            this.TeachingAssistant_Menu.UseVisualStyleBackColor = true;
            this.TeachingAssistant_Menu.Click += new System.EventHandler(this.TeachingAssistant_Menu_Click);
            // 
            // TestSQLConnection_button
            // 
            this.TestSQLConnection_button.BackColor = System.Drawing.Color.DimGray;
            this.TestSQLConnection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestSQLConnection_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TestSQLConnection_button.Location = new System.Drawing.Point(184, 75);
            this.TestSQLConnection_button.Name = "TestSQLConnection_button";
            this.TestSQLConnection_button.Size = new System.Drawing.Size(75, 42);
            this.TestSQLConnection_button.TabIndex = 6;
            this.TestSQLConnection_button.Text = "Test SQL Connection";
            this.TestSQLConnection_button.UseVisualStyleBackColor = true;
            this.TestSQLConnection_button.Click += new System.EventHandler(this.TestSQLConnection_button_Click);
            // 
            // newSql_button
            // 
            this.newSql_button.Location = new System.Drawing.Point(184, 136);
            this.newSql_button.Name = "newSql_button";
            this.newSql_button.Size = new System.Drawing.Size(75, 35);
            this.newSql_button.TabIndex = 7;
            this.newSql_button.Text = "Test New Sql";
            this.newSql_button.UseVisualStyleBackColor = true;
            this.newSql_button.Click += new System.EventHandler(this.newSql_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(184, 205);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 8;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // TempMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.newSql_button);
            this.Controls.Add(this.TestSQLConnection_button);
            this.Controls.Add(this.TeachingAssistant_Menu);
            this.Controls.Add(this.Lecturer_Menu);
            this.Controls.Add(this.HeadOfDepartment_Menu);
            this.Controls.Add(this.Secretary_Menu);
            this.Name = "TempMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Secretary_Menu;
        private System.Windows.Forms.Button HeadOfDepartment_Menu;
        private System.Windows.Forms.Button Lecturer_Menu;
        private System.Windows.Forms.Button TeachingAssistant_Menu;
        private System.Windows.Forms.Button TestSQLConnection_button;
        private System.Windows.Forms.Button newSql_button;
        private System.Windows.Forms.Button Login_button;
    }
}

