namespace Lab10;
public static class SelectionSort1
{
    // sorts the given values (in-place) in ascending order
    public static void SelectionSort(int[] values)
    {
        //iterate over positions, swapping the value at the positon.
        //with the smallest value from that point on.
        for (int i = 0; i < values.Length; i++)
        {
            //find the position smallest value from i ownward
            int positionOfSmallest = i;
            //look for any smaller
            for (int j = i + 1; j < values.Length; j++)
            {
                // is the thing at j smaller than the smallest I've found 
                if (values[j] < values[positionOfSmallest])
                {
                    //remember that j is position of smallest so far 
                    positionOfSmallest = j;
                }
            }
            // swap the thing at the smallest with the thing at i
            int savedAtI = values[i];
            values[i] = values[positionOfSmallest];
            values[positionOfSmallest] = savedAtI;
        }
    }
}
