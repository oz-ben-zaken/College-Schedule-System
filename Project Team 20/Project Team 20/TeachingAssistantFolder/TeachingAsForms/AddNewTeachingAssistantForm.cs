using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.TeachingAssistant_Folder
{
    public partial class AddNewTeachingAssistantForm : Form
    {
        public AddNewTeachingAssistantForm()
        {
            InitializeComponent();       
        }
        public void CallBasicUserRegisteration()
        {
            this.Hide();
            BasicUser newUser = null;
            BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref newUser, true);
            regForm.ShowDialog();
            this.Close();
        }


    }
}
