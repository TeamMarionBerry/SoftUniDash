using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftUniDash
{
    public partial class FormCharacterCreator : Form
    {
        public FormCharacterCreator()
        {
            InitializeComponent();
        }

        private void ButtonCreateCharacter_Click(object sender, EventArgs e)
        {
            // Chech if the form is not empty
            if (String.IsNullOrEmpty(TextBoxCharacterName.Text))
            {
                MessageBox.Show("Enter a character name.");
                // back to the form with return!
                return;
            }
            else if (ComboBoxCharacterClass.SelectedItem == null)
            {
                MessageBox.Show("Enter a character class.");
                return;
            }
            else
            {
                var game = new FormGameScreen();
                game.PassPlayerName = TextBoxCharacterName.Text;
                game.PassClassType = ComboBoxCharacterClass.SelectedItem.ToString();
                game.Show();
            }

            //var chacarterData = new StringBuilder();
            //chacarterData.AppendLine("Name: " + TextBoxCharacterName.Text);
            //chacarterData.Append("Class: " + ComboBoxCharacterClass.Text);
            //// Test getting the data
            //MessageBox.Show(chacarterData.ToString())
        }
    }
}