using System;

namespace gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string alta; 
            Console.Write("Escreva uma mensagem: ");
            alta = Console.ReadLine().ToUpper(); 
            Console.WriteLine();
            Console.WriteLine(alta); 

        }
    }
}
