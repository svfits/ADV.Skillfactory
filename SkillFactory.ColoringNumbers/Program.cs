using System;
using System.Linq;

namespace SkillFactory.ColoringNumbers
{
    class Program
    {
        static Random random = new Random();

        public static void Main()
        {
            const string HelloWorldRus = "ПриветМир!!!!";
            const string HelloWorldEn = "HelloWord!!!!";
            const string HelloWorldEs = "HolaMundo!!!!";

            var str = new[] { HelloWorldEn, HelloWorldRus, HelloWorldEs };
            var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
            
            do
            {
                foreach (var strs in str)
                {
                    foreach (var word in strs)
                    {
                        var rnd = random.Next(list.Count());
                        Console.ForegroundColor = list[rnd];

                        Console.Write(word);
                        System.Threading.Thread.Sleep(150);
                    }
                
                    Console.WriteLine();
                }
            } while (true);
        }
    }
}
