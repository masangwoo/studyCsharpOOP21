using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3, b = 5;
            var result = myClass.Plus(a, b);
            


            Assert.AreEqual(0, result);//텍스트 결과
            
        }[TestMethod]
        public void DivideTest()
        {
            MyClass myClass = new MyClass();
            int a = 10, b = 3;
            var result = myClass.Divide(a,b);
            var expected = 3;
            Assert.AreEqual(expected, result);
            
        }
    }
}
