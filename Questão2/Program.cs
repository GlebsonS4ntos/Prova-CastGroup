using System;

namespace Questão2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double acertadas = 0, erradas = 0, perto = 0;

            Console.WriteLine("Bem vindo(a) ao jogo de adinvinhação !!");
            Console.Write("Digite a quantidade de vezes que deseja jogar: ");
            int quantidadeJogar = int.Parse(Console.ReadLine());

            Console.WriteLine();
           
            for (int i = 0; i < quantidadeJogar; i++)
            {
                int numberRandom = new Random().Next(1, 10);
                Console.Write("Digite um numero entre 1 e 10: ");
                int numero = int.Parse(Console.ReadLine());

                if(numberRandom == numero)
                {
                    Console.WriteLine("Parabens, você acertou. O numero erra: " + numberRandom);
                    acertadas++;
                }
                else if (Math.Abs(numberRandom - numero) == 1)
                {
                    Console.WriteLine("Essa passou perto em...,o numero Foi: " + numberRandom);
                    perto++;
                }
                else
                {
                    Console.WriteLine("Errou Feio, o numero Foi: " + numberRandom);
                    erradas++;
                }
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("O numero de Tentativas Foram: " + quantidadeJogar);
            Console.WriteLine("O numero de vezes Acertadas Foram: " + acertadas);
            Console.WriteLine("O numero de vezes Erradas Foram: " + erradas);
            Console.WriteLine("A numero de vezes que Passou Perto Foram: " + perto);
        }
    }
}
