using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArch = (Console.ReadLine());
            int numHours = 3;
            int numProject = int.Parse(Console.ReadLine());
            int sumOfProject = numHours * numProject;
            Console.WriteLine($"The architect {nameArch} will need {sumOfProject} hours to complete {numProject} project/s.");





        }
    }
}    
