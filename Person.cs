using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace final
{
    public abstract class Person
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public Person(string name)
        {
            FullName = name;
        }

        public abstract string GetInfo();
    }
}