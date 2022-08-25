namespace DataStructureSamples
{
    using System;
    using System.Diagnostics;
    using DataStructureSamples.BinaryTree;
    using DataStructureSamples.Trie;
    using DataStructureSamples.Graph;
    public class Program
    {
        public static void Main()
        {
            //BinaryTreeExample();

            //TrieExample();

            GraphExample();
        }

        private static void BinaryTreeExample()
        {
            BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
            binaryTree.Insert(30);
            binaryTree.Insert(35);
            binaryTree.Insert(57);
            binaryTree.Insert(15);
            binaryTree.Insert(63);
            binaryTree.Insert(49);
            binaryTree.Insert(89);
            binaryTree.Insert(77);
            binaryTree.Insert(67);
            binaryTree.Insert(98);
            binaryTree.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            binaryTree.Inorder(binaryTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            binaryTree.Preorder(binaryTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            binaryTree.Postorder(binaryTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        private static void TrieExample()
        {
            var items = new List<string> { "armed" , "armed", "jazz", "jaws" };
            // var stream = new StreamReader(@"C:/word2.txt");

            // while (!stream.EndOfStream)
            //     items.Add(stream.ReadLine());

            var stopwatch = new Stopwatch();

            var trie = new Trie.Trie();
            var hashset = new HashSet<string>();
            const string s = "gau";

            stopwatch.Start();
            trie.InsertRange(items);
            stopwatch.Stop();
            Console.WriteLine("Trie insertion in {0} ticks", stopwatch.ElapsedTicks);
            stopwatch.Reset();
            
            stopwatch.Start();
            for (int i = 0; i < items.Count; i++)
                hashset.Add(items[i]);
            stopwatch.Stop();
            Console.WriteLine("HashSet in {0} ticks", stopwatch.ElapsedTicks);
            stopwatch.Reset();

            Console.WriteLine("-------------------------------");

            stopwatch.Start();
            var prefix = trie.Prefix(s);
            var foundT = prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
            stopwatch.Stop();
            Console.WriteLine("Trie search in {0} ticks found:{1}", stopwatch.ElapsedTicks, foundT);
            stopwatch.Reset();

            stopwatch.Start();

            var foundL = hashset.FirstOrDefault(str => str.StartsWith(s));
            
            stopwatch.Stop();
            Console.WriteLine("HashSet search in {0} ticks found:{1}", stopwatch.ElapsedTicks, foundL);

            trie.Delete("jazz");
            Console.Read();
        }

        private static void GraphExample()
        {
            Graph.Graph g = new Graph.Graph(7, true);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(1, 0);
            g.AddEdge(1, 5);
            g.AddEdge(2, 5);
            g.AddEdge(3, 0);
            g.AddEdge(3, 4);
            g.AddEdge(4, 6);
            g.AddEdge(5, 1);
            g.AddEdge(6, 5);
    
            Console.Write("Breadth First Traversal from vertex 2:\n");
            g.BreadthFirstSearch(2);
            Console.Write("\nDepth First Traversal from vertex 2:\n");
            g.DepthFirstSearch(2);
        }
    }   
}
