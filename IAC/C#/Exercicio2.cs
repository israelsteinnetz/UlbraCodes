using System;
 
namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Digite um número: ");
            //pega o valor digitado que é uma string
            //depois converte para inteiro (int)
            numero = int.Parse(Console.ReadLine());
            //imprimindo na tela
            Console.WriteLine("Você digitou: {0}", numero);
        }
    }
}