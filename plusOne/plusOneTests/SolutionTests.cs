using plusOneProj;

namespace plusOneTests
{
    public class UnitTest1
    {
        private readonly Solution sol = new Solution();
        [Fact] public void Example1Test() => Assert.Equal(new int[] { 1, 2, 4 }, sol.PlusOne(new int[] { 1, 2, 3 }));
        [Fact] public void Example2Test() => Assert.Equal(new int[] { 4, 3, 2, 2 }, sol.PlusOne(new int[] { 4, 3, 2, 1 }));
        [Fact] public void Example3Test() => Assert.Equal(new int[] { 1, 0 }, sol.PlusOne(new int[] { 9 }));
        [Fact] public void MyOwnTest1() => Assert.Equal(new int[] { 1, 0, 0, 0 }, sol.PlusOne(new int[] { 9, 9, 9 }));
        [Fact] public void MyOwnTest2() => Assert.Equal(new int[] { 1, 1 }, sol.PlusOne(new int[] { 1, 0 }));
    }
}
