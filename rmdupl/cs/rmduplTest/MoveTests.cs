using rmduplProj;

namespace rmduplTest
{
	public class MoveTests
	{
		[Fact] public void MoveTest1() 
		{
			int[] array = new int[] { 1, 1, 2 };
			Solution.MoveToEnd(ref array, 1);
			Assert.Equal(new int[] { 1, 2, 1 }, array);
		}
		[Fact] public void MoveTest2()
		{
			int[] array = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
			Solution.MoveToEnd(ref array, 3);
			int[] expected = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 1 };
			Assert.Equal(expected, array);
		}
	}
}
