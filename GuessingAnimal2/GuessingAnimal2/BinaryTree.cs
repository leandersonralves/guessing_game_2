namespace System.Collections.Generic
{
    public class NodeTree<T>
    {
        private T value;
        public NodeTree<T> Left { get; set; }
        public NodeTree<T> Right { get; set; }

        public NodeTree(T value)
        {
            this.value = value;
        }
    }

    public class BinaryTree<T>
    {
        public NodeTree<T> Root { get; private set; }

        public NodeTree<T> CurrentSelected { get; set; }

        public BinaryTree(NodeTree<T> root)
        {
            CurrentSelected = this.Root = root;
        }

        public void AddLeft(NodeTree<T> node)
        {
            CurrentSelected.Left = node;
        }

        public void AddRight(NodeTree<T> node)
        {
            CurrentSelected.Right = node;
        }

        public NodeTree<T> GetLeft()
        {
            return CurrentSelected.Left;
        }

        public NodeTree<T> SelectLeft()
        {
            return CurrentSelected = CurrentSelected.Left;
        }

        public NodeTree<T> GetRight()
        {
            return CurrentSelected.Left;
        }

        public NodeTree<T> SelectRight()
        {
            return CurrentSelected = CurrentSelected.Right;
        }
    }
}
