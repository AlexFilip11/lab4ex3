using System;

namespace lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m, respectiv m, n.
            //Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
            //Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I rezultatul.
            Console.WriteLine("Introduceti n si m ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] mat1 = ReadMatrix(n, m);
            int[,] mat2 = ReadMatrix(m, n);
            Console.WriteLine("Produsul matricelor este ");
            ShowMatrix(MultiplictionMatrix(mat1, mat2));
        }
        static int[,] ReadMatrix(int n, int m)
        {
            Console.WriteLine("Introduceti Matricea: ");
            int[,] result = new int[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        result[i, j] = int.Parse(Console.ReadLine());
                    }
            return result;
        }
        static int[,] MultiplictionMatrix(int[,] mat1, int[,] mat2)
        {
            int[,] result= new int[mat1.GetLength(0), mat2.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    for(int k=0; k<mat1.GetLength(1); k++)
                        result[i, j] += mat1[i, k] * mat2[k, j];
                }
            return result;
        }
        static void ShowMatrix(int[,] matrix)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
