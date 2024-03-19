using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_005_Delegate
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<OperandChangedEventArgs> GetResult;
        private Stack<double> stack = new Stack<double>();
        private double Result { 
            get 
            {
                return stack.Count() == 0 ? 0 : stack.Peek();
            } 
            set 
            { 
                stack.Push(value); 
                RaiseEvent(); 
            } 
        }
        public void RaiseEvent()
        {
            GetResult.Invoke(this, new OperandChangedEventArgs(Result));
        }
        public void CancelLast() 
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            RaiseEvent();
        }
        public void Divide(double numder)
        {
             Result /= numder;
        }

        public void Multiply(double numder)
        {
             Result *= numder;
        }

        public void Substract(double numder)
        {
             Result -= numder;
        }

        public void Sum(double numder)
        {
             Result += numder;
        }

//Перегрузки методов для типа int

        public void Divide(int numder)
        {
            Result /= numder;
        }

        public void Multiply(int numder)
        {
            Result *= numder;
        }

        public void Substract(int numder)
        {
            Result -= numder;
        }

        public void Sum(int numder)
        {
            Result += numder;
        }

    }
}
