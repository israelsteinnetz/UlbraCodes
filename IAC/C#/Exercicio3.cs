using System;
 
namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone = "";
 
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu Endereço: ");
            endereco = Console.ReadLine();
            Console.Write("Digite seu Telefone: ");
            telefone = Console.ReadLine();
 
            Console.WriteLine("Seu Nome é: {0}, e você mora em: {1}, com o telefone: {2}", nome, endereco, telefone);
        }
    }
}