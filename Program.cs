using System;

namespace Calculadora
{
    class Program : Contas
    {
        static void Main(string[] args)
        {
        
        string num2 = "A";

        Console.WriteLine("Digite o primeiro número");
        Double num1 = Double.Parse(Console.ReadLine());

        //+ = soma ; - =  subtração ; * = multiplicação; / = divisão
        Console.WriteLine("escolha um: - + * /");
        num2 = Console.ReadLine();


        Console.WriteLine("Digite o segundo número");
        Double num3 = Double.Parse(Console.ReadLine());


        if(num2 == "-"){
            double resultado1 = num1 - num3;
            Console.Clear();
            Console.WriteLine("Resposta: " + resultado1);
        }else{
        if(num2 == "+"){
            double resultado2 = num1 + num3;
            Console.Clear();
            Console.WriteLine("Resposta: " + resultado2);
        }else{
        if(num2 == "*"){
            double resultado3 = num1 * num3;
            Console.Clear();
            Console.WriteLine("Resposta: " + resultado3);

        }else{
        if(num2 == "/"){
            double resultado4 = num1 / num3;
            Console.Clear();
            Console.WriteLine("Resposta: " + resultado4);

        }
        }
        }
        }

        
         

        

        


        }
    }
}
