using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TS_AN_LAB4__task_2_
{
    class G : B
    {

        public string Task { get; set; }
        public G (string name, string task) : base(name)
        {
            Task = task;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} наказав {Task}");
            Debug.WriteLine("Виводиться стрічка з потріною інформацією.");
        }
       
    }

}
