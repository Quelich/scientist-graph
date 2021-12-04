using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientist_graph_extended
{
    internal class Scientist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Scientist(int iD, string name, string lastName)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
        }

        public override bool Equals(object? obj)
        {
            return obj is Scientist scientist &&
                   ID == scientist.ID &&
                   Name == scientist.Name &&
                   LastName == scientist.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Name, LastName);
        }

        public override string ToString()
        {
            return $"#{ID}:{Name}:{LastName}";
        }
    }
}
