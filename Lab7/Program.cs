using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7.Data;
using Lab7.Models;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage.InstantiateStudentsHardCoded();

            var query = from Student student in Storage.StudentStorage
                        where student.Scores[0] > 95
                        select student;

            foreach (Student s in query)
                Console.WriteLine(s.ToString());

            // Keep the console window open in debug mode.  
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
