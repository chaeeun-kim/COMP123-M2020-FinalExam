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
       //<private method GenerateNames>
       //it creats randome number and then set randomly picked numbers to the selectedindex of listbox.
       //the selected items of listbox will fill out text property of textbox controls.
        private void  GenerateNames()
        {
            randome = new Random();
            int firstname = randome.Next(0, 50);
            int lastname = randome.Next(0, 50);
            FirstNameListBox.SelectedIndex = firstname;
            LastNamesListbox.SelectedIndex = lastname;
            FirstNametextBox.Text = FirstNameListBox.GetItemText(FirstNameListBox.SelectedItem);
            LastNameTextBox.Text = LastNamesListbox.GetItemText(LastNamesListbox.SelectedItem);
          
        }

        // <GenerateNameForm_Load event handler>
        //when GernerateNameForm is loaded, GenerateNames method is called
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        //< GenerateButton_click event handler>
        //when GenerateButton is clicked,  GenerateNames method is called and set the value of the properties
        //( firstname,lastname) of the Program.character object to the value of text property of the TextBox control
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.firstname = FirstNametextBox.Text;
            Program.character.lastname = LastNameTextBox.Text;
        }

        //<NextButton_click event handler>
        //when NextButton is clicked, it will show abilitygeneratorform and hide GenerateNameform
       
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();

           
        

    }
    }
}

