using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {private Random randome;
        public GenerateNameForm()
        {
            InitializeComponent();
        }
        private void  GenerateNames()
        {
            randome = new Random();
            int firstname = randome.Next(0, 50);
            int lastname = randome.Next(0, 50);
            FirstNameListBox.SelectedIndex = firstname;
            LastNamesListbox.SelectedIndex = lastname;
            FirstNametextBox.Text = FirstNameListBox.GetItemText(FirstNameListBox.SelectedItem);
            LastNameTextBox.Text = LastNamesListbox.GetItemText(LastNamesListbox.SelectedItem);
            Program.character.firstname = FirstNametextBox.Text;
            Program.character.lastname = LastNameTextBox.Text;



        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.firstname = FirstNametextBox.Text;
            Program.character.lastname = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();

           
        

    }
    }
}

