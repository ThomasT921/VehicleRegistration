using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Final_Project
{
    class Vehicle
    {
        //private vars
        private string _milage, _vinNumber, _year, _transmission, _color, _type;
        //default constructors
        public Vehicle()
        {
            
        }
        // overload constructors
        public Vehicle(string milage, string vin, string year, string trans, string color, string type)
        {
            _milage = milage;
            _vinNumber = vin;
            _year = year;
            _transmission = trans;
            _color = color;
            _type = type;
        }
        //set method----------------
        public string vehicleMilage
        {
            get { return _milage; }
            set { _milage = value; }
        }
        public string vehicleVin
        {
            get { return _vinNumber; }
            set { _vinNumber = value; }
        }
        public string vehicleYear
        {
            get { return _year; }
            set { _year = value; }
        }
        public string vehicleTrans
        {
            get { return _transmission; }
            set { _transmission = value; }
        }
        public string vehicleColor
        {
            get { return _color; }
            set { _color = value; }
        }
        public string vehicleType
        {
            get { return _type; }
            set { _type = value; }
        }
        ////////////////////////////////
    }
}
