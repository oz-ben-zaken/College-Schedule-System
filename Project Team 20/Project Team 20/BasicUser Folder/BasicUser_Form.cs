using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_Team_20
{
    
    public partial class BasicUser_Form : Form
    {
        BasicUser basicUser;
        private BasicUser_Registration_Form regForm;
        public BasicUser_Form(ref BasicUser user)
        {
            this.basicUser = user;
            InitializeComponent();
        }

        private void RegisterBasicUser_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.regForm = new BasicUser_Registration_Form(ref basicUser, true);
            regForm.FormClosed += new FormClosedEventHandler(RegForm_FormClosed);           
            regForm.ShowDialog();
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.regForm.Close();
            this.regForm = null;
            this.Show();
        }

        private void DisplayReceived_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("First name = {0}, last name = {1}, id= {2}, password = {3}", basicUser.FirstName, basicUser.LastName, basicUser.Id, basicUser.Password));
        }

        private void EditDetails_BasicUser_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.regForm = new BasicUser_Registration_Form(ref basicUser, false);
            regForm.FormClosed += new FormClosedEventHandler(RegForm_FormClosed);
            regForm.ShowDialog();
        }
    }
}
