using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Basics
{
    public class Reverse_String
    {
        string[] str;
        string reverse;
        string name;

        public void inputUser()
        {

            List<string> names = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                if (name.Length > 0 && name.Length <= 10)
                {
                    names.Add(name);
                    str = names.ToArray();
                   
                }

                else if (name.Length.Equals(" "))
                {
                    Console.WriteLine("Entered Null Value");
                }

                else
                {
                    Console.WriteLine("Limit Exeeded");
                }
            }

            Console.WriteLine("Name entered: {0}: ", name);
            reverseFunc();

        }

        public void reverseFunc()
        {
            
                for (int j = str.Length - 1; j >= 0; j--)
                {
                   
                    reverse = reverse + str[j];
                }

                Console.WriteLine("Reverse string is: {0} ", reverse);
                Console.ReadLine();
            
        }
    }
}
