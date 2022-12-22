// TODO
// create test class for this
namespace LeetCode;

public class LeetCodeSolution {
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

    public IList<string> FizzBuzz(int n) {
        // 

        // 

        // 
    }
}