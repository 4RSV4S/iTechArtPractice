using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class MyQueue
    {
        public Queue<int> Queue = new Queue<int>();

        public void RandomQueueFilling()
        {
            Random rnd = new Random();
            int queueSize = rnd.Next(5, 10);
            for (int i = 0; i < queueSize; i++) //For correct counting, the numbers must be unique. 
            {
                int temp = rnd.Next(0, 10);
                while (Queue.Contains(temp) == true) //Check if the number is unique
                {
                    temp = rnd.Next(0, 10);
                }
                Queue.Enqueue(temp);
            }
            Console.WriteLine("The sequence of integer values: ");
            foreach (int q in Queue)
            {
                Console.Write($"{q} ");
            }
        }
        private int Max(Queue<int> queue)
        {
            Queue<int> queueTemp = new Queue<int>();
            int max = int.MinValue;

            while (queue.Count > 0)
            {
                int temp = queue.Dequeue();
                if (temp > max) max = temp;
                queueTemp.Enqueue(temp);
            }
            while (queueTemp.Count > 0)
            {
                int temp = queueTemp.Dequeue();
                queue.Enqueue(temp);
            }
            return max;

        }       
        private int Min(Queue<int> queue)
        {
            Queue<int> queueTemp = new Queue<int>();
            int min = int.MaxValue;
            
            while (queue.Count > 0)
            {
                int temp = queue.Dequeue();
                if (temp < min) min = temp;
                queueTemp.Enqueue(temp);
            }
            while (queueTemp.Count > 0)
            {
                int temp = queueTemp.Dequeue();
                queue.Enqueue(temp);
            }

            return min;
        }
        public void TheSumBetweenMaxAndMin() 
        {
            Queue<int> queueTemp = new Queue<int>();

            int max = Max(Queue);
            int min = Min(Queue);
            int status = 0;
            int sum = 0;

            while(status!=2) //Status is needed to stop the cicle. Status equal to 1 means that we found max value in queue. If it equal to 2 we found min value and whe can stop the cycle.
            {
                int temp = Queue.Dequeue();
                if (temp == max)
                {
                    status++;
                }
                if(status == 1)
                {
                    queueTemp.Enqueue(temp); //Copying the interval we need into the temporary queue
                }
                else
                {
                    Queue.Enqueue(temp);
                }
                if (temp == min && status > 0) //Checking whether min is worth it before max
                {
                    status++;
                }
                if (status == 2)
                {
                    break;
                }
            }
            foreach(int q in queueTemp)
            {
                sum += q;
            }
            Console.WriteLine($"\nThe sum between Max and Min values:\n{sum}");
        }
    }
}
