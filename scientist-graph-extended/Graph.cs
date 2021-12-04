using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientist_graph_extended
{
    internal class Graph<T>
    {
        private bool _isDirected = false;
        private bool _isWeighted = false;
        public List<GraphNode<T>> Nodes { get; set; } = new List<GraphNode<T>>();

        public Graph(bool isDirected, bool isWeighted)
        {
            _isDirected = isDirected;
            _isWeighted = isWeighted;
        }

        public Edge<T> this[int src, int dest]
        {
            get
            {
                GraphNode<T> nodeSrc = Nodes[src];
                GraphNode<T> nodeDest = Nodes[dest];
                int i = nodeSrc.Colloborators.IndexOf(nodeDest);
                
                if (i >= 0)
                {
                    Edge<T> edge = new Edge<T>() {
                        Source = nodeSrc,
                        Destination = nodeDest,
                        Weight = i < nodeSrc.Weights.Count ? nodeSrc.Weights[i] : 0
                    };
                    return edge;
                }
                return null;
            }
        }
        private void UpdateIndices()
        {
            var i = 0;
            Nodes.ForEach(x => x.Index = i++);
        }

        public GraphNode<T> AddNode(T value)
        {
            GraphNode<T> node = new GraphNode<T>() { Data = value};
            Nodes.Add(node);
            UpdateIndices();
            return node;
        }

        public void RemoveNode(GraphNode<T> nodeToRemove)
        {
            Nodes.Remove(nodeToRemove);
            UpdateIndices();
            foreach (GraphNode<T> node in Nodes)
            {
                RemoveEdge(node, nodeToRemove);
            }
        }
        public void AddEdge(GraphNode<T> from, GraphNode<T> to, int weight = 0)
        {
            from.Colloborators.Add(to);
            if (_isWeighted)
            {
                from.Weights.Add(weight);
            }
            if (!_isDirected)
            {
                to.Colloborators.Add(from);
                if (_isWeighted)
                {
                    to.Weights.Add(weight);
                }
            }
        }
        public void RemoveEdge(GraphNode<T> src, GraphNode<T> dest)
        {
            int index = src.Colloborators.FindIndex(n => n == dest);
            if (index >= 0)
            {
                src.Colloborators.RemoveAt(index);
                if (_isWeighted)
                {
                    src.Weights.RemoveAt(index);
                }
            }
        }

        public List<Edge<T>> GetEdges()
        {
            List<Edge<T>> edges = new List<Edge<T>>();
            foreach (var src in Nodes)
            {
                for (var i = 0; i < src.Colloborators.Count; i++)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        Source = src,
                        Destination = src.Colloborators[i],
                        Weight = i < src.Weights.Count ? src.Weights[i] : 0
                    };
                    edges.Add(edge);
                }
            }
            return edges;
        }
    }
}
