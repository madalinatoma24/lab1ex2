using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 2 Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura */
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            Console.WriteLine("Introduceti primul numar: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar: ");
            thirdNumber = int.Parse(Console.ReadLine());

            int media = (firstNumber + secondNumber + thirdNumber)/ 3;

            Console.WriteLine("Media aritmetica este: " + media);
        }
    }
}
