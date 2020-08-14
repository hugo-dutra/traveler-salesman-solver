using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSellerProblem.models
{
    public class Individual
    {
        private int[] chromossome;              //   Cromossomo de inteiros - Cada Gene representa uma cidade
        private double fitness;                 //   Valor de aptidão do individuo
        public int indexOfVector = 0;           //   Inserir os novos individuos na posição dos novos individuos

        //Construtor
        public Individual()
        {           
            this.chromossome = new int[ConfigurationGA.sizeChromossome];
            List<int> genes = Utils.RandomNumbers(0, ConfigurationGA.sizeChromossome);
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                chromossome[i] = genes[i];
            }
            //Calculo do fitness
            CalcFitness();
        }
        //Avaliar o individuo
        public void Evaluate()
        {
            CalcFitness();
        }

        public int[] getChromossome()
        {
            return chromossome;
        }
        //Cálculo do fitness do indivíduo
        public void CalcFitness()
        {
            double totalDist = 0.0;
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                if(i < (ConfigurationGA.sizeChromossome - 1))
                {
                    totalDist += TablePoints.getDist(getGene(i), getGene(i + 1));
                }
                else
                {
                    totalDist+= TablePoints.getDist(getGene(i), getGene(0));
                }
            }
            setFitness(totalDist);
        }
        //Gravar o gene do cromossomo em determinda posição
        public void setGene(int position, int gene)
        {
            chromossome[position] = gene;
        }
        //Pegar o gene do cromossomo em determinada posição
        public int getGene(int position)
        {
            return chromossome[position];
        }

        public void setFitness(double fit)
        {
            fitness = fit;
        }

        public double getFitness()
        {
            return fitness;
        }
        //Swap de genes
        public void mutate(int pointOne, int pointTwo)
        {
            if(pointOne < ConfigurationGA.sizeChromossome && pointTwo < ConfigurationGA.sizeChromossome && pointOne != pointTwo)
            {
                int temp = chromossome[pointOne];
                chromossome[pointOne] = chromossome[pointTwo];
                chromossome[pointTwo] = temp;
            }
        }

        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;
            result += "Rota:    ";
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                result += (getGene(i)+1).ToString() + " -> ";
            }
            result += "Distância: " + getFitness();
            return result;
        }

    }
}
