using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TS_AN_LAB4__task_2_
{
    class A : B
    {
        public string Company { get; set; }
        public A (string name, string company) : base(name)
        {
            Company = company;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} працює в {Company}");
            Debug.WriteLine("Виводиться стрічка з потріною інформацією.");
        }
    
    }
}
