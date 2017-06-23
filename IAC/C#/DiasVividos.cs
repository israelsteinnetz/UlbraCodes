 using System;
 class DiasVividos
 {
	 public static void Main()
	 {
     
	 int DiasVida;
	 int HorasVida;
	 int Idade;
	 
	 Console.WriteLine("Digite sua idade");
	 Idade = int.Parse(Console.ReadLine());
	 
	 DiasVida = Idade*365;
	 HorasVida = Idade*24;
	 
	 Console.WriteLine("Você já viveu" + DiasVida + "dias");
	 Console.WriteLine("\nE" + HorasVida + "Horas");
	 Console.ReadLine();
	 }
 }