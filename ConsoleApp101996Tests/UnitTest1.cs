
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
        [TestCase(4,5,45)]
      public void DrobnoeDelenieTest(int a,int b,double expected)//2
        {
            double actual = Variable.DrobnoeDelenie(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,3,1)]
        public void EquationTest(int a,int b,int c,double expected)
        {
            double actual = Variable.Equation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(6,2,8,4,-4)]
        public void LineEquationTest(int x1,int y1,int x2,int y2,double expected)
        {
            double actual = Variable.LineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }


    }


}