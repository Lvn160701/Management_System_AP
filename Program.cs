using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // output Vietnamese if nesscessary
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // create 2 lists to contain Student and lecturer
            List<Student> std = new List<Student>();
            List<Lecturer> lec = new List<Lecturer>();

            while (true)
            {
                try
                {
                    //Origin Menu
                    Console.WriteLine("*** STUDENT MANAGEMENT SYSTEM ***\n");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1.   Manage Students");
                    Console.WriteLine("2.   Manage Lecturers");
                    Console.WriteLine("3.   Exit");
                    Console.WriteLine("=================================");
                    Console.Write("Please choose: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (choice)
                    {
                        // case 1
                        case 1:
                            // Sub Menu - Student
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("\t\n*** STUDENT MANAGEMENT SYSTEM ***");
                                    Console.WriteLine("\tPlease choose from the functions below");
                                    Console.WriteLine("======================================================" +
                                       "\n\t 1.  Add new student" +
                                       "\n\t 2.  View all students" +
                                       "\n\t 3.  Update student" +
                                       "\n\t 4.  Delete students" +
                                       "\n\t 5.  Search students" +
                                       "\n\t 6.  Back to main menu" +
                                       "\n======================================================"
                                       );

                                    Console.Write("Please choose: ");
                                    int chon = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    // add new
                                    if (chon == 1)
                                    {
                                        Console.WriteLine("Create a new student");
                                        Console.WriteLine("=====================");
                                        //check the number of characters entered 
                                        const int idMax = 6;
                                        string id ;
                                        while (true)
                                        {
                                            Console.Write("Student id: ");
                                            id = Console.ReadLine();
                                            if (id.Length > idMax)
                                            {
                                                id = id.Substring(0, idMax);
                                                Console.WriteLine("*Shortened to 6 characters!\n");
                                                break;
                                            }
                                            else if (id.Length == idMax) break;
                                            else { Console.WriteLine("*Please enter enough 6 characters"); }
                                        }
                                       
                                        Console.Write("Student name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Date of birth: ");
                                        DateTime dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Address: ");
                                        string add = Console.ReadLine();
                                        Console.Write("Mail: ");
                                        string mail = Console.ReadLine();
                                        Console.Write("Batch: ");
                                        string batch = Console.ReadLine();

                                        std.Add(new Student(id, name, dob, add, mail, batch));
                                        Console.WriteLine("\nSuccessfully created!");
                                    }
                                    //view
                                    else if (chon == 2)
                                    {
                                        Console.WriteLine("===* List all of student *===\n");
                                        foreach (Student stu in std)
                                        {
                                            Console.WriteLine(stu.DisplayStudent());
                                            Console.WriteLine("-----------------------------");
                                        }
                                    }
                                    else if (chon == 3)
                                    {
                                        Console.WriteLine("Update Student profile");
                                        Console.WriteLine("=========================\n");
                                        Console.Write("Id? = ");
                                        string UpdateById = Console.ReadLine();
                                        var updateStudent = std.Find(x => x.id.Equals(UpdateById));
                                        if (updateStudent == null)
                                            Console.WriteLine("Can not find!");
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Update a new student");
                                            Console.WriteLine("=====================\n");
                                            Console.Write("Name update: ");
                                            updateStudent.name = Console.ReadLine();
                                            Console.Write("Dob update: ");
                                            updateStudent.dob = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Address update: ");
                                            updateStudent.address = Console.ReadLine();
                                            Console.Write("Mail update: ");
                                            updateStudent.email = Console.ReadLine();
                                            Console.Write("Batch update: ");
                                            updateStudent.batch = Console.ReadLine();

                                            Console.WriteLine("\nSuccessfully updated!");
                                        }
                                    }
                                    //delete student
                                    else if (chon == 4)
                                    {
                                        Console.WriteLine("Remove a student");
                                        Console.WriteLine("====================\n");
                                        Console.Write("Id? = ");
                                        string DeleteById = Console.ReadLine();
                                        var deleteStudent = std.Find(x => x.id.Equals(DeleteById));
                                        if (deleteStudent == null)
                                            Console.WriteLine("Can not find!");
                                        else
                                        {
                                            std.Remove(deleteStudent);
                                            Console.WriteLine("Successfully removed!");
                                        }

                                    }
                                    //search students
                                    else if (chon == 5)
                                    { 
                                        Console.WriteLine("Searching for students");
                                        Console.WriteLine("=======================\n");
                                        Console.Write("Enter name or id: ");
                                        string SearchByNameOrId = Console.ReadLine();
                                        var SearchStudent = std.Where(x => x.name.Contains(SearchByNameOrId) || x.id.Equals(SearchByNameOrId));

                                        Console.WriteLine("Search results: \n");
                                        foreach (Student student in SearchStudent)
                                        {
                                            Console.WriteLine(student.DisplayStudent());
                                            Console.WriteLine("----------------------------");
                                        }
                                    }
                                    else if (chon == 6)
                                    { break; }
                                }
                                catch
                                {
                                    ErrorNotify er = new ErrorNotify();
                                    er.checkInput();
                                }
                            }

                            break;
                        // case 2
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("\t*** LECTURER MANAGEMENT SYSTEM ***");
                                Console.WriteLine("\tPlease choose from the functions below");
                                Console.WriteLine("======================================================" +
                                "\n\t 1.  Add new lecturer" +
                                "\n\t 2.  View all lecturers" +
                                "\n\t 3.  Update lecturer" +
                                "\n\t 4.  Delete students" +
                                "\n\t 5.  Search lecturers" +
                                "\n\t 6.  Back to main menu" +
                                "\n======================================================"
                                );
                                // Sub Menu - Lecturer
                                try
                                {
                                    Console.Write("Please choose: ");
                                    int chonn = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    //create lecturer
                                    if (chonn == 1)
                                    {
                                        Console.WriteLine("Create a new lecturer");
                                        Console.WriteLine("=====================");
                                        //check the number of characters entered 
                                        const int idMax = 6;
                                        string id;
                                        while (true)
                                        {
                                            Console.Write("Lecturer id: ");
                                            id = Console.ReadLine();
                                            if (id.Length > idMax)
                                            {
                                                id = id.Substring(0, idMax);
                                                Console.WriteLine("*Shortened to 6 characters!\n");
                                                break;
                                            }
                                            else if (id.Length == idMax) break;
                                            else { Console.WriteLine("*Please enter enough 6 characters"); }
                                        }

                                        Console.Write("Lecturer name: ");
                                        string name = Console.ReadLine();
                                        Console.Write("Date of birth: ");
                                        DateTime dob = DateTime.Parse(Console.ReadLine());
                                        Console.Write("Address: ");
                                        string add = Console.ReadLine();
                                        Console.Write("Mail: ");
                                        string mail = Console.ReadLine();
                                        Console.Write("Department: ");
                                        string department = Console.ReadLine();

                                        lec.Add(new Lecturer(id, name, dob, add, mail, department));
                                        Console.WriteLine("\nSuccessfully created!");
                                    }
                                    //view lecturer
                                    else if (chonn == 2)
                                    {
                                        Console.WriteLine("\n===* List all of Lecturer *===\n");
                                        foreach (Lecturer lect in lec)
                                        {
                                            Console.WriteLine(lect.DisplayLecturer());
                                            Console.WriteLine("-----------------------------");
                                        }
                                    }
                                    // update lecturer
                                    else if (chonn == 3)
                                    {
                                        Console.WriteLine("Update Lecturer profile");
                                        Console.WriteLine("=========================\n");
                                        Console.Write("Id? = ");
                                        string UpdateById = Console.ReadLine();
                                        var updateLecturer = lec.Find(x => x.id.Equals(UpdateById));
                                        if (updateLecturer == null)
                                            Console.WriteLine("Can not find!");
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Update a new Lecturer");
                                            Console.WriteLine("=====================\n");

                                            Console.Write("Name update: ");
                                            updateLecturer.name = Console.ReadLine();
                                            Console.Write("Dob update: ");
                                            updateLecturer.dob = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Address update: ");
                                            updateLecturer.address = Console.ReadLine();
                                            Console.Write("Mail update: ");
                                            updateLecturer.email = Console.ReadLine();
                                            Console.Write("Department update: ");
                                            updateLecturer.department = Console.ReadLine();

                                            Console.WriteLine("\nSuccessfully updated!");
                                        }
                                    }
                                    //delete lecturer
                                    else if (chonn == 4)
                                    {
                                        Console.WriteLine("Remove a Lecturer");
                                        Console.WriteLine("====================\n");
                                        Console.Write("Id? = ");
                                        string DeleteById = Console.ReadLine();
                                        var deleteLecturer = lec.Find(x => x.id.Equals(DeleteById));
                                        if (deleteLecturer == null)
                                            Console.WriteLine("Can not find!");
                                        else
                                        {
                                            lec.Remove(deleteLecturer);
                                            Console.WriteLine("Successfully removed!");
                                        }
                                    }
                                    //search lecturers
                                    else if (chonn == 5)
                                    {
                                        Console.WriteLine("Searching for Lecturer");
                                        Console.WriteLine("=======================\n");
                                        Console.Write("Enter name or id: ");
                                        string SearchByNameOrId = Console.ReadLine();
                                        var SearchLecturer = lec.Where(x => x.name.Contains(SearchByNameOrId) || x.id.Equals(SearchByNameOrId));

                                        Console.WriteLine("Search results: \n");
                                        foreach (Lecturer lect in SearchLecturer)
                                        {
                                            Console.WriteLine(lect.DisplayLecturer());
                                            Console.WriteLine("----------------------------");
                                        }
                                    }
                                    else if (chonn == 6)
                                    { break; }
                                }
                                catch
                                {
                                    ErrorNotify er = new ErrorNotify();
                                    er.checkInput();
                                }
                            }
                            Console.Clear();
                            break;
                        // case 3: Out
                        case 3: Environment.Exit(0); break;
                        default: Console.WriteLine("Notice: Wrong key, please re-enter!\n"); break;
                    }
                }catch {
                    ErrorNotify not = new ErrorNotify();
                    not.notNum(); 
                }
            }
        }
    }
}

