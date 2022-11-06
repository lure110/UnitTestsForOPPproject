using Microsoft.VisualStudio.TestTools.UnitTesting;
using csgame_backend.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Xunit;
using TheoryAttribute = Xunit.TheoryAttribute;
using Assert = Xunit.Assert;

namespace csgame_backend.Helpers.Tests
{
    public class UtilsTests
    {
        [Theory]
        [InlineData(0, 0, 3, 3, 1, 0)]
        [InlineData(9, 6, 26, 50, 2.59, -17.29)]
        public void TrajectoryTest(double x, double y, double x1, double y1, double expected_m, double expected_b)
        {
            Utils.Trajectory(x, y, x1, y1, out double m, out double b);
            
            Assert.Equal(Math.Round(expected_b, 2), Math.Round(b, 2));
            Assert.Equal(Math.Round(expected_m, 2), Math.Round(m, 2));
        }

        [Theory]
        [InlineData(0, 0, 6, 8, 10)]
        [InlineData(9, 4, 6, 8, 5)]
        public void GetDistanceTest(double x, double y, double x1, double y1, double expected_d)
        {
            double d = Utils.GetDistance(x, y, x1, y1);
            Assert.Equal(expected_d, d);
        }
    }
}