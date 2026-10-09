using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Flight
    {
        private string _code;
        private string _destination;
        private int _basePrice;
        private int _freeSeats;

        public string Code { get { return _code; } set { _code = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }
        public int BasePrice { get { return _basePrice; } set { _basePrice = value; } }
        public int FreeSeats { get { return _freeSeats; } set { _freeSeats = value; } }

        public Flight(string code, string dest, int price,int freeseats)
        {
            _code = code;
            _destination = dest;
            _basePrice = price;
            _freeSeats = freeseats;
        }

        public bool BookSeats()
        {
            if (_freeSeats > 0)
            {
                _freeSeats--;
                return true;
            }
            else
                return false;
        }

        public string Describe()
        {
            if(BookSeats())
                return $"{Code}, {Destination}, {BasePrice}, {FreeSeats}";
            else
                return $"{Code}, {Destination}, {BasePrice}, Telt ház";
        }



    }
}
