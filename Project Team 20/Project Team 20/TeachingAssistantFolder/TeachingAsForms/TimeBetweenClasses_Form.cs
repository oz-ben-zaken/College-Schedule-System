using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    public partial class TimeBetweenClasses_Form : Form
    {
        private TeachingAssistant teachingAssist;
        public TimeBetweenClasses_Form(ref TeachingAssistant teachingAssist)
        {
            InitializeComponent();
            this.teachingAssist = teachingAssist;
            textBox.Text = hScrollBar1.Value.ToString();
            textBox.Enabled = false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox.Text = hScrollBar1.Value.ToString();
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your minimum time between classes was saved successfully.");
            this.teachingAssist.MinTimeBetweenClasses = hScrollBar1.Value;
            this.Dispose();
        }
    }
}
