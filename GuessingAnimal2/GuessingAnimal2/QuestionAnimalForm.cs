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
    public partial class QuestionAnimalForm : Form
    {
        private const string LABEL_FORMAT = "Through my magic, the animal is {0}?";

        public QuestionAnimalForm()
        {
            InitializeComponent();
            labelQuestion.Text = string.Format(LABEL_FORMAT, Singleton.GameMechanics.GetValue);
        }
        
        private void yes_Click(object sender, EventArgs e)
        {
            Singleton.GameMechanics.Restart();
            var winForm = new WinForm();
            winForm.Show();
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            var newAnimalForm = new NewAnimalForm();
            newAnimalForm.Show();
            Close();
        }
    }
}
