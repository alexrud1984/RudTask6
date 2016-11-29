using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskNQueue
{
    class MyQueue : Buffer
    {
        private int tail = 0;
        private int head = 0;
        private int count = 0;

        public override bool IsEmpty()       //check if buffer is empty - counter is 0
        {
            if (count == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public override bool IsFull()        //check if buffer is full - counter = size of buffer
        {
            if (count == bufferMtrx.Length)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }


        public void Engueue(int value)
        {
            if (IsFull())
            {
                return;
            }
            else
            {
                bufferMtrx[tail] = value;
                tail++;
                count++;
                if (tail == bufferMtrx.Length)
                {
                    tail = 0;
                }
            }
        }

        public int Dequeue()
        {
            int pointer = head;
            if (IsEmpty())
            {
                return (0);                                          //return 0 if queue is empty
            }
            else
            {
                head++;
                count--;
                if (head == bufferMtrx.Length)
                {
                    head = 0;
                }
                return (bufferMtrx[pointer]);
            }
        }

        public MyQueue(int size) : base(size) {}
    }
}
