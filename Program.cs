using System;

namespace NumberIfEven
{
    class Answer
    {
        static void CheckIfEven(int number)
        {
            bool isEven;
            isEven = (number % 2 == 0) ? true : false;
            if(isEven)
            {
                Console.WriteLine("Число " + number + " четное");
            }
            else
            {
                Console.WriteLine("Число " + number + " нечетное");
            }
            
        }
    
        static public void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number;

            if(args.Length >= 1)
            {
                number = int.Parse(args[0]);
            }
            else
            {
                number = 6;
            }
            CheckIfEven(number);
        }
    }

}
