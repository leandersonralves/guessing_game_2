using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingAnimal2
{
    public partial class NewAnimalForm : Form
    {
        public NewAnimalForm()
        {
            InitializeComponent();
        }

        public string NewAnimalName { get { return textBoxNewAnimal.Text; } }

        private void yes_Click(object sender, EventArgs e)
        {
            var newAttributeAnimal = new NewAttributeForm();
            newAttributeAnimal.Show();
            Hide();
            newAttributeAnimal.FormClosed += (x, y) =>
            {
                Singleton.GameMechanics.AddNewAnimal(
                        NewAnimalName,
                        newAttributeAnimal.NewAnimalAttribute
                    );

                Singleton.GameMechanics.Restart();

                var mainMenu = new MainMenuForm();
                mainMenu.Show();
                Console.WriteLine(NewAnimalName + " " + newAttributeAnimal.NewAnimalAttribute);
                Close();
            };
        }
    }
}
