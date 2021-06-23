using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Basics
{  
    class BMI_Calculator
    {
        private string name;
        private float height;
        private float weight;
        private int age;
        double bmi;


        public void userInfo(string _name, float _height, float _weight, int _age) {

            Console.WriteLine("Enter Name: ");
            _name = Console.ReadLine();
            this.name = _name;
            Console.WriteLine("Enter Height in M ");
            _height = float.Parse(Console.ReadLine());
            this.height = _height;
            Console.WriteLine("Enter weight in KG");
            _weight = float.Parse(Console.ReadLine());
            this.weight = _weight;
            Console.WriteLine("Enter yout age: ");
            _age = int.Parse(Console.ReadLine());
            this.age = _age;
        }


        public void BMI_Conditions(double _bmi) {
            this.bmi = _bmi;
            if (_bmi < 18.5) {
                Console.WriteLine("You have Low BMI: " + bmi);
            }
            else if (_bmi > 18.5 && _bmi < 25) {

                Console.WriteLine("Your BMI is: " + bmi + " Healthy");
            }
             
            else if (_bmi > 25 && _bmi < 30) {
                Console.WriteLine("Your BMI is: " + bmi + " Overweight");
            }

            else if (_bmi > 30) {
                Console.WriteLine("Your BMI is: " + bmi + " Obesity");
            }
        }

        public void BMI_Cal() 
        {
            userInfo(name, height, weight, age);

            Console.WriteLine("Your Name: " + name);
            Console.WriteLine("Your age: " + age);

            bmi = weight / Math.Pow(height, 2);

            BMI_Conditions(bmi);
        
        
        }
    }
}
