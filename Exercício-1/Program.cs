using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vetor = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");

                string nome = Console.ReadLine();
                Console.Write("Email: ");

                string email = Console.ReadLine();
                Console.Write("Quarto: ");

                int numeroQuarto = int.Parse(Console.ReadLine());
                vetor[numeroQuarto] = new Estudante(nome, email);

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 9; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine("Quarto n° " + i + ": " + vetor[i]);
                }
  
            }
            
        }
    }
}
