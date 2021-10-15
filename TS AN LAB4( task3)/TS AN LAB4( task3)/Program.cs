using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace OverrideAndNew2
{
    class Program
    {
        static void Main(string[] args)
        {

            TestCars1();


        }

        public static void TestCars1()
        {
            System.Console.WriteLine("\nTestCars1");
            System.Console.WriteLine("----------");

            Car car1 = new Car();
            car1.DescribeCar();
            System.Console.WriteLine("----------");


            Audi car2 = new Audi();
            car2.DescribeCar();
            System.Console.WriteLine("----------");

            BMW car3 = new BMW();
            car3.DescribeCar();
            System.Console.WriteLine("----------");
        }


        class Car
        {
            public virtual void DescribeCar()
            {
                System.Console.WriteLine("Комфортна машина для вас та вашої сім'ї!");
                ShowDetails();

            }

            public virtual void ShowDetails()
            {
                System.Console.WriteLine("Всі складові машини мають чудовий стан!");
            }
        }


        class Audi : Car
        {
            public override void ShowDetails()
            {
                System.Console.WriteLine("Адаптивна підвіска, яка може працювати в різних режимах — від Comfort до Sport+");
                Debug.WriteLine("Цей метод виводить потрібну інформацію, про машину!");
            }
        }


        class BMW : Car
        {
            public override void ShowDetails()
            {
                System.Console.WriteLine("Автомобіль з гідним зовнішнім виглядом, відмінною динамікою, керованістю, комфортом.");
                Debug.WriteLine("Цей метод виводить потрібну інформацію, про машину!");
            }
        }

    }
}