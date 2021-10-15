using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB4__task_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            var license = new AppLicense();

            Console.WriteLine("Введіть ваш ключ!");
            license.ChangeLicense(Console.ReadLine());

            Console.WriteLine($"Ваша ліцензія: {license.License}");

            Console.WriteLine("Вам доступні такі операції:");
            Console.WriteLine(@"Додавання - '+' (Common+)");
            Console.WriteLine(@"Множення - '*' (Trial+)");
            Console.WriteLine(@"Степінь - '^' (Pro+)");
            Console.WriteLine();

            Console.WriteLine("Введіть першу цифру!");
            double Number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть другу цифру!");
            double Number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть знак операції!");
            char operation = Console.ReadLine()[0];

            

            Console.WriteLine();

            Console.WriteLine($"Ваша ліцензія: {license.License}");

            switch (operation)
            {
                case '+':
                    Console.WriteLine("Додавання доступно!");
                    Console.WriteLine($"Відповідь: {Number1 + Number2}");
                    break;

                case '*':
                    if (license.License >= LicenseType.Trial)
                    {
                        Console.WriteLine("Множення доступне!");
                        Console.WriteLine($"Відповідь: {Number1 * Number2}");
                    }
                    else
                        Console.WriteLine("Операція множення не доступна!");

                    break;

                case '^':
                    if (license.License >= LicenseType.Pro)
                    {
                        Console.WriteLine("Оперція степінь доступна!");
                        Console.WriteLine($"Відповідь: {Math.Pow(Number1, Number2)}");
                    }
                    else
                        Console.WriteLine("Операція степінь не доступна!");

                    break;
            }

            Console.ReadLine();
        }
    }
  
}
