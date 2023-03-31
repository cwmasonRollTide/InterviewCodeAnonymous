using InterviewProject;

namespace InterviewProjectTests;

public class InterviewSolutionTests
{
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