public class BinarySearch : AlgorithmBase
{
    public BinarySearch() {}

    public int Search(int[] array, int value) {
        
        int start = 0;
        int mid = 0;
        int end = array.Length - 1;
        
        base.DisplayMessage("BINARY SEARCH");
        base.DisplayMessage("********************");

        base.DisplayElements($"Search method (value {value})", array);

        while (start <= end) {
            mid = (start + end) / 2;
            base.DisplayMessage($"- range indexes \t start {start}, mid {mid}, end {end}");

            if (array[mid] < value) { // value at right of 'mid'
                start = mid + 1;
            } else if (array[mid] > value) { // value at left of 'mid'
                end = mid - 1;
            } else { // found
                base.DisplayMessage($"Found value {value} at index {mid}.");
                return mid;
            }
        }

        return -1;
    }
}