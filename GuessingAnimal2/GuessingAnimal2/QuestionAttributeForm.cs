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
    public partial class QuestionAttributeForm : Form
    {
        private const string LABEL_FORMAT = "Does the animal {0}?";

        public QuestionAttributeForm()
        {
            InitializeComponent();
            var x = string.Format(LABEL_FORMAT, Singleton.GameMechanics.GetValue);
            labelQuestion.Text = x;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Singleton.GameMechanics.SelectYes();

            if (Singleton.GameMechanics.IsAnimal)
            {
                var questionAnimalForm = new QuestionAnimalForm();
                questionAnimalForm.Show();
                Close();
            }
            else
            {
                var questionAttributeForm = new QuestionAttributeForm();
                questionAttributeForm.Show();
                Close();
            }
        }

        private void no_Click(object sender, EventArgs e)
        {
            Singleton.GameMechanics.SelectNo();

            if (Singleton.GameMechanics.IsAnimal)
            {
                var questionAnimalForm = new QuestionAnimalForm();
                questionAnimalForm.Show();
                Close();
            }
            else
            {
                var questionAttributeForm = new QuestionAttributeForm();
                questionAttributeForm.Show();
                Close();
            }
        }
    }
}
