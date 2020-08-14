using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelSellerProblem.models
{
    public class Population
    {
        public Individual[] population;                     //Grupo de indivíduos
        
        public Population()
        {
            population = new Individual[ConfigurationGA.sizePopulation];
            for(int i = 0; i < ConfigurationGA.sizePopulation;i++) {
                population[i] = new Individual();
                population[i].indexOfVector = i;
            }
            //Avaliar
            calculateFitness();
        }
        //Calula o fitness de todos os indivíduos
        public void calculateFitness()
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].CalcFitness();
            }
        }
        //Avaliar toda a população
        public void Evaluate()
        {
            refreshIndexOfIndivual();
            calculateFitness();
        }

        public void refreshIndexOfIndivual()
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].indexOfVector = i;
            }
        }
        //Retornar um vetor de indivíduos
        public Individual[] getPopulation()
        {
            return population;
        }

        public void setIndividuais(int position, Individual ind)
        {
            population[position] = ind;
        }

        public double getAveragePopulation()
        {
            double sum = 0;
            foreach(Individual ind in population)
            {
                sum += ind.getFitness();
            }
            return (sum/ConfigurationGA.sizePopulation);
        }
        //Método para ordenar a população do melhor para o pior
        public void orderPopulation()
        {
            Individual aux;
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                for(int j = 0; j < ConfigurationGA.sizePopulation; j++)
                {
                    if(population[i].getFitness() < population[j].getFitness())
                    {
                        aux = population[i];
                        population[i] = population[j];
                        population[j] = aux;
                    }
                }
            }
        }
        //Retornar melhor indivíduo
        public Individual getBest()
        {
            orderPopulation();
            return population[0];
        }
        //Retornar o pior indivícuo
        public Individual getBad()
        {
            orderPopulation();
            return population[ConfigurationGA.sizePopulation-1];
        }

        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                result += population[i].ToString() +"\n";
            }
            return result;
        }


    }
}
