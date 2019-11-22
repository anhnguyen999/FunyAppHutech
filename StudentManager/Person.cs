using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    abstract Person
    {
        public String Falculty { get; set; }
    public string FullName { get; set; }
}
public Person()
{

}
public virtual void Input()
{
    Console.Write("Full Name = ");
    FullName = Console.ReadLine();
    Console.Write("Falculty = ");
    Falculty = Console.ReadLine();
}
public virtual void output()

}

