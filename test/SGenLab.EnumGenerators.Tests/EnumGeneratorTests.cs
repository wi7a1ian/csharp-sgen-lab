namespace SGenLab.EnumGenerators.Tests
{
    [TestClass]
    public class EnumGeneratorTests
    {
        [EnumExtensions]
        public enum Colour
        {
            Red = 0,
            Blue = 1,
        }

        [TestMethod]
        public void GeneratedExtensionMethodWorks()
        {
            var sut = Colour.Blue;
            Assert.AreEqual(sut.ToStringFast(), "Blue");
            Assert.AreEqual(Colour.Red.ToStringFast(), "Red");
        }
    }
}