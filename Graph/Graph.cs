namespace DataStructureSamples.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
 
    internal class Graph
    {
        private int _V;    
        private bool _directed;
        LinkedList<int>[] _adj;  
       
        public Graph(int V, bool directed)
        {
            _adj = new LinkedList<int>[V];
 
            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
 
            _V = V;
            _directed = directed;       
        }
 
        public void AddEdge(int v, int w)
        {            
            _adj[v].AddLast(w);
 
            if (!_directed)
            {
                _adj[w].AddLast(v);
            }
        }
 
        public void BreadthFirstSearch(int s)
        {
            bool[] visited = new bool[_V];
            for(int i = 0; i < _V; i++)
                visited[i] = false;
    
            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();
    
            visited[s] = true;
            queue.AddLast(s);          
    
            while(queue.Any())
            {
                // Dequeue a vertex from queue and print it
                s = queue.First();
                Console.Write( s + " " );
                queue.RemoveFirst();
 
                LinkedList<int> list = _adj[s];
 
                foreach (var val in list)                
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

        public void DepthFirstSearch(int v)
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[_V];
      
            for (int i = 0; i < _V; i++)
                visited[i] = false;
   
            // Call the recursive helper function to print DFS traversal
            DFSUtil(v, visited);          
        }
 
        private void DFSUtil(int v, bool []visited)
        {
            // Mark the current node as visited and print it
            visited[v] = true;
            Console.Write( v + " " );
   
            // Recur for all the vertices adjacent to this vertex
            LinkedList<int> list = _adj[v];
 
            foreach (var val in list)
            {
                if (!visited[val])
                    DFSUtil(val, visited);
            }
        }
    }
}