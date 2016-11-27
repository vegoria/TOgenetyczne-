using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    interface IIndividual
    {
        double AdaptationLevel
        {
            get;
            set;
        }
        double Value
        {
            get;
            set;
        }
    }
}