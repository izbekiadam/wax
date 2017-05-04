using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using ExpressionKit.Unwrap;

namespace WaxUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static Expression<Func<int, int>> Square = x => x * x;
        static Expression<Func<int, int>> SquSquare = Wax.Unwrap<int, int>(
        x => Square.Expand(Square.Expand(x)));
        [TestMethod]
        public void TestMethod1()
        {
            Expression<Func<int,int>> myexp = x=>  x*x;
            Assert.AreEqual(Square.Body.ToString(), myexp.Body.ToString());
        }
    }
    
}


