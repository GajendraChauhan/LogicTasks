using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDesignPattern();
        }

        /// <summary>
        /// Singleton Pattern implementation.
        /// Used sealed modifier with singleton class as
        /// we can access class using nested class.
        /// </summary>
        private static void SingletonDesignPattern()
        {
            SingletonPattern fromEmployee = SingletonPattern.GetInstance;
            fromEmployee.DiaplayMessage("This call is from Employee");
            SingletonPattern fromStudent = SingletonPattern.GetInstance;
            fromStudent.DiaplayMessage("This call is from student");

            /*Calling nested class to access singleton class objects.*/
            //Console.WriteLine("---------------------------");
            //SingletonPattern.DerivedClass derivedClass = new SingletonPattern.DerivedClass();
            //derivedClass.DiaplayMessage("Calling feom derived class");

            Console.ReadKey();
        }
    }
}
