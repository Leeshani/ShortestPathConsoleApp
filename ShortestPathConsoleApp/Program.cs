// See https://aka.ms/new-console-template for more information
using ShortestPathConsoleApp.Models;
using ShortestPathConsoleApp.Services;
using System.Xml.Linq;

try
{
    var graphNNode = new List<Node> {
                new Node { Name = "A", Edges = new List<Edge> { new Edge { Destination = "B" ,Distance= 4 }, new Edge { Destination = "C" ,Distance= 6} } },
                new Node { Name = "B", Edges = new List<Edge> { new Edge {Destination = "A" ,Distance = 4 }, new Edge { Destination = "F" ,Distance= 2 } } },
                new Node { Name = "C", Edges = new List<Edge> { new Edge {Destination = "A" ,Distance = 6 }, new Edge { Destination = "D" ,Distance= 8 } } },
                new Node { Name = "D", Edges = new List<Edge> { new Edge {Destination = "C" ,Distance = 8 }, new Edge { Destination = "E" ,Distance= 4 }, new Edge { Destination = "G", Distance = 1 } } },
                new Node { Name = "E", Edges = new List<Edge> { new Edge {Destination = "B" ,Distance = 2 }, new Edge { Destination = "D" ,Distance= 4 }, new Edge { Destination = "F", Distance = 3 }, new Edge { Destination = "I", Distance = 8 } } },
                new Node { Name = "F", Edges = new List<Edge> { new Edge { Destination = "B", Distance = 2 }, new Edge { Destination = "E", Distance = 3 }, new Edge { Destination = "G", Distance = 4 }, new Edge { Destination = "H", Distance = 6 } } },
                new Node { Name = "G", Edges = new List<Edge> { new Edge { Destination = "D", Distance = 1 }, new Edge { Destination = "F", Distance = 4 }, new Edge { Destination = "H", Distance = 5 }, new Edge { Destination = "I", Distance = 5 } } },
                new Node { Name = "H", Edges = new List<Edge> { new Edge {Destination = "G" ,Distance = 5 }, new Edge { Destination = "F" ,Distance= 6 } } },
                new Node { Name = "I", Edges = new List<Edge> { new Edge {Destination = "E" ,Distance = 8 }, new Edge { Destination = "G" ,Distance= 5 } } }
            };

    DijkstraService dijkstraService = new DijkstraService();
    Console.WriteLine("Please Enter From Node:");
    var fromNode = Console.ReadLine();
    Console.WriteLine("Please Enter To Node:");
    var toNode = Console.ReadLine();
    var ShortestPathData = dijkstraService.ShortestPath(fromNode, toNode, graphNNode);
    Console.WriteLine("Path :" + string.Join(",", ShortestPathData.NodeNames));
    Console.WriteLine("Total Distance :" + ShortestPathData.Distance);
    Console.ReadLine();

}
catch (Exception)
{
    throw;
}
