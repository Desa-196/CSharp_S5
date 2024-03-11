using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005_Delegate
{
    internal interface ICalculator
    {
        void Sum(double x);
        void Substract(double x);
        void Divide(double x);
        void Multiply(double x);
        void CancelLast();
        public event EventHandler<OperandChangedEventArgs> GetResult;
    }
}
