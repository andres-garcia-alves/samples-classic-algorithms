public class QuickSort : AlgorithmBase
{
    public void Sort(int[] array)
    {
        base.DisplayMessage("QUICK SORT");
        base.DisplayMessage("********************");

        base.DisplayElements($"Initial values:  ", array);
        this.Sort(array, 0, array.Length - 1, 0);
    }

    private void Sort(int[] array, int left, int right, byte recursionLevel) {

        recursionLevel++;
        base.DisplayElements($"Partition method (R{recursionLevel}.L)", array);
        int index = this.Partition(array, left, right);

        if (left < index - 1) { // sort left half
            base.DisplayElements($"Sort method (R{recursionLevel}.L)", array);
            this.Sort(array, left, index - 1, recursionLevel);
        }

        if (index < right) { // sort right half
            base.DisplayElements($"Sort method (R{recursionLevel}.R)", array);
            this.Sort(array, index, right, recursionLevel);
        }
    }

    private int Partition(int[] array, int left, int right) {
        
        int pivotIndex = (left + right) / 2;  // pivot point
        int pivotValue = array[pivotIndex];
        base.DisplayMessage($"Pivot point \t\t index: {pivotIndex}, value: {pivotValue}");

        while (left <= right) {
            // move indexes to next element that is on the wrong side of the pivot
            while (array[left] < pivotValue) left++;
            while (array[right] > pivotValue) right--;

            // swap
            if (left <= right) {
                this.Swap(array, left, right);
                left++; right--;
            }
        }

        return left;
    }

    private void Swap(int[] array, int left, int right) {
        int aux = array[left];
        array[left] = array[right];
        array[right] = aux;
    }
}