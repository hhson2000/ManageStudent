using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class VNStudent : Student
    {
        string idnumber;

        public string Idnumber { get => idnumber; set => idnumber = value; }

        public VNStudent()
        {
        }

        public VNStudent(int id, string name, DateTime dob, string idnumber) : base(id, name, dob)
        {
            this.Idnumber = idnumber;
        }

        public override string ToString()
        {
            return base.ToString() + Idnumber;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Identity number:");
            Idnumber = Console.ReadLine();
        }
    }
}
