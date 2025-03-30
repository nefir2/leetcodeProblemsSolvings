using lc;

namespace solutionTest
{
    public class TestEasyWay
    {
        [Fact] public void Example1Test() => Assert.True(Solution.EasyWay(121));
        [Fact] public void Example2Test() => Assert.False(Solution.EasyWay(-121));
        [Fact] public void Example3Test() => Assert.False(Solution.EasyWay(10));
        [Fact] public void FirstSomeTest() => Assert.True(Solution.EasyWay(12121));
        [Fact] public void SecondSomeTest() => Assert.True(Solution.EasyWay(4010104));
        [Fact] public void ThirdSomeTest() => Assert.True(Solution.EasyWay(938839));
        [Fact] public void FourthSomeTest() => Assert.True(Solution.EasyWay(123321));
        [Fact] public void FifthSomeTest() => Assert.False(Solution.EasyWay(123123123));
        [Fact] public void SixthSomeTest() => Assert.False(Solution.EasyWay(-938839));
    }
}
