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
        private ICrossing corssing;
        private IMutation mutation;
        private ISelection selection;
        private IGoalFunction goalFunction;
    }
}
