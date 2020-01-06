using Project_Team_20.HeadOfDepartmentFolder;
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
    public partial class BasicUser_Registration_Form : Form
    {
        private BasicUser basicUser;
        private Boolean isRegistration;
        public BasicUser_Registration_Form(ref BasicUser user, Boolean isRegistration)
        {
            this.basicUser = user;
            this.isRegistration = isRegistration;
            //this.FormClosed += new FormClosedEventHandler();
            InitializeComponent();
            if (basicUser.Id != null)
            {
                FirstName_textBox.Text = basicUser.FirstName;
                LastName_textBox.Text = basicUser.LastName;
                textBox1.Text = basicUser.Id;
                textBox1.ReadOnly = true;
                Age_textBox.Text = ""+basicUser.Age;
                Username_textBox.Text = basicUser.Username;
                Password_textBox.Text = basicUser.Password;
            }
        }


        private void Register_button_Click(object sender, EventArgs e)
        { 
            bool flag = true;
            if (basicUser.EnterIntInput(FirstName_textBox.Text) == false || FirstName_textBox.Text.Length == 0)
            {
                FNameError_label.Show();
                flag = false;
            }
            if (basicUser.EnterIntInput(LastName_textBox.Text) == false || LastName_textBox.Text.Length == 0)
            {
                LNameError_label.Show();
                flag = false;
            }
            if (basicUser.EnterIDInput(textBox1.Text) == false)
            {
                IDError_label.Show();
                flag = false;
            }
            else if(isRegistration == true && HeadOfDepartmentSQL.DoesIdExists(textBox1.Text) == true)
            {
                IDError_label.Text = "ID already exists in the system";
                IDError_label.Show();
                flag = false;
            }

            int age;
            try
            {
                age = int.Parse(Age_textBox.Text);
                if (basicUser.EnterAgeInput(age) == false)
                {
                    AgeError_label.Show();
                    flag = false;
                }
            }
            catch (System.IO.IOException ex)
            {
                AgeError_label.Show();
                flag = false;
                ex.GetType();
            }
            catch (Exception ex)
            {
                AgeError_label.Show();
                flag = false;
                ex.GetType();
            }
            if (basicUser.EnterUsernamePassInput(Username_textBox.Text) == false 
                || Username_textBox.Text.Length == 0) //username
            {
                UsernameError_label.Show();
                flag = false;
            }
            if (basicUser.EnterUsernamePassInput(Password_textBox.Text) == false 
                || Password_textBox.Text.Length == 0) // pass
            {
                PassError_label.Show();
                flag = false;
            }

            if (flag == false)
                MessageBox.Show("Wrong entery(ies), try again please.");
            else
            {
                if (basicUser.Id!=null)
                    MessageBox.Show("Registered successfully.");
                basicUser.FirstName = FirstName_textBox.Text;
                basicUser.LastName = LastName_textBox.Text;
                basicUser.Id = textBox1.Text;
                basicUser.Age = int.Parse(Age_textBox.Text);
                basicUser.Username = Username_textBox.Text;
                basicUser.Password = Password_textBox.Text;
                this.Close();
            }
        }

        private void FirstName_label_Click(object sender, EventArgs e)
        {

        }
    }
}
