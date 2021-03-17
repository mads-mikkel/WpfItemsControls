using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItemsControls
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            return FullName();
        }
    }
}
