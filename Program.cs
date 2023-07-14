using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY05_Assisgnment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] {85,92,78};
            studentScores[1] = new int[] {90,87,93,89};
            studentScores[2] = new int[] {76,88};
            Console.WriteLine("Student Scores are");
            for(int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i+1}\'scores: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.WriteLine(studentScores[i][j] + "\t");
                }
                Console.Write("\n");

            }
            //Average of the Score for each Student
            for(int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for(int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                int avg = sum / studentScores.Length;
                Console.WriteLine($"Students Average Score{i+1} is {avg}");
            }
            //Average of the Score of All Student
            int totalSum = 0;
            int totalCount = 0;
            for(int i = 0; i < studentScores.Length; i++)
            {
                for(int j = 0; j < studentScores[i].Length; j++){
                    totalSum += studentScores[i][j];
                    totalCount++;

                }
            }
            int totalAverage = totalSum / totalCount;
            Console.WriteLine($"\nAverage for all Students Combined {totalAverage}");
            Console.ReadKey();
        }
    }
}
