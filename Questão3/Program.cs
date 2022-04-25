using System;

namespace Questão3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string[] remedio = new string[7]{ "Amoxicilina", "Rivotril", "Xarelto", "Torsilax", "Ozempic", "Dorflex", "Ivermectina" };

            Console.Write("Digite o nome de um remedio: ");
            string nomeRemedio = Console.ReadLine();

            for (int i = 0; i < remedio.Length; i++)
            {
                if (remedio[i] == nomeRemedio)
                {
                    Console.WriteLine($"O Remedio {nomeRemedio} estava na possição {i+1} de {nomeRemedio.Length} do array");
                }
                else
                {
                    // a cada vez que n tem o remedio é adicionado +1 a variavel quando ele percorer todo o array ela
                    //vai ficar com o msm tamanho do array dai a condição pra so ai ser falado que não existe o remedio
                    n++;
                    if(n == remedio.Length)
                        Console.WriteLine("O remedio informado não se encontra no array !!");
                }
            }

            Array.Sort(remedio); // ordenando por ordem alfabetica

            for (int i = 0; i < remedio.Length; i++) //exibindo a posição do remedio onde o array é ordenado
            {
                if (remedio[i] == nomeRemedio)
                {
                    Console.WriteLine($"O Remedio {nomeRemedio} estava na possição {i + 1} de {nomeRemedio.Length} do array");
                }
            }
        }
    }
}
