using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Manager
    {
        public static int menu()
        {
            Console.WriteLine("1. Student");
            Console.WriteLine("2. VietNam Student");
            Console.WriteLine("3. Foreign Student");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Exit");
            int choice = Validation.checkLimit(6, 1);
            return choice;
        }

        public static void createStudent(List<Student> students, int type)
        {
            while (true)
            {
                Console.WriteLine("Input student's info:"); ;
                Console.WriteLine("Id: ");
                int id = Convert.ToInt32(Validation.checkInputString());
                Console.WriteLine("Name: ");
                string name = Validation.checkInputString();
                Console.WriteLine("DOB: ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Student st = new Student(id,name,dob);
                //check id exist or not
                if (Validation.checkIdExist(students, id))
                {
                    switch (type)
                    {
                        case 0:
                            createStudent(students, st);
                            break;
                        case 1:
                            createVNStudent(students, st);
                            break;
                        case 2:
                            createForeignStudent(students, st);
                            break;
                    }
                }
                else
                {
                    return;
                }

                Console.WriteLine("Do you want to continue (Y/N): ");
                //check user want to create new candidate or not
                if (!Validation.checkInputYN())
                {
                    return;
                }

            }
        }

        public static void createStudent(List<Student> students, Student student)
        {
            students.Add(new Student(student.Id, student.Name, student.Dob));
            Console.WriteLine("Create success.");
        }

        public static void createVNStudent(List<Student> students, Student student)
        {
            Console.WriteLine("Identity number:");
            string Idnumber = Validation.checkInputString();
            students.Add(new VNStudent(student.Id ,student.Name ,student.Dob , Idnumber));
            Console.WriteLine("Create success.");
        }

        public static void createForeignStudent(List<Student> students, Student student)
        {
            Console.WriteLine("Country");
            string country = Validation.checkInputString();
            students.Add(new ForeignStudent(student.Id, student.Name, student.Dob, country));
            Console.WriteLine("Create success.");
        }

        public static void searchStudent(List<Student> students)
        {
            printListStudent(students);
            Console.WriteLine("Enter name of Student (First name or Last name): ");
            String nameSearch = Validation.checkInputString();
            Console.WriteLine("Enter type of candidate: ");
            int typeStudent = Validation.checkLimit(0, 2);
            foreach (Student s in students)
            {
                if (s.Type == typeStudent
                        && s.Name.Contains(nameSearch))
                {
                    Console.WriteLine(s.ToString());
                }
            }
        }

        public static void printListStudent(List<Student> students)
        {
            Console.WriteLine("Experience student");
            students.ForEach(Console.WriteLine);
        }
    }
    
}
