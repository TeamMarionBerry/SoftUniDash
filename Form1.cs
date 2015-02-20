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
    public partial class FormMenuUIScreen : Form
    {
        public FormMenuUIScreen()
        {
            InitializeComponent();
        }

        private void ButtonCreateCharacter_Click(object sender, EventArgs e)
        {
            // show the new form for character create
            var characterCreator = new FormCharacterCreator();
            characterCreator.Show();
        }

        private void FormMenuUIScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
