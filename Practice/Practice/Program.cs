using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like music to be played while you calculate?");
            string music = Console.ReadLine();
            if(music == "yes" || music == "Yes")
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\jazz.wav";
                player.Play();
            }
            else
            {
                Console.WriteLine("You seem like a very boring individual");
                Sleep();
                Console.WriteLine(".");
                Sleep();
                Console.WriteLine(".");
                Sleep();
                Console.WriteLine("whatever...");
                Sleep();
            }
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("What would you like to do?");
                string answer = Console.ReadLine();
                Console.WriteLine("Type the numbers you would like to " + answer + ", seperated by commas");
                String numbers = Console.ReadLine();
                String[] numbersArray = numbers.Split(new string[] { "," }, StringSplitOptions.None);
                int length = numbersArray.Length;
                int i = 0;
                int result = 0;
                int convertedI = 0;
                int[] convertedInt = new int[length];
                while (convertedI != length)   //wtf did I do here
                {
                    convertedInt[convertedI] = Int32.Parse(numbersArray[convertedI]);
                    convertedI++;
                }




                if (answer.Equals("add", StringComparison.CurrentCultureIgnoreCase) || answer.Equals("+", StringComparison.CurrentCultureIgnoreCase))
                {
                    while (i < length)
                    {
                        result = result + convertedInt[i];
                        i++;
                    }
                }

                if (answer.Equals("multiply", StringComparison.CurrentCultureIgnoreCase) || answer.Equals("*", StringComparison.CurrentCultureIgnoreCase))
                {
                    result = 1;
                    while (i < length)
                    {
                        result = result * convertedInt[i];
                        i++;
                    }
                }
                if (answer.Equals("division", StringComparison.CurrentCultureIgnoreCase) || answer.Equals("/", StringComparison.CurrentCultureIgnoreCase))
                {
                    result = convertedInt[0];
                    i = 1;
                    while (i < length)
                    {
                        result = result / convertedInt[i];
                        i++;
                    }
                }
                Console.WriteLine("Your final answer is " + result);
                Console.ReadLine();
                Console.WriteLine("Would you like to go again?");
                string ifloop = Console.ReadLine();
                if (ifloop == "yes" || ifloop == "Yes")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }
        }
        public static void Sleep()
        {
            Thread.Sleep(500);

        }



    }
}
