 using System;
 class MediaUlbra
 {
	 public static void Main()
	 {
     float g1 = 0;
     float g2 = 0;
     float media;
     
	 Console.WriteLine("Digite a primeira nota: ");
	 g1 = float.Parse(Console.ReadLine());
	 Console.WriteLine("Digite a segunda nota: ");
	 g2 = float.Parse(Console.ReadLine());
	 media=(g1+(g2*2))/3;
	 Console.WriteLine("A sua media foi de " + media);
	 if(media>=6)
	 {
		 Console.WriteLine("Parabens voce foi aprovado, Parabens");
	 }
	 else
	 {
		 Console.WriteLine("Nao alcançou a media, estude mais!");
	 }
	 Console.ReadLine();
	 }