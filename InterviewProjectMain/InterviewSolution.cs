namespace InterviewProject;

public static class InterviewSolution
{
    //array of ints
    //[ 1, 2, 3]

    // output single

    // sum up permutations of diff collections in array

    // every pair, every triplet
    // 1 + 2 = 3
    // 1 + 3 = 4
    // 2 + 3 = 5
    // 1 + 2 + 3 = 6

    // First we add two numbers at a time
    // then we add three, etc.
    
    // Start out at beginning of list, you add the number of items added together after exhausting going through the list with that number of elements
    // 1, 2, 3, 4
    // 1 + 2 = 3
    // 1 + 3 = 4
    // 1 + 4 = 5
    // 2 + 3 = 5 (Duplicate)
    // 2 + 4 = 6
    // 3 + 4 = 7
    // 1 + 2 + 3 = 6 (Duplicate)
    // 1 + 2 + 4 = 7 (Duplicate)
    // 1 + 3 + 4 = 8
    // 2 + 3 + 4 = 9
    // 1 + 2 + 3 + 4 = 10
    // 52 (70 - 5 - 6 - 7)

    // up to every item in array

    // take distinct sums

    // sum those distinct sums into a single number.
    // hashset for uniqueness of the sums of the different permutations
    public static int SumEveryCombo(List<int> input)
    {
        var uniqueSums = new HashSet<int>();
        var numberOfElementsToAdd = 2; // until we get to the whole length of array.
        foreach (int t in input)
        {
            int sum = t;
            int numerator = Factorial(input.Count);
            int denominator = Factorial(numberOfElementsToAdd) * Factorial(input.Count - numberOfElementsToAdd);
            int numberOfCombosForThisIteration = numerator/denominator;
            for (var y = 1; y < numberOfCombosForThisIteration - 1; y++)
            {
                int computedIndex = y % input.Count;
                sum += input[computedIndex];
            }
            uniqueSums.Add(sum);
        }
        return uniqueSums.Sum();
    }

    private static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        
        return n * Factorial(n - 1);
    }
}