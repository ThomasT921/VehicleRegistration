using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_Final_Project
{
    class Truck : Vehicle
    {
        //private vars
        private string _make, _model, _drive, _engine, _cabStyle, _size;
        //defualt constructors
        public Truck()
        {

        }
        //overload constructors
        public Truck(string make, string model, string drive, string engine, string style, string size) : base("milage", "vin", "year", "trans", "color", "type")
        {
            _make = make;
            _model = model;
            _drive = drive;
            _engine = engine;
            _cabStyle = style;
            _size = size;
        }
        //set methods--------------
        public string truckModel
        {
            get { return _model; }
            set { _model = value; }
        }
        public string truckMake
        {
            get { return _make; }
            set { _make = value; }
        }
        public string truckDrive
        {
            get { return _drive; }
            set { _drive = value; }
        }
        public string truckEngine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public string truckStyle
        {
            get { return _cabStyle; }
            set { _cabStyle = value; }
        }
        public string truckSize
        {
            get { return _size; }
            set { _size = value; }
        }
        /////////////////////////////
    }
}
