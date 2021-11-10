using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class MyQueue
    {
        public Queue<int> queue = new Queue<int>();//{ get; set; }

        public int TheSumBetweenMaxAndMin(Queue<int> queue) 
        {
            int sum = 0;
            foreach(int i in queue)
            {
                queue.Dequeue();
                if( i == queue.Max())
                    {
                        break;
                    }
            }
            foreach(int i in queue)
            {
                sum += i;
                if(i == queue.Min())
                {
                    break;
                }
            }
            return sum;
        }

}
}
