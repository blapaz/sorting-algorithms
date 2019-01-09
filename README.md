# sorting-algorithms
A .net core console app that demonstrates various sorting algorithms.

# Sort.cs
This class contains several functions to call of various sorting algorithms. Each sorting function accepts an int array as input and outputs a sorted version of that array using the chosen algorithm.

```
int[] unsorted = new int[] { 6, 5, 4, 3, 2, 1, 0};
int[] sorted = Sort.Merge(unsorted);
```

| Name | Function | Parameters | Returns | Wikipedia |
| --- | --- | --- | --- | --- |
| Insertion | `Sort.Insertion()` | `int[]` | `int[]` | [Insertion Sorting](https://en.wikipedia.org/wiki/Insertion_sort "Insertion Sorting") |
| Selection | `Sort.Selection()` | `int[]` | `int[]` | [Selection Sorting](https://en.wikipedia.org/wiki/Selection_sort "Selection Sorting") |
| Merge | `Sort.Merge()` | `int[]` | `int[]` | [Merge Sorting](https://en.wikipedia.org/wiki/Merge_sort "Merge Sorting") |
| Bubble | `Sort.Bubble()` | `int[]` | `int[]` | [Bubble Sorting](https://en.wikipedia.org/wiki/Bubble_sort "Bubble Sorting") |
| Comb | `Sort.Comb()` | `int[]` | `int[]` | [Comb Sorting](https://en.wikipedia.org/wiki/Comb_sort "Comb Sorting") |
| Reverse | `Sort.Reverse()` | `int[]` | `int[]` |  |

>While the *Reverse* function is technically a sorting function, but was not meant to really be classified with the other sorting algorithms. This was just added as an extra function to have available.

# Program.cs
This class contains the main function to run. It also includes a simple static function to populate an int array with random numbers.

```
// Creates a new array with 1000 random numbers
// The random numbers will be generated with a seed of 1
// The random numbers will be between 0 and 100
int[] unsorted = NewIntArray(1000, 1, 100);
```

| Parameter | Description |
| --- | --- |
| size | Determines the initial length of the int array |
| seed | Using the same seed will produce the same array of numbers |
| max | The max value the random number function could generate |
