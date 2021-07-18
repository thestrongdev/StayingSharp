using System;
using System.Collections.Generic;
using System.Text;

namespace StayingSharp
{
    class NewQueue
    {
        public Stack<int> StackOne { get; set; } = new Stack<int>();
        public Stack<int> StackTwo { get; set; } = new Stack<int>();

        public void Enqueue(int num)
        {
            this.StackOne.Push(num);
        }

        public int Dequeue()
        {
            if(this.StackOne.Count == 1)
            {
                return this.StackOne.Pop();
            }
            else
            {
                while (this.StackOne.Count != 0)
                {
                    var addToStackTwo = this.StackOne.Pop();
                    this.StackTwo.Push(addToStackTwo);
                }

                return this.StackTwo.Pop();
            }
        }


    }
}
