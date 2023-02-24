namespace QuickSort
{
    internal class SortEngine
    {
        public static void Sort(int[] array, int l, int arrayLength)
        {

            int i = l;
            int j = arrayLength - 1;
            int pivot = array[(l + arrayLength - 1) / 2];
            while (i < j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int zmienna = array[i];
                    array[i++] = array[j];
                    array[j--] = zmienna;
                }
            }
            if (l < j) Sort(array, l, j);
            if (i < arrayLength - 1) Sort(array, i, arrayLength - 1);

        }
    }
}
