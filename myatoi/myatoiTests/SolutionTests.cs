using myatoiProj;

namespace myatoiTests
{
	public class SolutionTests
	{
		private Solution sol = new Solution();
		[Fact] public void Example1Test() => Assert.Equal(42, sol.MyAtoi("42"));
		[Fact] public void Example2Test() => Assert.Equal(-42, sol.MyAtoi("   -042"));
		[Fact] public void Example3Test() => Assert.Equal(1337, sol.MyAtoi("1337c0d3"));
		[Fact] public void Example4Test() => Assert.Equal(0, sol.MyAtoi("0-1"));
		[Fact] public void Example5Test() => Assert.Equal(0, sol.MyAtoi("words and 987"));
		[Fact] public void TestCase9() => Assert.Equal(0, sol.MyAtoi("+-12"));
		[Fact] public void TestCase10() => Assert.Equal(0, sol.MyAtoi("-+12"));
		[Fact] public void TestCase14() => Assert.Equal(0, sol.MyAtoi("-"));
		[Fact] public void TestCase39() => Assert.Equal(-12, sol.MyAtoi("  -0012a42"));
		[Fact] public void TestCase42() => Assert.Equal(0, sol.MyAtoi("  -0k4"));
		[Fact] public void MyOwnTest1() => Assert.Equal(0, sol.MyAtoi("     "));
		[Fact] public void MyOwnTest2() => Assert.Equal(0, sol.MyAtoi("+"));
		[Fact] public void MyOwnTest3() => Assert.Equal(2, sol.MyAtoi("+2-2"));
		[Fact] public void MyOwnTest4() => Assert.Equal(2, sol.MyAtoi("+2-2"));
	}
}
