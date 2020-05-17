using System;


namespace Atividade_2___Métodos_Especiais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor para converter");
            Comprimento num1 = new Comprimento(Convert.ToDouble(Console.ReadLine()));


            Console.WriteLine(num1.Quilometro + " Quilometros");

            Console.WriteLine(num1.Metro + " Metros");

            Console.WriteLine(num1.Centimetro + " Centimetros");

            Console.WriteLine(num1.Milimetro + " Milimetros");

            Console.WriteLine(num1.Micrometro + " Micrometros");

            Console.WriteLine(num1.Nanometro + " Nanometros");

            Console.WriteLine(num1.Milha + " Milhas");

            Console.WriteLine(num1.Jarda + " Jardas");

            Console.WriteLine(num1.Pe + " Pés");

            Console.WriteLine(num1.Polegada + " Polegadas");

            Console.WriteLine(num1.Milhanautica + " Milhasnauticas");
        }
    }
}
