using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Student_Management_System
{
    class Lecturer : Person
    {
        //attributes & get-set attributes
        public string id { get; set; }
        public string department { get; set; }

        //constructor
        public Lecturer() { }
        public Lecturer(string id, string name, DateTime dob, string email, string address, string department)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.email = email;
            this.address = address;
            this.department = department;
        }
        //display
        public string DisplayLecturer()
        {
            return ("Lecturer id: " + id +
                    "\nLecturer name: " + name +
                    "\nDob: " + dob.ToString("dd/MM/yyyy") +
                    "\nEmail: " + email +
                    "\nAddress: " + address +
                    "\nDepartment: " + department);
        }

    }
}




