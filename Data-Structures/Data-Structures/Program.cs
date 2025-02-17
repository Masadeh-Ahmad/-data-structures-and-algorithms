﻿using Data_Structures.Data_structures.Array_Insert_Shift;
using Data_Structures.Data_structures.Array_Reverse;
using Data_Structures.Data_structures.Array_Binary_Search;
using System;
using Data_Structures.Data_structures.Trees.TreeFizzBuzz;
using System.Collections.Generic;
using Data_Structures.Data_structures.graph_depth_first;
using Data_Structures.Data_structures.graph;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphDepthFirst GD = new GraphDepthFirst();
            Node a = GD.addNode('a');
            Node b = GD.addNode('b');
            Node c = GD.addNode('c');
            Node d = GD.addNode('d');
            Node e = GD.addNode('e');
            Node f = GD.addNode('f');
            Node g = GD.addNode('g');
            Node h = GD.addNode('h');

            GD.addEdge(a, d);
            GD.addEdge(a, b);
            GD.addEdge(b, d);
            GD.addEdge(b, c);
            GD.addEdge(c, g); 
            GD.addEdge(d, f);
            GD.addEdge(d, h);
            GD.addEdge(d, e);
            GD.addEdge(f, h);
            List<char> DFS = new List<char>() { 'a', 'b', 'c', 'g', 'd', 'e', 'h', 'f' };
            foreach(char p in GD.DepthFirst(a))
            {
                Console.Write(',');
                Console.Write(p);
            }
            
        }
    }
}
