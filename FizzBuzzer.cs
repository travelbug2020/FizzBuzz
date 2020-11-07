using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public void LoopThroughNumbers()
        {

            for (var number = 1; number < 101; number++)
            {
                var result = Calculate(number);
                Console.WriteLine(result);
            }
            
           
        }

      

    public string Calculate(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
            
        }
    }
}