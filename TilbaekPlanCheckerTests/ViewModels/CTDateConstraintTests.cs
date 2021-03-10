using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void IsCTTooOldTest_FAILSCORECTLY()
        {
            //Arrange
            var daysOld = 61;

            //Act
            var constraint = new CTDateConstraint();
            var actual = constraint.IsCTTooOld(daysOld).ResultType;

            //Assert
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsCTTooOldTest_PASSESCORECTLY()
        {
            //Arrange
            var daysOld = 59;

            //Act
            var constraint = new CTDateConstraint();
            var actual = constraint.IsCTTooOld(daysOld).ResultType;

            //Assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }
    }
}