using Unique_Integers;
namespace UniqueTests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            var uniq = new UniqueInt();
            var my_input = new List<int>() { 1, 2, 3, 2, 4, 3, 5 };
            var result = uniq.GetUniqueElements(my_input);
            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, result);

        }

        [Fact]
        public void Test2()
        {
            var uniq = new UniqueInt();
            var my_input = new List<int>() { }; 
            var result = uniq.GetUniqueElements(my_input);
            Assert.Equal(new List<int>() { }, result);

        }

        [Fact]
        public void Test3()
        {
            var uniq = new UniqueInt();
            var my_input =  new List<int>() { 1, 2, 3, 4, 5 };            
            var result = uniq.GetUniqueElements(my_input);
            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, result);

        }

        [Fact]
        public void Test4() // I make wrong assert intentionally
        {
            var uniq = new UniqueInt();
            var my_input = new List<int>() { 1, 2, 3, 4 };
            var result = uniq.GetUniqueElements(my_input);
            Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, result);

        }

        [Fact]
        public void Test5()
        {
            var uniq = new UniqueInt();
            var my_input = new List<int>() { 1, 1, 1, 1};
            var result = uniq.GetUniqueElements(my_input);
            Assert.Equal(new List<int>() {1}, result);

        }
    }
}