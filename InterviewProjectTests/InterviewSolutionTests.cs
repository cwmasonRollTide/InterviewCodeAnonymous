using InterviewProject;

namespace InterviewProjectTests;

public class InterviewSolutionTests
{
    
    //array of ints
    //[ 1, 2, 3]

    // output single
    
    // sum up permutations of diff collections in array
    //Permutations and combinations are both ways of counting the number of possible outcomes in a set of events, but they differ in how they treat the order of elements in the set.

    //    In permutation, the order of the elements in a set matters.
    // Permutation refers to the number of ways in which a set of objects
    // can be arranged or ordered. The formula for permutation is given as
    // nPr = n!/(n-r)!, where n represents the total number of items in the set,
    // and r represents the number of items chosen.

    //    In combinations, the order of the elements in a set does not matter.
    // Combinations refer to the number of ways in which a subset of objects can
    // be selected from a larger set, without regard to their order. The formula
    // for combinations is given as nCr = n!/(r!(n-r)!), where n represents the
    // total number of items in the set, and r represents the number of items chosen.

    //    To summarize, permutations consider the order of the elements in a set,
    // while combinations do not. Permutations are used when order matters,
    // while combinations are used when order does not matter.

    // every pair, every triplet
    // 1 + 2        = 3
    // 1 + 3        = 4
    // 2 + 3        = 5
    // 1 + 2 + 3    = 6
    //              = 18
    
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

    // take all unique/distinct sums

    // take distinct sums

    // sum those distinct sums into a single number.
    // hashset for uniqueness of the sums of the different permutations

    [Theory]
    [InlineData(new[] { 1, 2, 3}, 18)]
    [InlineData(new[] { 1, 2, 3, 4}, 52)]
    public void EveryComboTest(int[] input, int expected)
    {
        List<int> testInput = input.ToList();
        int answer = InterviewSolution.SumEveryCombo(testInput);
        Assert.Equal(expected, answer);
    }
}
