using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTasks.Quiz
{
    class Quiz2
    {
        public Quiz2()
        {
            //Q1
            Queue<string> students = new Queue<string>();
            students.Enqueue("ALI");
            students.Enqueue("ASAD");
            students.Enqueue("ADEEL");
            students.Enqueue("OMER");
            students.Enqueue("SHAHID");
            students.Dequeue();
            Console.WriteLine(students.Dequeue());

            //Q2
            List<int> ages = new List<int> { 20, 25, 22, 20, 27, 29, 30, 24, 28, 19 };
            int maxIndex = 0;
            for (int i = 1; i < ages.Count; i++)
            {
                if (ages[i] > ages[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine("Person with max age is at index: " + maxIndex);
        }
    }
}
