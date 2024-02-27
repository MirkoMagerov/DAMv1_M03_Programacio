using OOP;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car car1 = new Car(0);

            string expected = "Driving";
            StringWriter sw = new StringWriter();
            
            int fuel = 5;

            car1.Refuel(fuel);

            Console.SetOut(sw);
            car1.Drive();

            Assert.AreEqual(expected, sw.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Car car1 = new Car(0);

            string expected = "The car doesn't have fuel.";
            StringWriter sw = new StringWriter();

            Console.SetOut(sw);
            car1.Drive();

            Assert.AreEqual(expected, sw.ToString().Trim());
        }
    }
}