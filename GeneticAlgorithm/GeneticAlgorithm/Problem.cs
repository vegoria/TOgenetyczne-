using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Problem
    {
        private Population population;
        private ICrossing crossing;
        private IMutation mutation;
        private ISelection selection;
        private IGoalFunction goalFunction;
        private double minimumAdaptationPercent;
        private int maxGenerations;

        public Problem(double minimumAdaptationPercent, int maxGenerations)
        {
            this.minimumAdaptationPercent = minimumAdaptationPercent;
            this.maxGenerations = maxGenerations;
        }

        public ICrossing Crossing
        {
            set { crossing = value;  }
        }

        public IMutation Mutation
        {
            set { mutation = value; }
        }

        public ISelection Selection
        {
            set { selection = value; }
        }

        public IGoalFunction GoalFunction
        {
            set { goalFunction = value; }
        }

        public void runAlgorithm(int sizeOfPopulation)
        {
            population = new Population(sizeOfPopulation);
            while(goalFunction.percentOfAdaptation(population) < minimumAdaptationPercent
                    && population.PopulationId < maxGenerations)
            {
                makeGeneration();
            }

        }
        private void makeGeneration()
        {
            population = selection.makeSelection(population);
            population = crossing.makeCorssing(population);
            population = mutation.makeMutation(population);
        }


    }
}
