using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Student_Management_System
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Display()
        {
            return ("**" + "\t" + "StudentId: " + Id + "\t" + "StudentName: " + Name + "\t" + "**");
        }
    }

    internal class DemoLinQ
{
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> student = new List<Student>();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nPlease select the options: ");
                    Console.WriteLine("1. Create a new student");
                    Console.WriteLine("2. Show All Students");
                    Console.WriteLine("3. Update Student by ID");
                    Console.WriteLine("4. Delete Student by ID");
                    Console.WriteLine("5. Search Student by ID");
                    Console.WriteLine("6. Stop the program");

                    Console.Write("\nYour option: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    //create
                    if (choice == 1)
                    {
                        Console.Write("Input ID: ");
                        int Id = int.Parse(Console.ReadLine());
                        Console.Write("Input Name: ");
                        string Name = Console.ReadLine();
                        student.Add(new Student(Id, Name));

                        Console.WriteLine("\nCreate done!");
                    }
                    //show list
                    else if (choice == 2)
                    {
                        Console.WriteLine("List Student: \n");
                        Console.WriteLine();

                        foreach (Student std in student)
                        {
                            Console.WriteLine(std.Display());
                            Console.Write("\t");
                            for (int i = 0; i < std.Display().Length; i++)
                            {
                                Console.Write("");
                            }
                            Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }
                    //update
                    else if(choice == 3)
                    {
                        Console.Write("ID: ");
                        int  UpdateById = int.Parse(Console.ReadLine());
                        var updateStudent = student.Find(x => x.Id.Equals(UpdateById));
                        if (updateStudent == null)
                            Console.WriteLine("Can not find!");
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Update student");
                            Console.WriteLine("=====================\n");

                            Console.Write("ID update: ");
                            updateStudent.Id = int.Parse(Console.ReadLine());
                            Console.Write("Name update: ");
                            updateStudent.Name = Console.ReadLine();
                            Console.WriteLine("\nUpdate done!");
                        }
                    }
                   
                    //delete
                    else if (choice == 4)
                    {
                        Console.Write("Input Id: ");
                        int Id = int.Parse(Console.ReadLine());
                        var std = student.FirstOrDefault(x => x.Id.Equals(Id));
                        if (std == null) Console.WriteLine("Cant Find !!");
                        else
                        {
                            student.Remove(std);
                            Console.WriteLine("Remove done!");
                        }
                    }
                    //search
                    else if (choice == 5)
                    {
                        Console.Write("Input Student Id: ");
                        int Id = int.Parse(Console.ReadLine());
                        var kq = student.FirstOrDefault(x => x.Id.Equals(Id));
                        if (kq == null) Console.WriteLine("Can't find!!");
                        else Console.WriteLine(kq.Display());
                    }
                    //stop
                    else if (choice == 6) break;
                    else
                    {
                        Console.WriteLine("Incorrect, please re-enter!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
