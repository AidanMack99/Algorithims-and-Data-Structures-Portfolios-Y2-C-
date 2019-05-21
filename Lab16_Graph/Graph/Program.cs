using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphNode<char> current;  //current location
            GraphNode<char> to;
            Graph<char> myGraph = new Graph<char>();
            List<char> x = new List<char>();


            myGraph.AddNode('A');
            myGraph.AddNode('B');

            myGraph.AddEdge('A', 'B');

            

            current = myGraph.GetNodeByID('A');
            to = myGraph.GetNodeByID('B');

            Console.WriteLine("Is myGraph empty? Answer: {0}", myGraph.IsEmptyGraph());
            Console.WriteLine("Is myGraph contain {0}? Answer: {1}", current.ID, myGraph.ContainsGraph(current));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}",
                  current.ID, to.ID, myGraph.IsAdjacent(current, to));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}",
                  to.ID, current.ID, myGraph.IsAdjacent(to, current));
            myGraph.DepthFirstTraverse('A', ref x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
