namespace System.Collections.Generic.Tree.Binary
{
    /// <summary>
    /// Representa um Nó de uma árvore binária.
    /// </summary>
    /// <typeparam name="V">Tipo do Objeto que a árvore conterá.</typeparam>
    public class Node<V>
    {
        /// <summary>
        /// Valor atual do nó.
        /// </summary>
        public V Value { get; protected set; }

        private Node<V> left;

        /// <summary>
        /// Nó da esquerda.
        /// </summary>
        public Node<V> Left
        {
            get { return left; }
            set { left = value; left.Root = this; }
        }

        private Node<V> right;

        /// <summary>
        /// Nó da direita.
        /// </summary>
        public Node<V> Right {
            get { return right; }
            set { right = value; right.Root = this; }
        }

        /// <summary>
        /// Nó pai.
        /// </summary>
        public Node<V> Root { get; set; }

        public Node(V value)
        {
            this.Value = value;
        }
    }

    /// <summary>
    /// Árvore binária.
    /// </summary>
    /// <typeparam name="T">T deve extender Node<V></typeparam>
    /// <typeparam name="V">Parámetro genérico que o Node implementa.</typeparam>
    public class Tree<T, V> where T : Node<V>
    {
        /// <summary>
        /// Nó Raiz da árvore.
        /// </summary>
        private T Root { get; set; }

        /// <summary>
        /// Atual selecionado.
        /// </summary>
        public T CurrentSelected { get; set; }

        public Tree(T root)
        {
            CurrentSelected = this.Root = root;
        }

        /// <summary>
        /// Adiciona um Nó à esquerda do atual selecionado.
        /// </summary>
        /// <param name="node">Nó à ser selecionado.</param>
        public void AddLeft(T node)
        {
            CurrentSelected.Left = node;
        }

        /// <summary>
        /// Adiciona um Nó à direita do atual selecionado.
        /// </summary>
        /// <param name="node">Nó à ser selecionado.</param>
        public void AddRight(T node)
        {
            CurrentSelected.Right = node;
        }

        /// <summary>
        /// Retorna o Nó à esquerda do atual selecionado.
        /// </summary>
        /// <returns>Nó da esquerda.</returns>
        public T GetLeft()
        {
            return (T)CurrentSelected.Left;
        }

        /// <summary>
        /// Selecionado o Nó à esquerda do atual selecionado.
        /// </summary>
        /// <returns>Novo Nó selecionado.</returns>
        public T SelectLeft()
        {
            return CurrentSelected = (T)CurrentSelected.Left;
        }

        /// <summary>
        /// Retorna o Nó à direita do atual selecionado.
        /// </summary>
        /// <returns>Nó da direita.</returns>
        public T GetRight()
        {
            return (T)CurrentSelected.Left;
        }

        /// <summary>
        /// Selecionado o Nó à direita do atual selecionado.
        /// </summary>
        /// <returns>Novo Nó selecionado.</returns>
        public T SelectRight()
        {
            return CurrentSelected = (T)CurrentSelected.Right;
        }

        /// <summary>
        /// Redefine a atual seleção para o Nó raiz.
        /// </summary>
        public void ResetSelect()
        {
            CurrentSelected = Root;
        }
    }
}
