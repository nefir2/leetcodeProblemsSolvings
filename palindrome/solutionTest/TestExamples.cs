using lc;

namespace solutionTest
{
    public class TestExamples
    {
        [Fact] public void Example1Test() => Assert.True(Solution.IsPalindrome(121));
        [Fact] public void Example2Test() => Assert.False(Solution.IsPalindrome(-121));
        [Fact] public void Example3Test() => Assert.False(Solution.IsPalindrome(10));
    }
}
