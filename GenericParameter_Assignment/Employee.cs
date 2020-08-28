using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameter_Assignment
{
    public class Employee<T>
    {
        private List<T> nodes;

        public Employee()
        {
            this.nodes = new List<T>();
        }

        public void AddNode(T newNode)
        {
            nodes.Add(newNode);
        }

        public void ProcessAllNodes()
        {
            foreach (var node in nodes)
            {
                Console.WriteLine(node.ToString());
            }
        }
    }
}
