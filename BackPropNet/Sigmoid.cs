using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTNeuralNet
{
    class Sigmoid : IActivation
    {
        public double Function(double input)
        {
            return 1 / (1 + Math.Exp(input));
        }
        public double Derivative(double input)
        {
            return Function(input) * (1 - Function(input));
        }
    }
}
