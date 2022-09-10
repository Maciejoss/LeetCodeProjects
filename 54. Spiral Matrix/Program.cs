public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int rows = 0, rowf = matrix.GetLength(0);
        int cols = 0, colf = matrix[0].GetLength(0);
        int[] lista = new int[rowf * colf];
        int index = 0;

        while (true)
        {
            int i = rows, j = cols;
            for (; j < colf; j++)
            {
                lista[index++] = matrix[i][j];
            }
            i++; j--;
            if (i == rowf) break;
            for (; i < rowf; i++)
            {
                lista[index++] = matrix[i][j];
            }
            j--; i--;
            if (j < rows) break;
            for (; j >= rows; j--)
            {
                lista[index++] = matrix[i][j];
            }
            i--; j++;
            for (; i > cols; i--)
            {
                lista[index++] = matrix[i][j];
            }
            rows++; cols++; rowf--; colf--;
            if (rows >= rowf || cols >= colf) break;
        }
        return lista;
    }
}