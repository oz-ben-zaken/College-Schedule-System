namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class DeleteWorker_Form
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
            System.Windows.Forms.ColumnHeader job;
            this.listView1 = new System.Windows.Forms.ListView();
            this.first_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.last_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteWorker_button = new System.Windows.Forms.Button();
            this.Edit_Worker = new System.Windows.Forms.Button();
            job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // job
            // 
            job.Text = "job";
            job.Width = 125;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.first_name,
            this.last_name,
            this.id,
            this.age,
            this.user_name,
            job});
            this.listView1.Location = new System.Drawing.Point(16, 50);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 330);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // first_name
            // 
            this.first_name.Text = "first name";
            this.first_name.Width = 70;
            // 
            // last_name
            // 
            this.last_name.Text = "last name";
            this.last_name.Width = 73;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 66;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.Width = 37;
            // 
            // user_name
            // 
            this.user_name.Text = "user name";
            this.user_name.Width = 75;
            // 
            // DeleteWorker_button
            // 
            this.DeleteWorker_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWorker_button.Location = new System.Drawing.Point(234, 387);
            this.DeleteWorker_button.Name = "DeleteWorker_button";
            this.DeleteWorker_button.Size = new System.Drawing.Size(134, 44);
            this.DeleteWorker_button.TabIndex = 1;
            this.DeleteWorker_button.Text = "delete";
            this.DeleteWorker_button.UseVisualStyleBackColor = true;
            this.DeleteWorker_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit_Worker
            // 
            this.Edit_Worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Worker.Location = new System.Drawing.Point(234, 387);
            this.Edit_Worker.Name = "Edit_Worker";
            this.Edit_Worker.Size = new System.Drawing.Size(134, 44);
            this.Edit_Worker.TabIndex = 2;
            this.Edit_Worker.Text = "edit";
            this.Edit_Worker.UseVisualStyleBackColor = true;
            this.Edit_Worker.Click += new System.EventHandler(this.Edit_Worker_Click);
            // 
            // DeleteWorker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 437);
            this.Controls.Add(this.Edit_Worker);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DeleteWorker_button);
            this.Name = "DeleteWorker_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "workers list";
            this.Load += new System.EventHandler(this.DeleteWorker_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button DeleteWorker_button;
        private System.Windows.Forms.ColumnHeader first_name;
        private System.Windows.Forms.ColumnHeader last_name;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader user_name;
        private System.Windows.Forms.Button Edit_Worker;
    }
}