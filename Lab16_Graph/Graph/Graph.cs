using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph<T> where T : IComparable
    {

        // list of all nodes in the graph
        private LinkedList<GraphNode<T>> nodes;


        // constructor – set nodes to new empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }


        // only returns true if the graph’s list of nodes is empty
        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }



        // only returns true if node is present in the graph
        public bool ContainsGraph(GraphNode<T> node)
        {
            // to be completed. Hint: Search through the full list of nodes (search of the node is based on the id)
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;

        }


        // only returns true if nodes “from “ and “to” are adjacent
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {

            foreach(GraphNode<T> n in nodes)
            {
                if(n.ID.Equals(from.ID))
                {
                        if (from.GetAdjList().Contains(to.ID)) 
                        {
                            return true;
                        }
                }

            }
            return false;
            // to be completed
            //Hint: Find the node “from” in the list of nodes and then search its adjList to see if there is node “to” 

        }



        // add a new node (with this “id”) to the list of nodes
        public void AddNode(T id)
        {
            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }

        //returns the node with this id
        public GraphNode<T> GetNodeByID(T id)
        {
            // to be completed
            //Hint: Search through the list of nodes for a node with this id
            foreach(GraphNode<T> n in nodes)
            {
                if (id.Equals(n.ID))
                    return n;
            }
            return null;
        }








        // Add a directed edge between the node with id "from" and the node with id “to” 
        public void AddEdge(T from, T to)
        {
            // to be completed
            //Hint: Find the node with id “from” in the list of nodes and then        
            //use the GraphNode method to add an edge to the node with id “to” 
            GraphNode<T> C = new GraphNode<T>(to);
            GetNodeByID(from).AddEdge(C);

        

        }


        //Perform a DFS traversal starting at the node with id “startID”
        //leaving a list of visited id’s in the visited list. 

        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();

            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Push(startID);

            while (toVisit.Count != 0)
            {
                //to be completed. Hint: get current node to the list of visited nodes
                // and add its adjacent nodes (only those not already visited) to toVist 
                current = GetNodeByID(toVisit.Peek());
                adj = current.GetAdjList();
                visited.Add(current.ID);

                foreach (T type in adj)
                {
                    if (!toVisit.Contains(type) && !visited.Contains((type)))
                    {
                        toVisit.Push(type);
                    }
                }


            }
        }



        //Perform a BFS traversal starting at the node with id “startID”
        //leaving a list of visited id’s in the visited list. 

      /*  public void BreadthFirstTraverse(T startID, ref List<GraphNode<T>>visited)
        {
            LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                //get it off from the list
                T currentID = toVisit.Dequeue();
                current = GetNodeByID(currentID);
                adj = current.GetAdjList();
                //add the current to the visited list, so we know where we have been
                visited.Add(current);
                foreach (T ID in adj)
                {
                    if (!toVisit.Contains(ID) && !visited.Contains(GetNodeByID(ID)))
                    {
                        toVisit.Enqueue(ID);
                    }
                }

                //to be completed. Hint: get current node to the list of visited nodes       
             
            }
        }
        */


        // Return a list which contains the id's of the nodes that are mother           vertices. For example, return the list ['A',C','B'] if the nodes with id’s = A, C and B are mother vertices

        /*public List<T> mothervertices()
        {
            //to be completed.
            // Hint: Implement a method Boolean ListEq(List<T> l1, List<T> l2)  that only returns true if two lists of type List<T> contain the same elements. Use ListEq and a traversal method (BFS or DFS) to check if a vertex is a mother vertex. 
          
        }*/


    } //end class



}
