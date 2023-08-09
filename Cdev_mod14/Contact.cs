using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdev_mod14
{
    public class Contact
    {

        public String Name { get; set; }
        public String LastName { get; set; }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
        public Contact(string name, string lastName, long phoneNumber, String email)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }


    }
}
