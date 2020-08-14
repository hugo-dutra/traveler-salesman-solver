using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TravelSellerProblem.models
{
    public static class TablePoints
    {
        private static ArrayList X = new ArrayList();       //Array de valores de X
        private static ArrayList Y = new ArrayList();       //Array de valores de Y
        private static double[,] tableDist;                 //Tabela com distancias entre pontos
        public static int pointCount = 0;                   //Quantidade de pontos na tabela


        //Adicionar um ponto
        public static void addPoint(int x, int y)
        {
            X.Add(x);
            Y.Add(y);
            pointCount++;
            generateTable();
        }
        //Gerar a tabela
        public static void generateTable()
        {
            tableDist = new double[pointCount,pointCount];
            for(int i = 0; i < pointCount; i++)
            {
                for(int j = 0; j < pointCount; j++)
                {
                    double x1 = double.Parse(X[i].ToString());
                    double x2 = double.Parse(X[j].ToString());

                    double y1 = double.Parse(Y[i].ToString());
                    double y2 = double.Parse(Y[j].ToString());

                    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

                    tableDist[i, j] = dist;
                }
            }
            //Atualizar o tamanho do cromossomo
            ConfigurationGA.sizeChromossome = pointCount;
        }
        //Retornar a tabela de distancia
        public static double[,] getTableDist()
        {
            return tableDist;
        }
        //Retornar distancia entre dois pontos
        public static double getDist(int pointOn, int pointTwo)
        {
            return tableDist[pointOn,pointTwo];
        }
        //Retornar quantidade de pontos dentro da classe
        public static int Count()
        {
            return pointCount;
        }
        //Mostrar valores da tabela
        public static void print()
        {
            string data = string.Empty;
            for(int i = 0; i < pointCount; i++)
            {
                for(int j = 0; j < pointCount; j++)
                {
                    data += string.Format("{0:0.#}", double.Parse(tableDist[i, j].ToString())) + "     ";
                }
                data += Environment.NewLine;
            }
            data += Environment.NewLine + "-----------------------------------------------------------------"+Environment.NewLine;
            Console.Write(data);
        }
        //Retornar a coordenada de um ponto
        public static int[] getCoordinates(int point)
        {
            int[] arrayCoordeinates = new int[2];
            arrayCoordeinates[0] = int.Parse(X[point].ToString());
            arrayCoordeinates[1] = int.Parse(Y[point].ToString());
            return arrayCoordeinates;
        }
        //Limpar dados da tabela
        public static void clear()
        {
            X.Clear();
            Y.Clear();
            pointCount = 0;
            tableDist = null;
        }


    }
}
