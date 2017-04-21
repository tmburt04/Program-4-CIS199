using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class GroundPackage
    {
        private int _packageID;
        private int _originZip;
        private int _destinationZip;
        private double _length;
        private double _width;
        private double _height;
        private double _weight;
        

        public GroundPackage(int _PackageID, int _OriginZip, int _DestinationZip, double _Length, double _Width, double _Height, double _Weight)
        {
            this._packageID = _PackageID;
            this._destinationZip = _DestinationZip;
            this._length = _Length;
            this._width = _Width;
            this._height = _Height;
            this._weight = _Weight;
        }
        public int PackageID // processes package id
        {
            get
            {
                return _packageID;
            }
            set
            {
                _packageID = value;
            }
        }

        public int Origin // Limits user input to a number 0-99999
                {
                    get
                    {
                        return _originZip;
                    }
                    set
                    {
                        if ((value > 0) && (value < 100000))
                        {
                           _originZip = value;
                        }
                    }
             }
        public int Destination // Limits user input to a number 0-99999
                {
                    get
                    {
                        return _destinationZip;
                    }
                    set
                    {
                        if ((value > 0) && (value < 100000))
                        {
                           _destinationZip = value;
                        }
                    }
             }
        public double Length // Limits user input to a positive number
                {
                    get
                    {
                        return _length;
                    }
                    set
                    {
                        if (value > 0)
                        {
                           _length = value;
                        }
                    }
             }
        public double Width // Limits user input to a positive number
                {
                    get
                    {
                        return _width;
                    }
                    set
                    {
                        if (value > 0)
                        {
                           _width = value;
                        }
                    }
             }
        public double Height // Limits user input to a positive number
                {
                    get
                    {
                        return _height;
                    }
                    set
                    {
                        if (value > 0)
                        {
                           _height = value;
                        }
                    }
             }
        public double Weight // Limits user input to a positive number
                {
                    get
                    {
                        return _weight;
                    }
                    set
                    {
                        if (value > 0)
                        {
                           _weight = value;
                        }
                    }
             }
        public int ZoneDistance // calculates distance between locations
        {
            get
            {
                return Math.Abs(_destinationZip / 10000) - (_originZip / 10000);
            }
        }

        public double CalcCost() // calculates shipping cost
        {
            return (0.2 * (_length + _width + _height) + 0.5 * (ZoneDistance + 1) * _weight);
        }

        public override string ToString() // Formats the details message box
        {
            return "Package ID: " + _packageID +
                Environment.NewLine + Environment.NewLine + "Cost: " + CalcCost().ToString("c") +
                Environment.NewLine + "Destination: " + _destinationZip +
                Environment.NewLine + "Origin: " + _originZip +
                Environment.NewLine + "Length: " + _length +
                Environment.NewLine + "Width: " + _width +
                Environment.NewLine + "Height: " + _height +
                Environment.NewLine + "Weight: " + _weight;
        }
    }
}
