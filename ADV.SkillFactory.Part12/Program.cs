using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ADV.SkillFactory.Part12
{
    /// <summary>
    /// С этого класса все начинается 
    /// </summary>
    class Program
    {
        public int MyProperty { get; set; }

        /// <summary>
        /// Это главный метод 
        /// </summary>
        /// <param name="args">Аргументы</param>
        static void Main(string[] args)
        {
            //#region Cycles

            //var listBackgroundColor = Enum.GetValues(typeof(ConsoleColor));
            //string helloWord = "Hello World!!!!!";

            //do
            //{
            //    int i = 0;
            //    foreach (ConsoleColor color in listBackgroundColor)
            //    {
            //        char letter = helloWord[i];

            //        if (color == ConsoleColor.Black)
            //        {
            //            Console.ForegroundColor = ConsoleColor.White;
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = color;
            //        }

            //        Console.Write(letter);
            //        Thread.Sleep(100);
            //        i++;
            //    }

            //    i = 0;

            //    Console.WriteLine(" ");
            //    Thread.Sleep(2000);

            //} while (true);

            //#endregion

            #region Array

            string[] brick = new string[3];
            for (int i = 0; i < brick.Length;  i= i +1)
            {
                brick[i] = "Кирпич " + i;
            }

            foreach (var item in brick)
            {
                Console.WriteLine(item);
            }

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Tuple

            var anketa = ("Дмитрий", 17);

            Console.WriteLine("Меня зовут " + anketa.Item1 + " мне лет " + anketa.Item2);

            #endregion

            Console.ReadLine();
        }
    }
}
