using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            while (true)
            {
                int choice = Manager.menu();
                switch (choice)
                {
                    case 1:
                        Manager.createStudent(student, 0);
                        break;
                    case 2:
                        Manager.createStudent(student, 1);
                        break;
                    case 3:
                        Manager.createStudent(student, 2);
                        break;
                    case 4:
                        Manager.printListStudent(student);
                        break;
                    case 5:
                        Manager.searchStudent(student);
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}
