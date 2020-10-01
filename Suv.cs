using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Final_Project
{
    class Suv : Vehicle
    {
        // private vars
        private string _make, _model, _drive, _engine, _style, _seats;
        //defualt constructors
        public Suv()
        {

        }
        //overload constructors
        public Suv(string make, string model, string drive, string engine, string style, string seats) : base("milage", "vin", "year", "trans", "color", "type")
        {
            _make = make;
            _model = model;
            _drive = drive;
            _engine = engine;
            _style = style;
            _seats = seats;
        }
        //set methods--------------
        public string suvModel
        {
            get { return _model; }
            set { _model = value; }
        }
        public string suvMake
        {
            get { return _make; }
            set { _make = value; }
        }
        public string suvDrive
        {
            get { return _drive; }
            set { _drive = value; }
        }
        public string suvEngine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public string suvStyle
        {
            get { return _style; }
            set { _style = value; }
        }
        public string suvSeats
        {
            get { return _seats; }
            set { _seats = value; }
        }
        ////////////////////////////

    }
}
