﻿//Shelby Williams
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Response;
            string MainSentence;
            string ReplacementWord;
            
            MainSentence = ("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the uiverse trying to build bigger and better idiots. So far, the universe is winning.");

            Console.WriteLine(MainSentence);
            Console.WriteLine("What word would you like to look for in the above sentence?");
            Response = Convert.ToString(Console.ReadLine());

            if (MainSentence.Contains(Response))
            {
                Console.WriteLine("What would you like to replace the word with?");
                ReplacementWord = Convert.ToString(Console.ReadLine());
                var shel = MainSentence.Replace(Response, ReplacementWord);
                Console.WriteLine(shel);
            } 

            else if (true)
            {
                Console.WriteLine($"Sorry, I could not find your word {Response}.");
                for (int i = Response.Length -1; i >= 0; i--)
                {
                    Console.Write(Response[i]);
                }                    
            }

            Console.ReadKey();
        }
    }
}
