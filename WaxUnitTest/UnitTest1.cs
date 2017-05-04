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
        static Expression<Func<int, int>> Cube = Wax.Unwrap<int, int>(
            x => SquSquare.Expand(x) / x);

        [TestMethod]
        public void SquSquareTest()
        {
            Expression<Func<int,int>> myexp = x=>  (x*x)*(x*x);
            Assert.AreEqual(SquSquare.Body.ToString(), myexp.Body.ToString());
        }

        [TestMethod]
        public void CubeTest()
        {
            Expression<Func<int, int>> myexp = x => (x * x) * (x * x) / x;
            Assert.AreEqual(Cube.Body.ToString(), myexp.Body.ToString());
        }
    }
    
}


