using System.Collections.Generic;

namespace GuessingAnimal2
{
    public class GameMechanics
    {
        private interface IData
        {
            string content { get; }
        }

        private class Question : IData
        {
            public string content { get; private set; }
            public Question (string content)
            {
                this.content = content;
            }
        }

        private class Animal : IData
        {
            public string content { get; private set; }
            public Animal (string name)
            {
                content = name;
            }
        }

        private BinaryTree<IData> data;

        public GameMechanics()
        {
            data = new BinaryTree<IData>(
                new NodeTree<IData>(
                    new Question("late")
                    ));

            data.AddLeft(new NodeTree<IData>(new Animal("Cachorro")));
        }

        public void Restart()
        {
            data.CurrentSelected = data.Root;
        }

        public void AddNewAnimal (string animal, string attribute)
        {
            var newNode = new NodeTree<IData>(new Question(attribute));
            newNode.Left = new NodeTree<IData>(new Question(animal));
            newNode.Right = data.CurrentSelected.Left;
            data.CurrentSelected.Left = newNode;
        }

        public void SelectYes ()
        {
            data.SelectLeft();
        }


        public void SelectNo()
        {
            data.SelectRight();
        }

        public bool IsAnimal { get { return data.CurrentSelected is Animal; } }

        public string GetData
        {
            get{
                return (data.CurrentSelected as IData).content;
            }
        }
    }
}
