public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        bool pass = true;
        int i = digits.Length - 1;
        while (pass)
        {
            if (i == -1)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                return result;
            }
            pass = false;
            digits[i]++;
            if (digits[i] > 9)
            {
                digits[i] = 0; pass = true; i--;
            }
        }
        return digits;
    }
}