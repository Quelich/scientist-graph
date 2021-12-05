# scientist-graph
A graph implementation to set up a network between scientists worked together.
# Proposal
This project claims that a network between scientists worked together can be implemented by using Graph Theory. Therefore, it will be assumed that the relation and its value, the number of papers published, between scientist are considered to render a meaningful structure. Thus, the project will output the connection details between scientists.
# Data
There is two type of data: Names.txt and Networks.txt
- Names.txt file maps every scientist in line separated into two distinct columns. Each column respectively represents the properties "Name" and "Last Name" of a scientist.
- Networks.txt file maps every single connection between given scientist IDs and the connection's weight, the number of publications, into three columns. The first column represents the source node. The second column represents the destination node to which the source node will be connected. The third column represents the weight between nodes.
# Mechanisms
## `Graph`
Represents the whole network, a massive collection of the edges.
## `Edge`
Represents the connection between a single scientist and another scientist.
## `Node`
Represents a scientist with certain properties.
# Results
Note: this result only shows a small part of the output.
- Edge: #1:Pedro :Domingos     -> #2:Daniel S. :Weld, Weight:1
- Edge: #1:Pedro :Domingos     -> #3:Brigham :Anderson, Weight:1
- Edge: #2:Daniel S. :Weld     -> #1:Pedro :Domingos, Weight:1
- Edge: #2:Daniel S. :Weld     -> #3:Brigham :Anderson, Weight:1
- Edge: #2:Daniel S. :Weld     -> #40:Jia-Yu :Pan, Weight:1
- Edge: #2:Daniel S. :Weld     -> #193:Peter :Antal, Weight:1
- Edge: #2:Daniel S. :Weld     -> #324:Patrick :Wendel, Weight:1
- Edge: #2:Daniel S. :Weld     -> #325:Igor V. :Cadez, Weight:1
- Edge: #2:Daniel S. :Weld     -> #326:Scott :Gaffney, Weight:1
- Edge: #2:Daniel S. :Weld     -> #327:Matt :Cutler, Weight:1
- Edge: #2:Daniel S. :Weld     -> #503:D. :Gershkovich, Weight:3
- Edge: #2:Daniel S. :Weld     -> #504:Ehud :Gudes, Weight:2
- Edge: #2:Daniel S. :Weld     -> #625:Kamal :Nigam, Weight:1
- Edge: #2:Daniel S. :Weld     -> #778:Marcel :Holsheimer, Weight:1
- Edge: #3:Brigham :Anderson   -> #1:Pedro :Domingos, Weight:1
- Edge: #3:Brigham :Anderson   -> #2:Daniel S. :Weld, Weight:1
- Edge: #3:Brigham :Anderson   -> #2124:Thore :Graepel, Weight:1
- Edge: #3:Brigham :Anderson   -> #2125:Ralf :Herbrich, Weight:1
- Edge: #4:Andrew W. :Moore    -> #5:Andrew :Connolly, Weight:1
- Edge: #4:Andrew W. :Moore    -> #6:Robert :Nichol, Weight:1
# Conclusion
# What I learned
