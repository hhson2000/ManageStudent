using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class ForeignStudent : Student
    {
        string country;

        public string Country { get => country; set => country = value; }

        public ForeignStudent()
        {
        }

        public ForeignStudent(int id, string name, DateTime dob, string country) : base(id, name, dob)
        {
            this.Country = country;
        }

        public override string ToString()
        {
            return base.ToString() + Country;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Country:");
            Country = Console.ReadLine();
        }
    }
}
