using System;

class Opcoes
{
    public static void Main()
    {
        int Opcao = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Escolha o programa desejavél: ");
            Console.WriteLine("[1] Calculadora");
            Console.WriteLine("[2] Media");
            Console.WriteLine("[3] Tabuada");
            Console.WriteLine("[4] IMC");
            Console.WriteLine("[5] SAIR");
            Opcao = int.Parse(Console.ReadLine());
            

            switch (Opcao)        
            {
                  case 1:  

                        float N1 = 0;
                        float N2 = 0;
                        float Result = 0;
                        string Oper = "";

                        Console.Clear();
                        Console.WriteLine("Selecione a opcão:");
                        Console.WriteLine("[+] Soma:");
                        Console.WriteLine("[-] Subtração:");
                        Console.WriteLine("[*] Multiplicação:");
                        Console.WriteLine("[/] Divisão:");
                        Oper = Console.ReadLine();

                        Console.WriteLine("Digite um número:");
                        N1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite mais um número:");
                        N2 = float.Parse(Console.ReadLine());

                        if(Oper == "+")
                        {
                              Result = N1 + N2;
                        }
                        else if(Oper == "-")
                        {
                              Result = N1 - N2;
                        }
                        else if(Oper == "*")
                        {
                              Result = N1 * N2;                
                        }
                        else if(Oper == "/")
                        {
                              Result = N1 / N2;
                        }
                        else
                        {
                              Console.WriteLine("Erro com operrador!");
                        }
                              Console.WriteLine("O resultado é: " + N1 + Oper + N2 +" = " + Result);
                              Console.WriteLine("Aperte Enter para voltar!");
                              Console.ReadLine();
                              break;

                  case 2:
                        float G1 = 0;
                        float G2 = 0;
                        float Media = 0;
                        

                    
                        Console.Clear();
                        Console.WriteLine("Digite sua nota  [G1]: ");
                        G1 = float.Parse(Console.ReadLine());
                            
                        Console.WriteLine("Digite sua nota  [G2]: ");
                        G2 = float.Parse(Console.ReadLine());

                        Media = (G1 + (G2 * 2))/3;

                        Console.WriteLine("Media Final: {0:0.00}", Media);
                        if(Media >= 6)
                        {
                            Console.WriteLine("Aprovado");
                        }
                        else
                        {
                            Console.WriteLine("Reprovado");
                        }
                        Console.WriteLine("Aperte Enter para voltar!");
                        Console.ReadLine();
                        break;

                  case 3:
            
                        int N3 = 0;
                        int result = 0;

                        Console.Clear();
                        Console.WriteLine("Digite o número para a tabuada: ");
                        N3 = int.Parse(Console.ReadLine());

                        for (int i = 0; i <= 10; i++)
                        {
                              result = N3 * i;
                              Console.WriteLine(N3 + " * " + i + " = " + result);
                        } 
                        Console.WriteLine("Aperte Enter para voltar!"); 
                        Console.ReadLine();
                        break;
            
                  case 4:
            
                        float peso = 0;
                        float altura = 0;
                        float Imc = 0;
                        string Sexo = "";

                        Console.Clear();
                        Console.WriteLine("Digite seu sexo: [M] ou [F]");
                        Sexo = Console.ReadLine();

                        Console.WriteLine("Qual seu peso em kg? ");
                        peso = float.Parse(Console.ReadLine());

                        Console.WriteLine("Qual sua altura? ");
                        altura = float.Parse(Console.ReadLine());

                        Imc = peso/(altura*altura);

                        if(Sexo == "m" || Sexo == "M")
                        {
                            if(Imc < 20.7){
                                Console.WriteLine("Abaixo do Peso! IMC: {0:00.00}", Imc);
                            } else if(Imc < 26.4){
                                Console.WriteLine("Peso normal! IMC: {0:00.00}", Imc);
                            } else if(Imc < 27.8){
                                Console.WriteLine("Um pouco acima do peso! IMC: {0:00.00}", Imc);
                            } else if(Imc < 31.1){
                                Console.WriteLine("Acima do Peso ideal! IMC: {0:00.00}", Imc);
                            } else{
                                Console.WriteLine("Obeso! IMC: {0:00.00}", Imc);
                            }
                        } else if(Sexo == "f" || Sexo == "F")
                        {
                            if(Imc < 19.1){
                                Console.WriteLine("Abaixo do Peso! IMC: {0:00.00}", Imc);
                            } else if(Imc < 25.8){
                                Console.WriteLine("Peso normal! IMC: {0:00.00}", Imc);
                            } else if(Imc < 27.3){
                                Console.WriteLine("Um pouco acima do peso! IMC: {0:00.00}", Imc);
                            } else if(Imc < 32.3){
                                Console.WriteLine("Acima do Peso ideal! IMC: {0:00.00}", Imc);
                            } else{
                                Console.WriteLine("Obeso! IMC: {0:00.00}", Imc);
                            }
                        }
                        Console.WriteLine("Aperte Enter para voltar!");
                        Console.ReadLine();
                        break;

            }
        } while (Opcao != 5);
    }     
}