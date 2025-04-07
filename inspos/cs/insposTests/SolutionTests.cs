using insposProj;

namespace insposTests
{
    public class SolutionTests
    {
        Solution sol = new Solution();
        [Fact] public void Example1Test() => Assert.Equal(2, sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
        [Fact] public void Example2Test() => Assert.Equal(1, sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
        [Fact] public void Example3Test() => Assert.Equal(4, sol.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
    }
}
