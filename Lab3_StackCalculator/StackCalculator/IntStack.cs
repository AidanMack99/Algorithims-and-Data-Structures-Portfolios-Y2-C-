using System;
using System.Collections.Generic;
using System.Text;

namespace StackCalculator
{
    class IntStack
    {
        
            private const int maxsize = 10;
            private int top = 0;
            private int[] array = new int[maxsize];

            public void Push(int value)
            {
                array[top++] = value;
            }

            public int Pop()
            {

                return array[--top];
            }

            public int Peek()
            {
                return array[top - 1];
            }

            public bool IsEmpty()
            {
                if (array[top] == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        

            public bool IsFull()
            {
                return top == maxsize;
            }

            public string Print()
            {
                StringBuilder output = new StringBuilder();
                for (int i = top - 1; i >= 0; i--)
                    output.Append(array[i] + Environment.NewLine);
                return output.ToString();
            }

        }


    }


