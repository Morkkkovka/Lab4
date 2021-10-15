using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TS_AN_LAB4__task_2_
{
    class C : B
    {

        public string Surname { get; set; }
        public C (string name, string surname) : base(name)
        {
            Surname = surname;
        }
        public override void Display()
        {
            Console.WriteLine($"Засновником нашої компанії є {Name} {Surname}");
            Debug.WriteLine("Виводиться стрічка з потріною інформацією.");
        }
       
    }
}
