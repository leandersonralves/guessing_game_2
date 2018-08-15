using System.Collections.Generic.Tree.Binary;

namespace GuessingAnimal2
{
    /// <summary>
    /// Classe da mecânica do jogo.
    /// </summary>
    public class GameMechanics
    {
        /// <summary>
        /// Classe que representa uma característica do animal.
        /// </summary>
        private class Attribute : Node<string>
        {
            public Attribute(string value) : base(value)
            {
                this.Value = value;
            }
        }

        /// <summary>
        /// Classe que representa o animal.
        /// </summary>
        private class Animal : Node<string>
        {
            public Animal(string value) : base(value)
            {
                this.Value = value;
            }
        }

        /// <summary>
        /// Arvore binária das características, onde uma leaf é um animal.
        /// </summary>
        private Tree<Node<string>, string> treeData;

        public GameMechanics()
        {
            var nodeRoot = new Attribute("lives in water");
            nodeRoot.Left = new Animal("shark");
            nodeRoot.Right = new Animal("monkey");

            treeData = new Tree<Node<string>, string>(nodeRoot);
        }

        /// <summary>
        /// Redefine a seleção para o root.
        /// </summary>
        public void Restart()
        {
            treeData.ResetSelect();
        }

        /// <summary>
        /// Adiciona um animal entre o atual selecionado, e o nó pai desse.
        /// </summary>
        /// <param name="animal">Nome do animal</param>
        /// <param name="attribute">Característica</param>
        public void AddNewAnimal (string animal, string attribute)
        {
            var newNode = new Attribute(attribute);
            newNode.Left = new Animal(animal);
            if (treeData.CurrentSelected.Root.Left == treeData.CurrentSelected)
            {
                treeData.CurrentSelected.Root.Left = newNode;
            }
            else if (treeData.CurrentSelected.Root.Right == treeData.CurrentSelected)
            {
                treeData.CurrentSelected.Root.Right = newNode;
            }
            newNode.Root = treeData.CurrentSelected.Root;
            newNode.Right = treeData.CurrentSelected;
        }

        /// <summary>
        /// Seleciona o Nó do lado esquerdo. Seleção do Yes.
        /// </summary>
        public void SelectYes ()
        {
            treeData.SelectLeft();
        }


        /// <summary>
        /// Seleciona o Nó do lado direito. Seleção do No.
        /// </summary>
        public void SelectNo()
        {
            treeData.SelectRight();
        }

        /// <summary>
        /// Checa se o nó selecionado atual é de um animal.
        /// </summary>
        public bool IsAnimal { get { return treeData.CurrentSelected is Animal; } }

        /// <summary>
        /// Retorna o valor do atual Nó, que pode ser um animal ou atributo.
        /// </summary>
        public string GetValue
        {
            get{
                return treeData.CurrentSelected.Value;
            }
        }
    }
}
