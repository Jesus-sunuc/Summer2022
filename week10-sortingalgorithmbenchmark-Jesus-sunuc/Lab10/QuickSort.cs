namespace Lab10;
public static class QuickSortClass
{
    public static void QuickSort(int[] values, int left, int right) //divides it into partitions
    {
        if (left < right)
        {
            int pivot = values[(left + right) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (values[i] < pivot)
                {
                    i++;
                }
                while (values[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int savedAtI = values[i];
                    values[i] = values[j];
                    values[j] = savedAtI;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                QuickSort(values, left, j);
            }
            if (i < right)
            {
                QuickSort(values, i, right);
            }
        }
    }
}