using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creat an array of type int
            int[] studentIDs = new int[4];
            string[] studentNames = { "Shelby", "Adam", "Micah", "Bob" };

            studentIDs[0] = 1;
            studentIDs[1] = 2;
            studentIDs[2] = 3;
            studentIDs[3] = 4;

            for (int i = 0; i < studentIDs.Length; i++)
            {
                Console.WriteLine($"Student with ID {studentIDs[i]} has a name of {studentNames[i]}");
            }

            
            List<int> studIDs = new List<int>();
            studIDs.Add(5);
            studIDs.Add(6);
            studIDs.Add(7);
            List<string> studNames = new List<string>();
            studNames.Add("Crispy");
            studNames.Add("Madi Bustin");
            studNames.Add("Slammin Sammon");

            for (int i = 0; i < studIDs.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIDs[i]} has a name of {studNames[i]}");

            }

            Dictionary<int, string> students = new Dictionary<int, string>();

            for (int i = 0; i < studentIDs.Length; i++)
            {
                students.Add(studentIDs[i], studentNames[i]);
            }
            Console.WriteLine("MADE IT THROUGH ALIVE");
            Console.ReadKey();
        
        }
    }
}
