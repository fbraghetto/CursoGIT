using System;

namespace Secao08_projeto_teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá Mundo V1!");

            if (DateTime.Now.Hour<12 && DateTime.Now.Hour>=6) {
                Console.WriteLine("Bom dia!");
            } else if (DateTime.Now.Hour < 18) {
                Console.WriteLine("Bom tarde!");
            } else {
                Console.WriteLine("Bom noite!");
            }
            
           
            Console.ReadKey();
        }
    }
}
