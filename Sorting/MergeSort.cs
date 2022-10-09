public class MergeSort : AlgorithmBase
{
    public MergeSort() {}

    public void Sort(int[] array)
    {
        int[] helper = new int[array.Length];

        base.DisplayMessage("MERGE SORT");
        base.DisplayMessage("********************");

        base.DisplayElements($"Initial values:  ", array);
        this.Sort(array, helper, 0, array.Length - 1, 0);
    }

    private void Sort(int[] array, int[] helper, int low, int high, byte recursionLevel) {

        recursionLevel++;

        if (low < high) { // base case
            int middle = (low + high) / 2;
            
            // recursion
            base.DisplayElements($"Sort method (R{recursionLevel}.L)", array, helper);
            this.Sort(array, helper, low, middle, recursionLevel);

            base.DisplayElements($"Sort method (R{recursionLevel}.R)", array, helper);
            this.Sort(array, helper, middle + 1, high, recursionLevel);

            // merge operation of both branches
            base.DisplayElements($"Merge method (R{recursionLevel})", array, helper);
            this.Merge(array, helper, low, middle, high);
        }
    }

    private void Merge(int[] array, int[] helper, int low, int middle, int high) {

        // copy array to helper
        for (int i = low; i <= high; i++)
            helper[i] = array[i];

        int left = low;
        int right = middle + 1;
        int current = low;

        while (left <= middle && right <= high) {
            if (helper[left] <= helper[right]) {
                array[current] = helper[left];
                left++;
            } else { // right elem smaller than left elem
                array[current] = helper[right];
                right++;
            }
            current++;
        }

        int remaining = middle - left;
        for (int i=0; i <= remaining; i++)
            array[current + i] = helper[left + i];
        
        base.DisplayElements($"Merge method END", array, helper);
    }
}