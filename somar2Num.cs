using System;

namespace console_dotnet

{
    class somar2Num
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Informe o 1 numero - >");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2 numero - >");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine(resultado);

        
        }
    }
}