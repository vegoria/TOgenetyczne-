using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class RuletteSelection: ISelection
    {
        public Population makeSelection(Population populationToSelect)
        {
            List<IIndividual> individuals = populationToSelect.Individuals;
            individuals.OrderByDescending(ind => ind.AdaptationLevel);

            Population newPopulation = randomNewPopulation(individuals, populationToSelect.PopulationSize);
            return newPopulation;
        }

        private Population randomNewPopulation(List<IIndividual> oldIndividuals, int populationSize)
        {
            List<IIndividual> newIndividuals = new List<IIndividual>();
            for(int i=0; i<populationSize; i++)
            {
                newIndividuals.Add(randomIndividual(oldIndividuals));
            }

            Population newPopulation = new Population(populationSize);
            newPopulation.Individuals = newIndividuals;

            return newPopulation; 
        }

        //TO DO: losowanie jednostek do nowej populacji
        private IIndividual randomIndividual(List<IIndividual> oldIndividual)
        {
            return null;
        }

    }
}
