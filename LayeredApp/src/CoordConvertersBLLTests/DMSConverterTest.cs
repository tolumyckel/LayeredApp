using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoordConvertersBLL;

namespace CoordConvertersBLLTests
{
    [TestClass]
    public class DMSConverterTest
    {
        [TestMethod]
        public void Dms2Dd_ValidNcoord_Calculated()
        {
            //Arrange
            DMSConverter dms = new DMSConverter();
            double expected = 56.51;

            //Act
            DMSCoord coord = new DMSCoord
            {
                deg = 56,
                min = 30,
                sec = 36,
                quadrant = Quadrant.N
            };
            double actual = dms.Dms2Dd(coord);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dms2Dd_InvalidNcoord_Returns9999()
        {
            //Arrange
            DMSConverter dms = new DMSConverter();
            double expected = 9999;

            //Act
            DMSCoord coord = new DMSCoord
            {
                deg = 56,
                min = 30,
                sec = 36,
                quadrant = Quadrant.N
            };
            double actual = dms.Dms2Dd(coord);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
