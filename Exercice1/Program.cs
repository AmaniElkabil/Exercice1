using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre :");
            int nbr = int.Parse(Console.ReadLine());
            int i;
            bool b = true;
            for (i = 1; i < nbr % 2; i++)
            {
                if (nbr % 2 == 0)
                {
                    b = false;
                }
            }
            if (b == true)
            {
                Console.WriteLine("le nombre est premier");
            }
            else
            {
                Console.WriteLine("le nombre n 'est pas premier");
            }
        }
    }
}

