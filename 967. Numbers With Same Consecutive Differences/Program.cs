public class Solution
{
    public int[] NumsSameConsecDiff(int n, int k)
    {
        int comp = (int)Math.Pow(10, n - 1);
        Queue<int> numbers = new Queue<int>();
        List<int> result = new List<int>();

        for (int i = 1; i < 10; i++) numbers.Enqueue(i);

        while (numbers.Count != 0)
        {
            int num = numbers.Dequeue();
            if (num >= comp) { result.Add(num); continue; }
            int r = num % 10;
            if (r + k < 10) numbers.Enqueue(num * 10 + r + k);
            if (k != 0 && r - k >= 0) numbers.Enqueue(num * 10 + r - k);
        }

        return result.ToArray();
    }
}
