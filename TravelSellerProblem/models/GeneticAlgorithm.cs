using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSellerProblem.models
{
    public class GeneticAlgorithm
    {
        private double rateCrossover;               //Taxa de cruzamento
        private double rateMutation;                //Taxa de mutação

        public delegate Individual[] Crossover(Individual father1, Individual father2);
        public Crossover crossover;

        public delegate Individual Selection(Population pop);
        public Selection selection;

        public GeneticAlgorithm()
        {
            //Parametros iniciais
            crossover = CrossoverPMX;
            //selection = Tournament;
            rateCrossover = ConfigurationGA.rateCrossover;
            rateMutation = ConfigurationGA.rateMutation;
        }
        //Execução do AG
        public Population executeGA(Population pop)
        {
            //Criar a populaçao
            //Avaliar a população
            //Elitism
            //Seleção dos pais
            //Cruzamento dos pais
            //Mutação
            //Nova avaliação
            //Inserir nova pop
            return null;
        }
        //Cruzamento
        public Individual[] CrossoverPMX(Individual father1, Individual father2)
        {
            //Variável de retorno
            Individual[] newInd = new Individual[2];

            int[] parent1 = new int[ConfigurationGA.sizeChromossome];
            int[] parent2 = new int[ConfigurationGA.sizeChromossome];

            int[] offspring1Vector = new int[ConfigurationGA.sizeChromossome];
            int[] offspring2Vector = new int[ConfigurationGA.sizeChromossome];

            int[] replacement1= new int[ConfigurationGA.sizeChromossome];
            int[] replacement2 = new int[ConfigurationGA.sizeChromossome];

            //Seleção dos pontos para cruzamento
            int firstPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);
            int secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);

            if(firstPoint == secondPoint)
            {
                secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1); 
            }
            if(secondPoint < firstPoint)
            {
                int temp = secondPoint;
                secondPoint = firstPoint;
                firstPoint = temp;
            }

            Console.WriteLine("P1: " + firstPoint + " P2: " + secondPoint);

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            //Transferir os genes para um parent
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                parent1[i] = offspring1Vector[i] = father1.getGene(i);
                parent2[i] = offspring2Vector[i] = father2.getGene(i);
            }

            //Popular o replacement em valores abaixo de 0
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                replacement1[i] = replacement2[i] = -1;
            }
            //Passo de cruzamento 
            for(int i = firstPoint; i <= secondPoint; i++)
            {
                offspring1Vector[i] = parent2[i];
                offspring2Vector[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];
            }

            //Troca de genes repetidos
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                if ((i >= firstPoint) && (i <= secondPoint))
                    continue;
                //Troca
                int n1 = parent1[i];
                int m1 = replacement1[n1]; 

                int n2 = parent2[i];
                int m2 = replacement2[n1]; 

                while(m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[m1];
                }

                while(m2 != -1)
                {
                    n2 = m2;
                    m2 = replacement2[n2];
                }
                offspring1Vector[i] = n1;
                offspring2Vector[i] = n2;
            }
            for(int i = 0; i < ConfigurationGA.sizeChromossome; i++)
            {
                newInd[0].setGene(i, offspring1Vector[i]);
                newInd[1].setGene(i, offspring2Vector[i]);
            }
            newInd[0].CalcFitness();
            newInd[1].CalcFitness();

            return newInd;
        }
        //Mutação do tip swap
        public Individual Mutation(Individual ind)
        {
            //Verifica se vai mutar
            if(ConfigurationGA.random.NextDouble() <= rateMutation)
            {
                //Escolher os genes
                int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);
                int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1)
                if (genePosition1 == genePosition2)
                {
                    if(genePosition2 < ConfigurationGA.sizeChromossome-2)
                    {
                        genePosition2++;
                    }
                }
                ind.mutate(genePosition1, genePosition2);
                return ind;
            }
            return ind;
        }
        //Mutar cada indivíduo da população
        public Population MutationThePopulation(Population pop)
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                //Verifica se vai mutar
                if (ConfigurationGA.random.NextDouble() <= rateMutation)
                {
                    //Escolher os genes
                    int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);
                    int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromossome - 1);

                    if (genePosition1 == genePosition2)
                    {
                        if (genePosition2 < ConfigurationGA.sizeChromossome - 2)
                        {
                            genePosition2++;
                        }
                        else
                        {
                            genePosition2 -= 2;
                        }
                    }
                    pop.getPopulation()[i].mutate(genePosition1, genePosition2);                    
                }
            }
            return pop;
        }
        //Seleção por torneio
        public Individual Tornament(Population pop)
        {
            Individual[] competitors = new Individual[ConfigurationGA.numbOfCompetitors];

            Individual champion= new Individual();
            champion.setFitness(float.PositiveInfinity);

            //Seleção de competidores
            for(int i = 0; i < ConfigurationGA.numbOfCompetitors; i++)
            {
                competitors[i] = new Individual();
                competitors[i] = pop.getPopulation()[ConfigurationGA.random.Next(0, ConfigurationGA.sizePopulation - 1)];
            }

            //Escolher o vencedor
            for (int i = 0; i < ConfigurationGA.numbOfCompetitors; i++)
            {
             if(competitors[i].getFitness() < champion.getFitness())
                {
                    champion = competitors[i];
                    champion.CalcFitness();
                }
            }
            return champion;
        }
    }
}
