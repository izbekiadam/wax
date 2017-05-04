using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using ExpressionKit.Unwrap;

namespace WaxUnitTest
{
    [TestClass]
    public class TestConstant
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestConstantOutsideOfExpression()
        {
            var nie = Wax.Constant<int>(1);
        }
    }
}
