public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int p;

        while (right > left)
        {
            p = (right + left) / 2;
            if (nums[p] == target) { return p; }
            if (nums[p] > target) right = p - 1;
            else left = p + 1;
        }

        if (right == -1 || left == nums.Length) return -1;
        if (nums[right] == target) return left;
        else return -1;
    }

    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row;
        int left = 0, right = matrix.Length - 1;
        int p;

        while (right > left)
        {
            p = (right + left) / 2;
            if (matrix[p][0] == target) { left = right = p; }
            if (matrix[p][0] > target) right = p - 1;
            else left = p + 1;
        }

        if (right == -1) return false;
        if (left == right)
        {
            if (matrix[left][0] > target) row = left - 1;
            else row = left;
        }
        else row = left - 1;

        if (row == -1) return false;

        int index = Search(matrix[row], target);
        if (index == -1) return false;
        else return true;

    }
}