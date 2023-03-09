namespace QuickSort
{
    internal class SortEngine
    {
        public static int[] Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                Sort(array, left, pivotIndex - 1);
                Sort(array, pivotIndex + 1, right);
            }

            return array;
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivotValue = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivotValue)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
    }
}
