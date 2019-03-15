using System;
using System.Collections.Generic;
using System.Text;

namespace CoordConvertersBLL
{
    public enum Quadrant { N, S, E, W }
    public struct DMSCoord
    {
        public int deg;
        public int min;
        public double sec;
        public Quadrant quadrant;
    }
}
