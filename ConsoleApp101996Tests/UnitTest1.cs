using.Unit.Framework;
using ConsoleApp101996;

namespace ConsoleApp101996Tests
{
    /*
      {  public class VariableTests
          [TestCase()]
          public void DeleniesOstatkomTests(int a,int b,int expected)

          {
              int actual = Variable.DeleniesOstatkom(a, b);
              Assert.AreEqual(expected, actual);  
          }
      }*/
    public class VariableTests
    {
        [TestCase()]
        public void DrobnoyeDeleniyeTests(int a, int b, int expected)

        {
            int actual = Veraible.DrobnoyeDeleniye(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}