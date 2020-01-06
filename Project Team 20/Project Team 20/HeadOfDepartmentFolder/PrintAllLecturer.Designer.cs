namespace Project_Team_20.HeadOfDepartmentFolder
{
    partial class PrintAllLecturer
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.id,
            this.age,
            this.userName});
            this.listView1.Location = new System.Drawing.Point(13, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 339);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.Text = "firstName";
            // 
            // lastName
            // 
            this.lastName.Text = "lastName";
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // age
            // 
            this.age.Text = "age";
            // 
            // userName
            // 
            this.userName.Text = "userName";
            // 
            // PrintAllLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 379);
            this.Controls.Add(this.listView1);
            this.Name = "PrintAllLecturer";
            this.Text = "PrintAllLecturer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader firstName;
        public System.Windows.Forms.ColumnHeader lastName;
        public System.Windows.Forms.ColumnHeader id;
        public System.Windows.Forms.ColumnHeader age;
        public System.Windows.Forms.ColumnHeader userName;
    }
}