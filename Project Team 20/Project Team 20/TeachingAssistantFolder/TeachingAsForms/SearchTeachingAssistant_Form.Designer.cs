namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    partial class SearchTeachingAssistant_Form
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
            this.select_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instruction_label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.search_Button = new Project_Team_20.Design.Buttons.iTalk_Button_2();
            this.SuspendLayout();
            // 
            // select_comboBox
            // 
            this.select_comboBox.FormattingEnabled = true;
            this.select_comboBox.Location = new System.Drawing.Point(78, 35);
            this.select_comboBox.Name = "select_comboBox";
            this.select_comboBox.Size = new System.Drawing.Size(121, 21);
            this.select_comboBox.TabIndex = 0;
            this.select_comboBox.SelectedIndexChanged += new System.EventHandler(this.select_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By:";
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Location = new System.Drawing.Point(13, 98);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(35, 13);
            this.instruction_label.TabIndex = 2;
            this.instruction_label.Text = "label2";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(78, 134);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(121, 20);
            this.textBox.TabIndex = 3;
            // 
            // search_Button
            // 
            this.search_Button.BackColor = System.Drawing.Color.Transparent;
            this.search_Button.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.search_Button.ForeColor = System.Drawing.Color.White;
            this.search_Button.Image = null;
            this.search_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_Button.Location = new System.Drawing.Point(78, 188);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(111, 28);
            this.search_Button.TabIndex = 4;
            this.search_Button.Text = "Search";
            this.search_Button.TextAlignment = System.Drawing.StringAlignment.Center;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // SearchTeachingAssistant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.instruction_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_comboBox);
            this.Name = "SearchTeachingAssistant_Form";
            this.Text = "SearchTeachingAssistant_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.TextBox textBox;
        private Design.Buttons.iTalk_Button_2 search_Button;
    }
}