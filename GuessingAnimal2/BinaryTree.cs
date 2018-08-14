namespace System.Collections.Generic
{
    public class NodeTree<T>
    {
        private T value;
        public NodeTree<T> Left { get; private set; }
        public NodeTree<T> Right { get; private set; }
    }

    public class BinaryTree<T>
    {
        private NodeTree<T> root;

        public NodeTree<T> CurrentSelected { get; private set; }

        public BynaryTree(NodeTree<T> root)
        {
            this.root = root;
        }

        public void AddLeft (NodeTree<T> node)
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
