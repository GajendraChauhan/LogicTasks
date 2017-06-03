using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class SingletonPattern
    {
        private static int _count = 0;
        private static SingletonPattern _instance = null;

        public static SingletonPattern GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonPattern();
                return _instance;
            }
        }

        private SingletonPattern()
        {
            _count++;
        }

        public void DiaplayMessage(string message)
        {
            Console.WriteLine("Count of instance created. :- {0}", _count);
            Console.WriteLine(message);
        }

        /*This is the process we can break singleton pattern
         * and need to remove sealed from parent class.*/
        //public class DerivedClass : SingletonPattern
        //{
        //}
    }
}
