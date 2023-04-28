namespace SGenLab.EnumGenerators.Tests
{
    [TestClass]
    public class EnumGeneratorTests
    {
        [EnumExtensions] // Our marker attribute
        public enum Colour
        {
            Red = 0,
            Blue = 1,
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}