using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class Student : Person
    {
        //attributes & get-set attributes
        public string id { get; set; }
        public string batch { get; set; }

        //constructor
        public Student() { }
        public Student(string id, string name, DateTime dob, string email, string address, string batch)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.email = email;
            this.address = address;
            this.batch = batch;
        }

        public string DisplayStudent()
        {
            return ("Student id: " + id + 
                "\nStudent name: " + name + 
                "\nDob: "          + dob.ToString("dd/MM/yyyy") + 
                "\nEmail: "        + email + 
                "\nAddress: "      + address + 
                "\nBatch: "        + batch);
        }
    }
}
