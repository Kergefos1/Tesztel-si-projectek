using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Passenger
    {
        private string _name;
        private int _age;
        private int _bagCount;

        public string Name { get { return _name; } set { _name= value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int BagCount { get { return _bagCount; } set { _bagCount = 0; } }

        public Passenger(string name,int age,int bagCount)
        {
            _name = name;
            _age = age;
            _bagCount = bagCount;
        }
        public bool AddBag()
        {
            if (_bagCount <= 2)
            {
                _bagCount++;
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool IsChild()
        {
            if(_age>=12)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
