using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TS_AN_LAB4__task_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            B p1 = new B ("Петро Вакуленко");
            p1.Display(); 

            A p2 = new A ("Олег Іванов", "Білі літаки");
            p2.Display(); 

            C p3 = new C ("Дмитро", "Петренко");
            p3.Display();

            G p4 = new G ("Петро Вакуленко","знайти помічника ");
            p4.Display();


            Console.ReadKey();
        }
    }

    

}
