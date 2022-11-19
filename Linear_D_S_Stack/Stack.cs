using System;
using System.Collections.Generic;
using System.Text;

namespace Linear_D_S_Stack
{
    public class Stack
    {


        int[] arrValues = new int[10];

        int indexTop = 0;

        public void Push(int val)
        {
            if(indexTop == 9)
            return;
            arrValues[indexTop] = val;
            indexTop++;
        }

        public void Pop()
        {
            if (!isEmpty()) 
            indexTop--;
        }

        public int TopValue()
        {
            if (isEmpty()) return 0 ;
            return arrValues[indexTop-1];
        }

        public bool isEmpty()
        {
            return indexTop == 0;
        }




    }
}
