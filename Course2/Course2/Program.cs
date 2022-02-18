using System;
namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler altura e largura de uma matriz de inteiros
            string[] first = Console.ReadLine().Split(' ');
            int a = int.Parse(first[0]);
            int b = int.Parse(first[1]);
            int[,] mat = new int[a, b];


            for (int i = 0; i < a; i++)
            {
                //numeros de cada linha da matriz
                string[] nums = Console.ReadLine().Split(' ');
                for (int j = 0; j < b; j++)
                {
                    mat[i, j] = int.Parse(nums[j]);
                }
            }
            //numeros que serão encontrados dentro da matriz, e mostrados seus respectivos vizinhos
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < b - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < a - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}