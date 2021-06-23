using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Basics
{
    class ArrayCompare
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        int n,m;

        public void ArrayInput()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter Array1 value: ");
                array1[i] = Int32.Parse(Console.ReadLine());
            }

            for (int l = 0; l < array2.Length; l++)
            {
                Console.WriteLine("Enter Array2 value: ");
                array2[l] = Int32.Parse(Console.ReadLine());
            }

            n = array1[0];
            for (int j = 0; j < array1.Length; j++)     
            {
                    if (array1[j] > n)
                    {
                        n = array1[j];                        
                    }   
            }
            Console.WriteLine("Number is:" + n);
            Arrays_Compare();
        }

        public void Arrays_Compare() 
        {
            m = array2[0];
            
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j] > m)
                    {
                        m = array2[j];
                    }
                }

            if (m > n)
            {
                Console.WriteLine("m is greate: " + m);

            }

            else if (n > m)
            {
                Console.WriteLine("n is greater: " + n);
            }        
        }
    }
}

