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
    
    // [5, 6, 2, 1, 6]
    // 5 + 6            = 11
    // 5 + 2            = 7
    // 5 + 1            = 6
    // 5 + 6            = 11 (dup)
    // 6 + 2            = 8
    // 6 + 1                    
    // 6 + 6
    
    // 5 + 6 + 2
    // 5 + 2 + 1
    // 5 + 1 + 6
    
    // 5 + 6 + 2 + 1
    // 5 + 2 + 1 + 6
    // 5 + 6 + 2 + 1 + 6
    
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

    // take all sums

    // take distinct sums

    // sum those distinct sums into a single number.
    // hashset for uniqueness of the sums of the different permutations
    
    // [ "A", "I", "i", "a"]
    public static int SumEveryCombo(List<int> input)
    {
        var startIndex = 0;
        var numberToJump = 1;
        var sums = new HashSet<int>() { input.Sum() };
        for (int i = 1; i<input.Count; i++)
        {
            int computedIndex = i % input.Count;
            int tmpSum = input[startIndex] + input[computedIndex];
            sums.Add(tmpSum);
            numberToJump++;
            startIndex++;
        }
        return sums.Sum();
    }
}