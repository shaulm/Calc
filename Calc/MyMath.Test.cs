using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calc
{
    class MyMathTest
    {
        [TestFixture]

        class Test_Add
        {
            [TestCase]

            public void TestAddPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(30, math.Add(10, 20));

            }

            [TestCase]
            public void TestAddNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(45, math.Add(10, 20));

            }
            [TestCase]
            public void TestAddGreater()
                {
                    MyMath math = new MyMath();
                    Assert.Greater(45, math.Add(10, 20));
                }
         
 
        }


    }
}

