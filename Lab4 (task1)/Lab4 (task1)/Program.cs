using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;




namespace TS_AN_LAB4__task1_

{
    public class Class1
    {
        public virtual void PrintToDebug(params object[] args)
        {
            Debug.WriteLine("Цифри:");
            Debug.Indent();

            foreach (var arg in args)
                Debug.WriteLine(arg);

            Debug.Unindent();
        }
    }


    public class Class2 : Class1
    {
        public override void PrintToDebug(params object[] args)
        {
            Debug.WriteLine("Аргументи:");

            foreach (var arg in args)
                Debug.WriteLine($"http://{arg.GetType()}: {arg}");


        }
        class Program
        {
            static void Main(string[] args)
            {
                Class1[] classes = new[]
                {
                new Class1(),
                new Class2()
            };


                foreach (Class1 c in classes)
                    c.PrintToDebug(
                        121,
                        456,
                        21.1,
                        43.12,
                        5422.4);





                Console.ReadLine();
            }
        }
    }
}
