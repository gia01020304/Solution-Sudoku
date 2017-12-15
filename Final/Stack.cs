using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{

    class Stack
    {
        private int[] s;
        private int top;



        public int Top
        {
            get
            {
                return top;
            }

            set
            {
                top = value;
            }
        }

        public int[]  S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public Stack(int Size)
        {
            s = new int[Size];
            Top = 0;
        }
        public void Push(int Data)
        {
            Top++;
            s[Top] = Data;
            

        }
        public bool isEmpty()
        {
            if (Top == 0)
                return true;
            else return false;
        }
        public int Pop()
        {
            if (!isEmpty())
            {
                return s[top--];
            }
            if (Top > 0)
                return s[top];
            top = 0;
            return 0;
        }

    }
}
