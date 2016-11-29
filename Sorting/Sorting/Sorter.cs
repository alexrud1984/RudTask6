using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorter
    {
        protected int[] targetMatrix;

        public virtual void Sort()
        {
            return;
        }

        public void Print()
        {
            Console.WriteLine("Array state:");
            for (int i = 0; i < targetMatrix.Length; i++)
            {
                Console.Write(targetMatrix[i] + " ");
            }
            Console.WriteLine();
        }

        public Sorter(int[] targetMatrix)
        {
            this.targetMatrix = targetMatrix;
        }

        protected void Swap(int first, int second)
        {
            int bufferValue = targetMatrix[first];
            targetMatrix[first] = targetMatrix[second];
            targetMatrix[second] = bufferValue;
        }
    }
}
