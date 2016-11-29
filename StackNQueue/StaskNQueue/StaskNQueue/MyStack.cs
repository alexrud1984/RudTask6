using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskNQueue
{
    class MyStack : Buffer
    {
        private int top = 0;

        public int Pop()                                            //returns top value in the stack
        {
            if (top == 0)
            {
                return (0);                                       //return 0 if stack is empty
            }
            else
            {
                return (bufferMtrx[--top]);                       //return top value and decrease pointer
            }
        }

        public void Push(int value)                                 //push the value to the next free sell
        {
            if (top != bufferMtrx.Length)
            {
                bufferMtrx[top] = value;
                top++;
                return;
            }
            else
            {
                return;
            }
        }

        override public bool IsEmpty()                                       //return true if stack is empty
        {
            if (top == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        override public bool IsFull()                                        //return true if stack is full
        {
            if (top == bufferMtrx.Length)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public int Peek()                                           //return top value without deletion
        {
            if (top == 0)
            {
                return (0);
            }
            else
            {
                return (bufferMtrx[top - 1]);
            }
        }

        public MyStack(int size) : base(size) { }
    }
}
