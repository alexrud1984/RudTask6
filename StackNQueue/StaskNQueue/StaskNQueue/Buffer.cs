using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskNQueue
{
    class Buffer
    {
        protected int[] bufferMtrx;

        public virtual bool IsEmpty()       
        {
                return (true);
        }

        public virtual bool IsFull()       
        {
                return (true);
        }

        public Buffer(int size)
        {
            bufferMtrx = new int[size];
        }

    }
}
