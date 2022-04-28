using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deikstra
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Graph g;

        private void BDijkstra_Click(object sender, EventArgs e)
        {
            g.Dejkstra(); Res.Text += g.DisplayResults();
        }

        private void BEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BCreateGraph_Click(object sender, EventArgs e)
        {
            Res.Text = ""; g = new Graph(7);
            g.AddVertex("A"); g.AddVertex("B"); g.AddVertex("C");
            g.AddVertex("D"); g.AddVertex("E");
            g.AddVertex("F"); g.AddVertex("G");
            g.AddEdge(0, 3, 2); g.AddEdge(0, 5, 7);
            g.AddEdge(0, 2, 3); g.AddEdge(2, 1, 10);
            g.AddEdge(3, 4, 1); g.AddEdge(1, 4, 20);
            g.AddEdge(4, 6, 6); g.AddEdge(5, 6, 3);
            g.StartVertex = 2;
            Res.Text = g.ShowMatrix();
        }
    }
}




