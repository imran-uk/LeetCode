namespace LeetCodeSolution;

public class LeetCode {
    public int MaximumWealth(int[][] accounts) {
        int maxCustomerWealthSoFar = 0;

        foreach(int[] customerAccountBalances in accounts)
        {
            int currentCustomerWealth = 0;

            foreach(int balance in customerAccountBalances)
            {
                currentCustomerWealth += balance;
            }

            // if(customerWealth > maxCustomerWealth)
            // {
            //     maxCustomerWealth = customerWealth;
            // }

            // neater way
            maxCustomerWealthSoFar = Math.Max(currentCustomerWealth, maxCustomerWealthSoFar);

        }

        return maxCustomerWealthSoFar;
    }

    public List<string> FizzBuzz(int n) {
        List<string> output = new List<string>();

        foreach(int i in Enumerable.Range(1, n))
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                output.Add("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                output.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                output.Add("Buzz");
            }
            else
            {
                output.Add(i.ToString());
            }

            /*
            switch(i)
            {
                case i % 3:
                    // add to output
                    break;
                default:
                    // add the i to output as string
                    break;
            }
            */
        }

        return output;
    }


    public int NumberOfSteps(int num) {

        int stepCount = 0;

        while(num != 0)
        {
            bool isEven = num % 2 == 0;
            
            if(isEven)
            {
                num /= 2;
            }
            else
            {
                num--;
            }

            stepCount++;
        }

        return stepCount;
    }
}