using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSorter : Sorter
    {

        public BubbleSorter(int[] matrix) : base(matrix){}

        public override void Sort()
        {
            bool SwapTrue = false;
            do
            {
                SwapTrue = false;
                for (int i = 0; i < (targetMatrix.Length - 1); i++)
                {
                    if (targetMatrix[i] > targetMatrix[i + 1])
                    {
                        Swap(i, (i + 1));
                        SwapTrue = true;
                    }
                }
            }
            while (SwapTrue);
        }

    }
}
