using System;
using System.Linq;
using System.Collections.Generic;

namespace rmduplProj
{
	public static class Solution
	{
		public static int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0) return 0;
			if (nums.Length == 1) return 1;

			int k = nums.Length;
			int indexOfLast = nums.Length - 1;
			for (int i = 0; i < indexOfLast; i++)
			{
				if (nums[i] == nums[i + 1]) 
				{
					MoveToEnd(ref nums, i);
					i--;
					k--;
					indexOfLast--;
				}
			}
			return k;
		}
		public static void MoveToEnd<T>(ref T[] array, int index)
		{
			if (index > array.Length - 1 || index < 0) throw new IndexOutOfRangeException();
			if (array.Length == 0) throw new ArgumentException("array length is zero.", nameof(array));
            ArgumentNullException.ThrowIfNull(array, nameof(array));

            T indexedValue = array[index];
			for (int i = index; i < array.Length - 1; i++) array[i] = array[i + 1];
			array[^1] = indexedValue;
		}
		public static int[] Unworking(int[] nums)
		{
			LinkedList<int> numsList = new LinkedList<int>(nums);
			LinkedListNode<int>? curr = numsList.First;
			while (curr is { Value: { } current })
			{
				if (curr.Next is { Value: { } next } && current == next) numsList.Remove(curr.Next);
				else curr = curr.Next;
			}
			return numsList.ToArray();
		}
	}
}