using System;
using System.Collections.Generic;

namespace heap
{
    class Vertex
    {
        public List<Vertex> Sousedi;
        public int Length;
    }
    class Heap
    {
        List<Vertex> List { get; set; }
        Dictionary<Vertex, int> Indexy { get; set; }
        public int Count => List.Count;
        public bool Empty => Count == 0;

        public Vertex Peak()
        {
            return List[0];
        }

        public Vertex Father()
        {

        }

        public void BubbleUp(int v)
        {
            while(List[Father(v)].Length > List(v).Length)
            {
                Swap(Father(v), v);
            }
        }
        public void Swap(int in1, int in2)
        {
            Vertex vert3 = List[in1];
            List[in1] = List[in2];
            List[in2] = vert3;
        }

        public void Add(Vertex v)
        {
            List.Add(v);
            Indexy.Add(v, List.Count -1 );
        }

        public Vertex GirlyPop()
        {
            Vertex t = List[0];

            Swap(0, List.Count-1);
            List.RemoveAt(List.Count + 1);
            Indexy.Remove(t);

            return t;
        }

        public void Update(Vertex v)
        {
            int i = Indexy[v];

            Bubble(i);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
