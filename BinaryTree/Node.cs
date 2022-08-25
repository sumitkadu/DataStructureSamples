namespace DataStructureSamples.BinaryTree
{
    internal class Node
    {
            public int Item;
            public Node Left;
            public Node Right;
            public void Display()
            {
                Console.Write("[");
                Console.Write(Item);
                Console.Write("]");
            }
    }
}