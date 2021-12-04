using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientist_graph_extended
{
    internal class GraphNode<T>
    {
        public int Index { get; set; }
        public T Data { get; set; }

        public List<GraphNode<T>> Colloborators { get; set; } = new List<GraphNode<T>>();
        public List<int> Weights { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"Index:{Index}, Data:{Data}";
        }
    }
}
