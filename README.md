# scientist-graph
A graph implementation to set up a network between scientists worked together.
# Proposal
This project claims that a network between scientists worked together can be implemented by using Graph Theory, a weigted graph at its core . Therefore, it will be assumed that the relation and its value, the number of papers published, between individuals were considered to render a meaningful structure. Thus, the project will output the connection details between scientists
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
# Conclusion
# What I learned
