using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            string examQuestion = "Do you have another exam grade to enter?";
            string response = "yes";
            string examGrade = "What is your exam grade?";
            double examGrades;
            double avg = 0;
            double sum = 0;

            List<double> total = new List<double>();

            do
            {
                Console.WriteLine(examGrade);
                examGrades = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(examQuestion);
                response = Console.ReadLine();

                total.Add(examGrades);

                

            } while (response == "yes");

            for (int i = 0; i <total.Count; i++)
            {
                sum += total[i];
                avg = sum / total.Count;
                Console.WriteLine($"Your average exam grade is {avg}.");
            }

            double max = total[0];
            double min = total[0];

            for (int i = 0; i < total.Count; i++)
            {
                if (max < total[i]) 
                max = total[i];
                Console.WriteLine($"Your maximum exam grage is {max}");
            }

            for (int i = 0; i < total.Count; i++)
            {
                if (min > total[i])
                min = total[i];
                Console.WriteLine($"Your minimum exam grade is {min}");
            }

         

            Console.ReadKey();
        }
    }
}
