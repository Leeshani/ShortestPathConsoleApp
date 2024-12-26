using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathConsoleApp.Models
{
    public class Node
    {
        public string Name { get; set; }
        public List<Edge> Edges { get; set; }
    }
}
