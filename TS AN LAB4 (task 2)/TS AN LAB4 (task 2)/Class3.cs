using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TS_AN_LAB4__task_2_
{
    class B
    {
       
            public string Name { get; set; }
            public B (string name)
            {
                Name = name;
            }
            public virtual void Display()
            {
            Console.WriteLine($"Директором компанії являється {Name}") ;
            Debug.WriteLine("Виводиться стрічка з потріною інформацією.");
        }
            
            
    }
}
