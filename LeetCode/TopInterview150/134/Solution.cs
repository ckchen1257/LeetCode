namespace LeetCode.TopInterview150._134;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int nonZeroIndex = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            gas[i] -= cost[i];
            if (gas[i] != 0)
            {
                nonZeroIndex = i;
            }
        }

        (int startIndex, int endIndex) = gas[nonZeroIndex] > 0 ?
            (nonZeroIndex, (nonZeroIndex + 1) % gas.Length) :
            ((nonZeroIndex + gas.Length - 1) % gas.Length, nonZeroIndex);

        int accumulatedGas = gas[startIndex] + gas[endIndex];
        while (startIndex != endIndex)
        {
            if (accumulatedGas >= 0)
            {
                endIndex = endIndex == gas.Length - 1 ? 0 : endIndex + 1;
                accumulatedGas += gas[endIndex];
            }
            else
            {
                startIndex = startIndex == 0 ? gas.Length - 1 : startIndex - 1;
                accumulatedGas += gas[startIndex];
            }
        }
        return accumulatedGas < 0 ? -1 : startIndex;
    }

    public int CanCompleteCircuit_v1(int[] gas, int[] cost)
    {
        for (int i = 0; i < gas.Length; i++)
        {
            gas[i] -= cost[i];
        }

        (int Start, int End) index = (0, 0);
        for (int i = 0; i < gas.Length; i++)
        {
            if (gas[i] == 0)
            {
                continue;
            }
            bool isPositive = gas[i] > 0;
            index = isPositive ?
                (i, (i + 1) % gas.Length) :
                ((i + gas.Length - 1) % gas.Length, i);
            break;
        }

        int accumulatedGas = gas[index.Start] + gas[index.End];
        while (index.Start != index.End)
        {
            if (accumulatedGas >= 0)
            {
                index.End = index.End == gas.Length - 1 ? 0 : index.End + 1;
                accumulatedGas += gas[index.End];
            }
            else
            {
                index.Start = index.Start == 0 ? gas.Length - 1 : index.Start - 1;
                accumulatedGas += gas[index.Start];
            }
        }
        return accumulatedGas < 0 ? -1 : index.Start;
    }

    public int CanCompleteCircuit_TimeLimitExceeded(int[] gas, int[] cost)
    {
        for (int i = 0; i < cost.Length; i++)
        {
            int accumulatedGas = 0;
            int accumulatedCost = 0;

            for (int j = 0; j < cost.Length; j++)
            {
                int index = (i + j) % cost.Length;
                accumulatedGas += gas[index];
                accumulatedCost += cost[index];

                if (accumulatedGas < accumulatedCost)
                {
                    break;
                }
                if (j == cost.Length - 1)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}
