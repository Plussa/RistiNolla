using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RistiNolla
{
    class Program
    {

        static void Main(string[] args)
        {

            char player = 'X';
            char[,] taulu = new char[3, 3];


            while (true)
            {
                Console.Clear();
                Print(taulu);

                Console.WriteLine("\nAnna haluamasi rivi (0-2): ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Anna haluamasi sarake(0-2): ");
                int column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                taulu[row, column] = player;

                if (player == taulu[0, 0] && player == taulu[0, 1] && player == taulu[0, 2])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }

                else if (player == taulu[1, 0] && player == taulu[1, 1] && player == taulu[1, 2])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                    }
                else if (player == taulu[2, 0] && player == taulu[2, 1] && player == taulu[2, 2])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }
                else if (player == taulu[0, 0] && player == taulu[1, 0] && player == taulu[2, 0])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }
                else if (player == taulu[0, 1] && player == taulu[1, 1] && player == taulu[2, 1])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }
                else if (player == taulu[0, 2] && player == taulu[1, 2] && player == taulu[2, 2])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }
                else if (player == taulu[0, 0] && player == taulu[1, 1] && player == taulu[2, 2])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }
                else if (player == taulu[2, 0] && player == taulu[1, 1] && player == taulu[0, 2])
                {
                    Console.WriteLine(player + " voitti pelin");
                    break;
                }
                


                if (player == 'X')
                {
                    player = '0';
                }
                else
                    player = 'X';


                

            }
            Console.ReadLine();

        }





        static void Print(char[,] taulu)
        {
            for (int row = 0; row < 3; row++)
            {

                Console.Write(" | ");

                for (int column = 0; column < 3; column++)
                {
                    Console.Write(taulu[row, column]);
                    Console.Write(" | ");
                }

                Console.WriteLine();
            }
        }
    }
}
