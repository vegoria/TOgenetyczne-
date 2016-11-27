using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class RuletteSelection: ISelection
    {
        public Population makeSelection(Population populationToSelect)
        {
            Population newPopulation = new Population(populationToSelect.PopulationSize);
            //List<IIndividual> individuals = populationToSelect.Individuals;
            //posortować individuals względem przystosowania

            //wylosować nowe jednostki, z odpowiednim prawdopodobieństwem
            return newPopulation;
        }

    }
}
