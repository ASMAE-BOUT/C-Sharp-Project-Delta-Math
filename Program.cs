using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le nombre de valeurs à saisir (N) : ");
            int N = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Entrez la valeur #{i + 1}: ");
                double value = double.Parse(Console.ReadLine());
                sum += value;
            }

            double average = sum / N;

            Console.WriteLine($"La somme des {N} valeurs est : {sum}");
            Console.WriteLine($"La moyenne des {N} valeurs est : {average}");

            Console.ReadKey();
        }
    }
}

