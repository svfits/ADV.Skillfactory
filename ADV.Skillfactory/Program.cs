using System;

namespace ADV.Skillfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Name = "Name ";

            #region 11
            Console.WriteLine("Минимальное значение для byte " + Name);

            string myName = "Меня зовут Дмитрий";
            Console.WriteLine("Минимальное значение для byte " + myName);

            var minByte = byte.MinValue;
            Console.WriteLine("Минимальное значение для byte " + minByte);

            var minDecimal = decimal.MinValue;
            Console.WriteLine("Минимальное значение для decimal" + minDecimal);

            var today = DateTime.Now.DayOfWeek;

            if (today == DayOfWeek.Monday)
            {
                Console.WriteLine("Сегодня четверг и на ужин будет рыба!");
            }
            else
            {
                Console.WriteLine("Сегодня не четверг и на ужин НЕ будет рыбы!");
            }

            double ddd = (double)5 / 2;
            Console.WriteLine(ddd);

            int i = 0;

            var per = ddd == 2.5 ? i = 1 : i = 2;

            #endregion

            var param = Console.ReadLine();
            Console.WriteLine("Было введено " + param);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
