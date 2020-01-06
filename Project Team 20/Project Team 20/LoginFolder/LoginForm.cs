using Project_Team_20.LoginFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20
{
    public partial class LoginForm : Form
    {
        private int progress;
        public LoginForm()
        {
            InitializeComponent();
            progress = 0;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle; // Make the splash sreen NOT resizable
            //LoadImageFromURL();
        }


        // The following function and variables are for moving the splash screen around
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            const int WM_NCHITTEST = 0x84;
            //const int HT_CLIENT = 0x1;
            const int HT_CAPTION = 0x2;
            
            switch(m.Msg)
            {
                case WM_NCHITTEST:
                    m.Result = (IntPtr)(HT_CAPTION);
                    break;
                case WM_NCLBUTTONDBLCLK:
                    m.Result = IntPtr.Zero;
                    return;
#pragma warning disable CS0162 // Unreachable code detected
                    break;
#pragma warning restore CS0162 // Unreachable code detected
                default:
                    break;
            }
            base.WndProc(ref m);
            /*   
           if (m.Msg == WM_NCLBUTTONDBLCLK)
           {
               m.Result = IntPtr.Zero;
               return;
           } */
            if (m.Msg == WM_NCHITTEST)
               m.Result = (IntPtr)(HT_CAPTION);
              

        }

        private void x_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_pictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            
            this.circularProgressBar.Value = 0;
            this.progress = 0;
            this.progressTimer.Enabled = true;
            this.progressTimer.Interval = 20;
            this.progressTimer.Start();
        }

        private void circularProgressBar_Load(object sender, EventArgs e)
        {

        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress >= 100)
            {
                this.progressTimer.Enabled = false;
                this.progressTimer.Stop();
                TryLogin();
            }          
            this.circularProgressBar.Value = progress;
        }
        public void CloseForm()
        {
            this.Hide();
            this.Dispose();
        }
        
        public Boolean TryLogin()
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(20, 60);
            

            if (password_textBox.Text == "" && username_textBox.Text == "")
            {
                this.progressTimer.Enabled = false;
                this.progressTimer.Stop();
                MessageBox.Show("Error: No username AND password were entered.\nTry again please.");
                return false;
            }

            else if (username_textBox.Text == "")
            {
                this.progressTimer.Enabled = false;
                this.progressTimer.Stop();
                MessageBox.Show("Error: No username was entered.\nTry again please.");
                return false;
            }

            else if (password_textBox.Text == "")
            {
                this.progressTimer.Enabled = false;
                this.progressTimer.Stop();
                MessageBox.Show("Error: No password was entered.\nTry again please.");
                return false;
            }
            String password = this.password_textBox.Text;
            String username = this.username_textBox.Text;

            LoginSQL loginSql = new LoginSQL(this);
            //this.Hide();
            loginSql.VerifyCredentials(username, password);

            return true;
        }
    }
}
