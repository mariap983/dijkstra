using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deikstra
{
    class Graph
    {
        public class Vertex
        {
            private bool isVisited; private string label;
            public Vertex(string label)
            {
                this.label = label; isVisited = false;
            }
            public string Etiket
            {
                get { return label; }
                set { label = value; }
            }
            public bool IsVisited
            {
                get { return isVisited; }
                set { isVisited = value; }
            }
        }//Край на клас Vertex

        //Най-голямото 32-битово цяло число за симулиране на безкрайност ("max")
        private const int max = Int32.MaxValue;

        private int N, BroiVertex = 0;// BroiVertex <= N това е брой върхове в графа
        private Vertex[] LstVertex;//Масив за списъка с върховете
        private int[,] a; //Матрица на съседство на графа, който се извежда се с метод ShowMatrix()
        private int[,] res; //Таблицата за резултата. Извежда се с метод DisplayResults()
        private int[] ArrayDist;//Едномерен масив с текущи сметки
        private int startVertex = 0;//Начален връх по подразбиране - първият, който може да се променя, чрез свойството за достъп
        private int CurrentVert, CurrentDist;//Работният (текущият) връх и неговото разстояние

        //Свойство за достъп до startVertex
        public int StartVertex
        {
            get { return startVertex; }
            set { startVertex = value; }
        }

        // Конструктор на класа Graph
        public Graph(int N)
        {
            this.N = N;
            //Заделяне на памет за масивите и инициализация на някои от тях
            LstVertex = new Vertex[N];
            a = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int k = 0; k < N; k++)
                    a[i, k] = max;

            ArrayDist = new int[N];
            for (int i = 0; i < N; i++) ArrayDist[i] = max;

            res = new int[N, 2];
        }

        public void AddVertex(string label)
        {
            LstVertex[BroiVertex] = new Vertex(label); BroiVertex++;
            //Добавят се проверки
            
        }

        public void AddEdge(int start, int end, int weight)
        {
            a[start, end] = weight; a[end, start] = weight;
            //Добавят се проверки
        }


        private void UpdateArrayDist()
        {
            for (int i = 0; i < BroiVertex; i++)
            {
                if (!LstVertex[i].IsVisited && a[i, CurrentVert] != max)
                {
                    int val = CurrentDist + a[i, CurrentVert];
                    if (val < ArrayDist[i])
                    {
                        ArrayDist[i] = val; res[i, 0] = CurrentVert; res[i, 1] = val;
                    }
                }
            }
        }

        private void Initial()
        {
            CurrentVert = startVertex; CurrentDist = 0;
            LstVertex[CurrentVert].IsVisited = true;
            ArrayDist[CurrentVert] = 0;
            res[CurrentVert, 0] = CurrentVert;
            res[CurrentVert, 1] = 0;
        }

        public void Dejkstra()
        {
            Initial();
            QQQ();//Междинен печат
            for (int i = 0; i < BroiVertex - 1; i++)
            {
                UpdateArrayDist();
                QQQ();//Междинен печат
                NewCurrentVert();
            }
        }
        private void NewCurrentVert()
        {
            int dist = max; int indexMin = 0;
            for (int i = 0; i < BroiVertex; i++)
            {
                if (!LstVertex[i].IsVisited && ArrayDist[i] < dist)
                {
                    dist = ArrayDist[i]; indexMin = i;
                }
            }
            CurrentVert = indexMin; CurrentDist = dist;
            LstVertex[CurrentVert].IsVisited = true;
        }

        public string DisplayResults()
        {
            string s = "\nРешение:  Пътища  от възел " + LstVertex[startVertex].Etiket + " до:\n";
            s += String.Format("{0,8} {1,8}{2,7} \n", "До възел", "Родител", "  Дължина");

            for (int j = 0; j < BroiVertex; j++)
            {
                s += String.Format("{0,5} ", LstVertex[j].Etiket);
                string parent = LstVertex[res[j, 0]].Etiket;
                s += String.Format("   {0,5} ", parent);
                if (res[j, 1] == max)
                    s += String.Format("   {0,5} \n", "    -  ");
                else s += String.Format("   {0,5} \n", res[j, 1].ToString());

            }
            return s;
        }

        public string ShowMatrix()
        {
            if (BroiVertex == 0) return "";

            string s = "      |"; int i;
            for (i = 0; i < BroiVertex; i++)
            {
                s += String.Format("{0,4}  |", LstVertex[i].Etiket);
            }
            s += "\n";
            for (i = 0; i < BroiVertex + 1; i++)
            {
                s += "======|";
            }
            s += "\n";
            for (i = 0; i < BroiVertex; i++)
            {
                s += String.Format("{0,4}  |", LstVertex[i].Etiket);
                for (int k = 0; k < BroiVertex; k++)
                {
                    if (a[i, k] == max)
                        s += string.Format("{0,4}  |", "-");
                    else s += string.Format("{0,4}  |", a[i, k].ToString());
                }
                s += "\n";
            }
            return s;
        }

        private void QQQ()
        {
            //Междинен печат
            string t = CurrentDist.ToString() + "  " + LstVertex[CurrentVert].Etiket + "::  ";
            for (int i = 0; i < BroiVertex; i++)
                if (ArrayDist[i] == max)
                    t += "*" + "     ";
                else
                    t += ArrayDist[i].ToString() + "     ";

            Console.WriteLine(t);
        }

    }//Край на Class Graph
}
