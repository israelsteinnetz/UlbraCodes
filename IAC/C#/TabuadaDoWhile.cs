 using System;
 class TabuadaDoWhile
 {
	 public static void Main()
	 {
     
	 int Numero
	 int Tabuada
	 int i = 1;
	 
	 Console.WriteLine("Digite o numero da tabuada: ");
	 Numero = float.Parse(Console.ReadLine());
	 
	 while(i<=10)
     {
     Tabuada=Numero*i;
	 Console.WriteLine(Tabuada + 
	                   "X" + i + 
					   "=" +  Tabuada);
	 //i=1+1;
	 i++
     
	 Console.ReadLine();
	 }