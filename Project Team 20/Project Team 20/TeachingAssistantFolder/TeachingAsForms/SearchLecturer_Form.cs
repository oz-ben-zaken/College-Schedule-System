using Project_Team_20.LecturerFolder;
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
    public partial class SearchLecturer_Form : Form
    {
        public SearchLecturer_Form()
        {
            InitializeComponent();
            select_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_comboBox.Items.Add("First Name");
            select_comboBox.Items.Add("Last Name");
            select_comboBox.Items.Add("ID");
            instruction_label.Visible = false;
            textBox.Visible = false;
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            TeachingAssistantSQL sql = new TeachingAssistantSQL();
            Lecturer lecturer = null;
            if (select_comboBox.Text == "First Name")
            {
                lecturer = sql.SearchLecturer("firstName", textBox.Text);
            }
            else if (select_comboBox.Text == "Last Name")
            {
                lecturer = sql.SearchLecturer("lastName", textBox.Text);
            }
            else if (select_comboBox.Text == "ID")
            {
                lecturer = sql.SearchLecturer("ID", textBox.Text);
            }

            if (lecturer != null)
            {
                String message = "Search Results:\n";
                message += "First Name: " + lecturer.FirstName + "\n";
                message += "Last Name: " + lecturer.LastName + "\n";
                message += "ID: " + lecturer.Id + "\n";
                message += "Age: " + lecturer.Age + "\n";
                message += "Username: " + lecturer.Username + "\n";
                MessageBox.Show(message);
            }
            else
                MessageBox.Show("No results were found.");
        }

        private void select_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_comboBox.Text == "First Name")
            {
                instruction_label.Text = "Enter the first name to search:";
                instruction_label.Visible = true;
                textBox.Visible = true;
            }
            else if (select_comboBox.Text == "Last Name")
            {
                instruction_label.Text = "Enter the last name to search:";
                instruction_label.Visible = true;
                textBox.Visible = true;
            }
            else if (select_comboBox.Text == "ID")
            {
                instruction_label.Text = "Enter the ID to search:";
                instruction_label.Visible = true;
                textBox.Visible = true;
            }
        }
    }
}
