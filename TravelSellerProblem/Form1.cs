using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelSellerProblem.models;

namespace TravelSellerProblem
{
    public partial class Form1 : Form
    {
        Graphics g;                         //Desenha elementos na tela;
        int count = 0;                      //Contador para verificar quantidade de pontos na tela
        int pointCount = 0;                 //Sequenciador para identificar pontos na tela

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {            

            Pen blackPen = new Pen(Color.Red, 3);
            int x = e.X;
            int y = e.Y;
            TablePoints.addPoint(x, y);
            TablePoints.print();

            Rectangle rect = new Rectangle(x - 5, y - 5, 10, 10);
            g.DrawEllipse(blackPen, rect);
            g.DrawString((pointCount + 1).ToString(),new Font("Arial Black",11),Brushes.Black,x+3,y);
            g.DrawString("X:" + x.ToString(), new Font("Arial Black", 6), Brushes.Black, x - 20, y - 25);
            g.DrawString("Y:" + y.ToString(), new Font("Arial Black", 6), Brushes.Black, x - 20, y - 15);

            pointCount++;

            lbQtdeCidades.Text = "Quantidade de cidade: "+pointCount.ToString();
            lblComplex.Text = "Complexidade: "+ Fatorial((ulong)pointCount).ToString();

            btnCriarPop.Enabled = pointCount >= 3 ? true : false;
            btnLimpar.Enabled = pointCount >= 1 ? true : false;
        }

        private ulong Fatorial(ulong number)
        {
            if (number <= 1)
                return 1;
            else return number * Fatorial(number - 1);
        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            Individual ind1 = new Individual();
            Console.WriteLine(ind1);
            ConfigurationGA.rateMutation = 1;

            GeneticAlgorithm AG = new GeneticAlgorithm();
            ind1 = AG.Mutation(ind1);
            Console.WriteLine(ind1);
        }

        /*
         private void PlotPoints()
        {
            if(TablePoints.pointCount > 0)
            {
                for(int i =0; i < TablePoints.pointCount; i++)
                {
                    //Criar um lápis
                    Pen blackPen = new Pen(Color.Red, 3);
                    //Vetor de coordenadas (x,y)
                    int[] coo = TablePoints.GetCoordinates(i);
                    Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
                    g.DrawEllipse(blackPen, rect);
                    g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
                    g.DrawString("X:" + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
                    g.DrawString("Y:" + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 15);
                }

            }
        }
        */

        /*
        private void PlotLines(Population pop, Color color)
        {
            Pen penBest = new Pen(color, 4);
            int genA, getB;
            Individual best = pop.getBest();
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                if(i < ConfigurationGA.sizeChromossome - 1)
                {
                    getA = best.getGene(i);
                    getB = best.getGene(i + 1);
                }
                else
                {
                    genA = best.getGene(i)
                    genB = best.getGene(0);
                }
                int[] vetA = TablePoints.getCoordinates(genA);
                int[] vetB = TablePoints.getCoordinates(genB);
                g.DrawLine(penBest, vetA[0], vetA[1], vetB[0], vetB[1]);
            }

        }
        */

    }
}
