# scientist-graph
A graph implementation to set up a network between scientists worked together.
# Proposal
This project claims that a network between scientists worked together can be implemented by using Graph Theory. Therefore, it will be assumed that the relation and its value, the number of papers published, between scientist are considered to render a meaningful structure. Thus, the project will output the connection details between scientists.
# Data
There is two type of data: Names.txt and Networks.txt
- Names.txt file maps every scientist in line separated into two distinct columns. Each column respectively represents the properties "Name" and "Last Name" of a scientist.
- Networks.txt file maps every single connection between given scientist IDs and the connection's weight, the number of publications, into three columns. The first column represents the source node. The second column represents the destination vertex to which the source vertex will be connected. The third column represents the weight between nodes.
# Mechanisms
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
- Graph theory can be utilized to describe a network where the connection between nodes are enumerated and assigned weights.
# What I learned
- How to implement Graph Theory for a real world sample
- C# infrastructure to handle IO streams
- Manipulate raw data to extract meaningful patterns
