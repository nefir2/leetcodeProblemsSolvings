namespace plusOneProj
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0) return new int[] { 1 };
            LinkedListNode<int> curr = new LinkedList<int>(digits).Last!; //= digitsList[^1] + 1;
            curr.ValueRef++;
            while (curr is { })
            {
                if (curr.Value == 10) {
                    curr.ValueRef = 0;
                    if (curr.Previous is not { }) {
                        curr.List!.AddBefore(curr, 1);
                        break;
                    }
                    curr.Previous.ValueRef++;
                    curr = curr.Previous;
                    continue;
                }
                else break;
            }
            return curr!.List!.ToArray();
        }
    }
}
