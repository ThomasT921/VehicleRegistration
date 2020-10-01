using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Final_Project
{
    // inherited car class from vehicle
    class Car : Vehicle
    {
        //private vars
        private string _make, _model, _drive, _engine, _style;
        // defualt constructor
        public Car()
        {

        }
        //overload constructor
        public Car(string make, string model, string drive, string engine, string style) : base("milage", "vin", "year", "trans", "color", "type")
        {
            _make = make;
            _model = model;
            _drive = drive;
            _engine = engine;
            _style = style;
        }
        //set methods------------
        public string carModel
        {
            get { return _model; }
            set { _model = value; }
        }
        public string carMake
        {
            get { return _make; }
            set { _make = value; }
        }
        public string carDrive
        {
            get { return _drive; }
            set { _drive = value; }
        }
        public string carEngine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public string carStyle
        {
            get { return _style; }
            set { _style = value; }
        }
        //////////////////////////////

    }
}
