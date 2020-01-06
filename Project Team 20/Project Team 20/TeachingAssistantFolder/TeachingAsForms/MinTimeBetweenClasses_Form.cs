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
    public partial class MinTimeBetweenClasses_Form : Form
    {
        private TeachingAssistant assistant;

        public MinTimeBetweenClasses_Form()
        {
            InitializeComponent();
        }
        public MinTimeBetweenClasses_Form(ref TeachingAssistant user)
        {
            if (user == null)
                user = new TeachingAssistant();
            this.assistant = user;
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private int numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            int curItem = (int)numericUpDown1.Value; //see what choose 0-4 hours
            return curItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int window = numericUpDown1_ValueChanged_1(sender, e);
            this.assistant.MinTimeBetweenClasses = window;
            MessageBox.Show("Saved successfully");
            this.Close();
        }
    }
}
