using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16SepEvining
{
    internal class Details
    {
        public string name;
       public int age;
       public long Contact;
        public Details(string name,int age,long Contact)
        {
            this.name = name;
            this.age = age;
            this.Contact = Contact;
        }
        public Details()
        {

        }
        public override string ToString()
        {
            return name + " " + age + " " + Contact;
        }
    }
}
