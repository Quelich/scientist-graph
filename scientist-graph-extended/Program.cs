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
        private static Graph<GraphNode<Scientist>> _graph = new Graph<GraphNode<Scientist>>(true, true);
        private static Scientist[] _scientists;
        public static void Main(string[] args)
        {
            var names_filepath = "D:\\2GitRepos\\scientist-graph-extended\\scientist-graph-extended\\Data\\Names.txt";
            var networks_filepath = "D:\\2GitRepos\\scientist-graph-extended\\scientist-graph-extended\\Data\\Networks_";
         
            ReadNames(names_filepath);
        }

        public static void ReadNames(string names_filepath)
        {
            var id_indexer = 1;
            try
            {
                var sr = new StreamReader(names_filepath);
                while (sr.ReadLine() != null && id_indexer < 10)
                {
                    var line = sr.ReadLine().Split(' ');
                    string s_name = string.Empty;
                    string s_lastName = string.Empty;
                    for(var i = 0; i<line.Length-1;i++)
                    {
                        s_name += line[i] + " ";
                    }
                    s_lastName = line[line.Length-1];
                    var s_id = id_indexer;
                    id_indexer++;
                    var s = new Scientist(s_id, s_name,s_lastName);
                    Console.WriteLine($"ID:{s.ID},Name:{s.Name},LastName:{s.LastName}");
                }
                //close the file
                sr.Close();
                Console.WriteLine("File has been read successfully!");
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

        public void ReadNetworks(string networks_filepath)
        {

        }

    }
}