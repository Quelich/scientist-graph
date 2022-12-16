# scientist-graph
A graph implementation to demonstrate the network between scientists working together.
# Proposal
This project suggests an algorithm implementing the Graph theory for correlating a network among scientists working together. Therefore,  the number of papers published by scientists working together and will be considered valuable information. Thus, the project outputs the connection details between scientists.
# Data
There are two types of data: Names.txt and Networks.txt
- Names.txt file maps every scientist in the line separated into two distinct columns. Each column respectively represents the properties "Name" and "Last Name" of a scientist.
- Networks.txt file maps every connection between given scientist IDs and the connection's weight, the number of publications into three columns. The first column represents the source node. The second column represents the destination node which forms a vertex to which the source vertex will be connected. The third column represents the weight between nodes.
# Components
## `Graph`
Represents the whole network, a massive collection of the edges.
## `Edge`
Represents the connection between a single scientist and another scientist.
## `Node`
Represents a scientist with certain properties to describe a vertex.
# Results
Note: this result only shows a small part of the output. See [output.txt](https://github.com/Quelich/scientist-graph/blob/master/scientist-graph-extended/output.txt) for more of it.
- Edge: #1:Pedro :Domingos     -> #2:Daniel S. :Weld, Publications:1
- Edge: #1:Pedro :Domingos     -> #3:Brigham :Anderson, Publications:1
- Edge: #2:Daniel S. :Weld     -> #1:Pedro :Domingos, Publications:1
- Edge: #2:Daniel S. :Weld     -> #3:Brigham :Anderson, Publications:1
- Edge: #2:Daniel S. :Weld     -> #40:Jia-Yu :Pan, Publications:1
- Edge: #2:Daniel S. :Weld     -> #193:Peter :Antal, Publications:1
- Edge: #2:Daniel S. :Weld     -> #324:Patrick :Wendel, Publications:1
- Edge: #2:Daniel S. :Weld     -> #325:Igor V. :Cadez, Publications:1
- Edge: #2:Daniel S. :Weld     -> #326:Scott :Gaffney, Publications:1
- Edge: #2:Daniel S. :Weld     -> #327:Matt :Cutler, Publications:1
- Edge: #2:Daniel S. :Weld     -> #503:D. :Gershkovich, Publications:3
- Edge: #2:Daniel S. :Weld     -> #504:Ehud :Gudes, Publications:2
- Edge: #2:Daniel S. :Weld     -> #625:Kamal :Nigam, Publications:1
- Edge: #2:Daniel S. :Weld     -> #778:Marcel :Holsheimer, Publications:1
- Edge: #3:Brigham :Anderson   -> #1:Pedro :Domingos, Publications:1
- Edge: #3:Brigham :Anderson   -> #2:Daniel S. :Weld, Publications:1
- Edge: #3:Brigham :Anderson   -> #2124:Thore :Graepel, Publications:1
- Edge: #3:Brigham :Anderson   -> #2125:Ralf :Herbrich, Publications:1
- Edge: #4:Andrew W. :Moore    -> #5:Andrew :Connolly, Publications:1
- Edge: #4:Andrew W. :Moore    -> #6:Robert :Nichol, Publications:1
# Conclusion
- Graph theory is favourable to describe a network where the connection between nodes are enumerated and assigned to weights.
# What I learned
- Implement Graph Theory for a real world data.
- Data manipulation in C#
