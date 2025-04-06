using longcomprefProj;

namespace longcomprefTests
{
    public class SolutionTests
    {
        Solution sol = new Solution();
        [Fact] public void Example1Test() => Assert.Equal("fl", sol.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        [Fact] public void Example2Test() => Assert.Equal("", sol.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        [Fact] public void MyOwnTest1() => Assert.Equal("", sol.LongestCommonPrefix(new string[] { "good", "better", "best" }));
        [Fact] public void MyOwnTest2() => Assert.Equal("long", sol.LongestCommonPrefix(new string[] { "long", "longer", "longest" }));
        [Fact] public void MyOwnTest3() => Assert.Equal("alone", sol.LongestCommonPrefix(new string[] { "alone" }));
    }
}
