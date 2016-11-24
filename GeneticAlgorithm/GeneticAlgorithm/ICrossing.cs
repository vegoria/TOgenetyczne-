using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    interface ICrossing
    {
        void makeCorssing(IIndividual firstIndividual, IIndividual secondIndividual);
        int DividePossition
        {
            get;
            set;
        }
    }
}
