var nums = new int[] { 3,2,1,5,6,4 };
var k = 2;
var result = new Solution().FindKthLargest(nums, k);
Console.WriteLine(result);
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            queue.Enqueue(num, num);
            Console.WriteLine(queue.Peek());
            if (queue.Count <= k) continue;

            Console.WriteLine($"-{queue.Peek()}");
            queue.Dequeue();
        }

        return queue.Peek();
    }

    private void displayQueu(PriorityQueue<int, int> queue)
    {
      
    }
}