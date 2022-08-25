namespace DataStructureSamples.BinaryTree
{
    internal class BinaryTree
    {
        public Node? Root;
        public BinaryTree()
        {
            Root = null;
        }
        public Node ReturnRoot()
        {
            return Root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.Item = id;
            if (Root == null)
                Root = newNode;
            else
            {
                Node current = Root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.Item)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Item + " ");
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.Item + " ");
                Inorder(Root.Right);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                Console.Write(Root.Item + " ");
            }
        }
    }
}