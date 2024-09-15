using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ", RunningSum_1480([1, 2, 3, 4])));

        Console.WriteLine(MaximumWealth_1672([[1, 5], [7, 3], [3, 5]]));

        Console.WriteLine(string.Join(", ", FizzBuzz_412(15)));
    }

    public static int[] RunningSum_1480(int[] nums)
    {
        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var aux = 0;

            for (int j = i; j >= 0; j--)
            {
                aux += nums[j];
            }

            result[i] = aux;
        }

        return result;
    }

    public static int MaximumWealth_1672(int[][] accounts)
    {
        int richestIndex = -1;
        int richestWealth = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > richestWealth)
            {
                richestIndex = i;
                richestWealth = sum;
            }
        }

        return richestWealth;
    }

    public static IList<string> FizzBuzz_412(int n)
    {
        if (n < 0)
        {
            return [];
        }

        string[] answer = new string[n];

        for (int i = 0; i < n; i++)
        {
            int actual = i + 1;

            if (actual % 3 == 0 && actual % 5 == 0)
            {
                answer[i] = "FizzBuzz";
            } 
            else if (actual % 3 == 0)
            {
                answer[i] = "Fizz";
            }
            else if (actual % 5 == 0)
            {
                answer[i] = "Buzz";
            }
            else
            {
                answer[i] = actual.ToString();
            }
        }

        return answer;
    }
}