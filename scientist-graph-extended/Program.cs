using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace scientist_graph_extended
{
    internal class Program
    {
        private static Graph<Scientist> _graph = new Graph<Scientist>(true, true);

        private static Scientist[] _scientists = new Scientist[162932];
        private static int _networkFileCount = 1;
        private static string _relativePath = "D:\\2GitRepos\\scientist-graph-extended\\scientist-graph-extended";
        public static void Main(string[] args)
        {
            
            var names_filepath = _relativePath + "\\Data\\Names.txt";
            var networks_filepath = _relativePath + "\\Data\\Networks_";
            ReadNames(names_filepath);
            ReadNetworks(networks_filepath);
            var edges = _graph.GetEdges();
            WriteOutputFile(edges);
        }

        /// <summary>
        /// Read the content of the specified file.
        /// Get Scientist object and place it to the array.
        /// Get ScientistNode object and place it to the graph.
        /// </summary>
        /// <param name="names_filepath"> the file path of which the content will be read</param>
        public static void ReadNames(string names_filepath)
        {
            var id_indexer = 0;

            try
            {
                var sr = new StreamReader(names_filepath);
                foreach (var line in File.ReadLines(names_filepath))
                {

                    var columns = line.Split(' ');
                    (string s_name, string s_lastName) = GetScientistIdentity(columns);
                    var s_id = id_indexer;
                    id_indexer++;
                    var s = new Scientist(s_id, s_name, s_lastName);
                    _scientists[id_indexer] = s;
                    var node = _graph.AddNode(s);

                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static void ReadNetworks(string networks_filepath)
        {

            try
            {

                for (int i = 1; i <= _networkFileCount; i++)
                {
                    var sr = new StreamReader(networks_filepath + _networkFileCount + ".txt");
                    foreach (var line in File.ReadLines(networks_filepath + _networkFileCount + ".txt"))
                    {

                        var columns = line.Split(' ');

                        var from_s = int.Parse(columns[0]);
                        var to_s = int.Parse(columns[1]);
                        var weight = int.Parse(columns[2]);

                        var s1_node = _graph.Nodes[from_s];
                        var s2_node = _graph.Nodes[to_s];
                        _graph.AddEdge(s1_node, s2_node, weight);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public static void WriteOutputFile(List<Edge<Scientist>> l)
        {
            using (StreamWriter outputFile = new("output.txt"))
            {
                foreach (var edge in l)
                {
                    outputFile.WriteLine(edge.ToString());
                }
            }                
        }

        private static (string TName, string TLastName) GetScientistIdentity(string[] lineColumns)
        {
            if (lineColumns == null)
                throw new ArgumentNullException("NULL string array");
            string s_name = string.Empty;
            string s_lastName = string.Empty;
            var len = lineColumns.Length;
            for (var i = 0; i < len - 1; i++)
            {
                s_name += lineColumns[i] + " ";
            }
            s_lastName = lineColumns[len - 1];
            return (s_name, s_lastName);
        }
    }
}