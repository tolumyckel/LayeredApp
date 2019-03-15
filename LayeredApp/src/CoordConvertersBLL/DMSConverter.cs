using System;
using System.Collections.Generic;
using System.Text;

namespace CoordConvertersBLL
{
    public class DMSConverter
    {
        public double Dms2Dd(DMSCoord dmsCoord)
        {
            double result;
            result = dmsCoord.deg + (dmsCoord.min/60.0) + (dmsCoord.sec/3600);
            if (dmsCoord.deg > 0 && dmsCoord.min > 0 && dmsCoord.sec > 0)
            {

                switch (dmsCoord.quadrant)
                {
                    case Quadrant.N:
                        result = (dmsCoord.deg <= 90 && dmsCoord.min < 60 && dmsCoord.sec < 60) ? result : 9999;
                        break;
                    case Quadrant.E:
                        result = (dmsCoord.deg <= 180 && dmsCoord.min < 60 && dmsCoord.sec < 60) ? result : 9999;
                        break;
                    case Quadrant.W:
                        result = (dmsCoord.deg <= 180 && dmsCoord.min < 60 && dmsCoord.sec < 60) ? -result : 9999;
                        break;
                    case Quadrant.S:
                        result = (dmsCoord.deg <= 90 && dmsCoord.min < 60 && dmsCoord.sec < 60) ? -result : 9999;
                        break;
                    default:
                        result = 9999;
                        break;
                }
            }

            return result;
        }
    }
}
