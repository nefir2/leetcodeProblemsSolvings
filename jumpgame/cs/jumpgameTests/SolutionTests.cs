using jumpgameProj;

namespace jumpgameTests
{
    public class SolutionTests
    {
        private readonly Solution sol = new Solution();
        [Fact] public void Example1Test() => Assert.True(sol.CanJump(new int[] { 2, 3, 1, 1, 4 }));
        [Fact] public void Example2Test() => Assert.False(sol.CanJump(new int[] { 3, 2, 1, 0, 4 }));
        [Fact] public void MyOwnTest1() => Assert.True(sol.CanJump(new int[] { 1 }));
        [Fact] public void TestCase129() => Assert.True(sol.CanJump(new int[] { 0 })); //why this is true ?
        //[Fact] public void MyOwnTest2() => Assert.False(sol.CanJump(new int[] { 0 })); //why not false?
        [Fact] public void TestCase130() => Assert.True(sol.CanJump(new int[] { 1, 1, 1, 0 }));
        [Fact] public void TestCase158() => Assert.True(sol.CanJump(new int[] { 3, 0, 8, 2, 0, 0, 1 }));
    }
}
