using Delegates;

namespace TestProject1
{
    public class IdentifierTest
    {
        // tests punt 1
        [Fact]
        public void Test1()
        {
            Assert.Equal("A", Identifier.Clean("A"));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal("à?ç", Identifier.Clean("à?ç"));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal("my___Id", Identifier.Clean("my   Id"));
        }
        // tests punt 2
        [Fact]
        public void Test4()
        {
            Assert.Equal("myCTRLId", Identifier.Clean("my\0Id"));
        }
        [Fact]
        public void Test5()
        {
            Assert.Equal(string.Empty, Identifier.Clean(string.Empty));
        }
        // test punt 3
        [Fact]
        public void Test6()
        {
            Assert.Equal("à?ç", Identifier.Clean("à-?ç"));
        }
        // tests punt 4
        [Fact]
        public void Test7()
        {
            Assert.Equal("MyFinder", Identifier.Clean("My????Finder??"));
        }
        [Fact]
        public void Test8()
        {
            Assert.Equal("MyFinder", Identifier.Clean("1My2Finder3"));
        }
        // tests punt 5
        [Fact]
        public void Test9()
        {
            Assert.Equal("MyOFinder", Identifier.Clean("MyO?????Finder"));
        }
        [Fact]
        public void Test10()
        {
            Assert.Equal("_AbcDCTRL", Identifier.Clean("9 -abc????\0"));
        }
    }
}