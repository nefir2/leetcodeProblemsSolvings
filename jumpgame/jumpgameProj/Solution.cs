using System.Collections.Generic;

namespace jumpgameProj
{
	public class Solution
	{
		public bool CanJump(int[] nums) {
			// if (nums.Length == 1) return true;
			// for (int i = 0; i < nums.Length - 1; i++) {
			// 	int maxjump = nums[i] + i;
			// 	if (maxjump >= nums.Length - 1) return true;
			// 	if (maxjump < nums.Length && nums[maxjump] == 0) {
			// 		for (int j = maxjump; j >= i; j--) {
			// 			if (nums[j] == 0) continue;
			// 			else {
			// 				i = j;
			// 				break;
			// 			}
			// 		}
			// 	}
			// 	//if (nums[i] == 0) return false;
			// }
			// return false;

			return linkedjump(nums);
		}
		public bool linkedjump(int[] nums) {
			LinkedListNode<int> curr = new LinkedList<int>(nums).Last!;
			while (curr is { }) {
				
			}
		}
	}
}
