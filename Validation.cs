using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class Validation
    {
        public static int checkLimit(int max, int min)
        {
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine().Trim());
                    if (result < min || result > max)
                    {
                        throw new FormatException();

                    }
                    return result;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please input number in rage [" + min + ", " + max + "]");
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        public static String checkInputString()
        {
            //loop until user input correct
            while (true)
            {
                String result = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Not empty");
                    Console.WriteLine("Enter again: ");
                }
                else
                {
                    return result;
                }
            }
        }

        public static Boolean checkInputYN()
        {
            //loop until user input correct
            while (true)
            {
                String result = checkInputString();
                //check user input y/Y or n/N
                if (String.Equals(result, "Y", StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
                else if (String.Equals(result, "N", StringComparison.InvariantCultureIgnoreCase))
                {
                    return false;
                }
                Console.WriteLine("Please input y/Y or n/N.");
                Console.WriteLine("Enter again: ");
            }
        }

        public static Boolean checkIdExist(List<Student> students, int id)
        {
            foreach (Student s in students)
            {
                if (String.Equals(Convert.ToString(s.Id), Convert.ToString(id) , StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Id exist.");
                    return false;
                }
            }
            return true;
        }
    }
}
