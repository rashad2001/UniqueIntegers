using Unique_Integers;
namespace UniqueTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var uniqueIntProcessor = new UniqueInteger();
            var inputList = new List<int>() { 1, 2, 3, 2, 4, 3, 5 };
            var result = uniqueIntProcessor.GetUniqueElements(inputList);
            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void Test2()
        {
            var uniqueIntProcessor = new UniqueInteger();
            var inputList = new List<int>() { };
            var result = uniqueIntProcessor.GetUniqueElements(inputList);
            Assert.Equal(new List<int>() { }, result);
        }

        [Fact]
        public void Test3()
        {
            var uniqueIntProcessor = new UniqueInteger();
            var inputList = new List<int>() { 1, 2, 3, 4, 5 };
            var result = uniqueIntProcessor.GetUniqueElements(inputList);
            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void Test4()
        {
            var uniqueIntProcessor = new UniqueInteger();
            var inputList = new List<int>() { 1, 2, 3, 4 };
            var result = uniqueIntProcessor.GetUniqueElements(inputList);
            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, result);
        }

        [Fact]
        public void Test5()
        {
            var uniqueIntProcessor = new UniqueInteger();
            var inputList = new List<int>() { 1, 1, 1, 1 };
            var result = uniqueIntProcessor.GetUniqueElements(inputList);
            Assert.Equal(new List<int>() { 1 }, result);
        }

    }
}
}