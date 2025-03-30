using rmduplProj;

namespace rmduplTest
{
	public class SolutionTests
	{
		[Fact] public void Example1WithListTest() => Assert.Equal(new int[] { 1, 2 }, Solution.Unworking(new int[] { 1, 1, 2 }));
		[Fact] public void Example2WithListTest() => Assert.Equal(new int[] { 0, 1, 2, 3, 4 }, Solution.Unworking(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
		[Fact] public void Example1Test() => Assert.Equal(2, Solution.RemoveDuplicates(new int[] { 1, 1, 2 }));
		[Fact] public void Example2Test() => Assert.Equal(5, Solution.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
	}
}
