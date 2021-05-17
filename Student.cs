using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Student
    {
        int id;
        string name;
        DateTime dob;
        int type;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int Type { get => type; set => type = value; }

        public Student()
        {
        }

        public Student(int id, string name, DateTime dob)
        {
            this.Id = id;
            this.Name = name;
            this.Dob = dob;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Id, Name, Dob);
        }

        public virtual void Input()
        {
            Console.WriteLine("Input student's info:"); ;
            Console.WriteLine("Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("DOB: ");
            Dob = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
