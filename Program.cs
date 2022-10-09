
// Available Algorithms:
MergeSort();
// QuickSort();
// BinarySearch();


static void MergeSort() {
    int[] array = new int[] {6, 7, 2, 1, 6, 4, 9, 0};

    MergeSort mergeSort = new MergeSort();
    mergeSort.Sort(array);
}

static void QuickSort() {
    int[] array = new int[] {6, 7, 2, 1, 6, 4, 9, 0};

    QuickSort quickSort = new QuickSort();
    quickSort.Sort(array);
}

static void BinarySearch() {
    int[] array = new int[] {0, 1, 2, 4, 6, 6, 7, 9};

    BinarySearch binarySearch = new BinarySearch();
    binarySearch.Search(array, 7);
}
