using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientist_graph_extended
{
    internal class Edge<T>
    {
        public GraphNode<T> Source { get; set; }
        public GraphNode<T> Destination { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Edge: {Source.Data} -> {Destination.Data}, Weight:{Weight}";
        }
    }
}
