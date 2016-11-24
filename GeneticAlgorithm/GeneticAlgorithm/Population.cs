using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Population
    {
        private static int nextGenerationId = 1;
        private readonly int populationSize;
        private readonly int populationId;
        public Population(int size)
        {
            populationSize = size;
            populationId = nextGenerationId++;
        }

        public int PopulationSize
        {
            get
            {
                return populationSize;
            }
        }

        public int PopulationId
        {
            get
            {
                return populationId;
            }
        }
    }
}
