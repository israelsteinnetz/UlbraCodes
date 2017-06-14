using System;

class Calculadora
{
	
	public static void Main()
	{	
		int NumeroUm = 0;
		int NumeroDois = 0;
		
		Console.WriteLine("Primeiro Número:");
		//atribui o que o usuário
		// digitou e faz um parse para int
		//parse serve para converter um tipo
		NumeroUm = int.Parse(Console.ReadLine());
		
		Console.WriteLine("O número digitado foi " 
				  + NumeroUm);
		Console.ReadLine();
	}
	
	
}