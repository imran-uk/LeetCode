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
    
    // Definition for singly-linked list. 

    // TODO
    // imran: i really over-complicated this after watching the solution video :)
    // converting the ListNodes to an array and then doing some manipulation of it seems a good approach
    // the other was involving some analysis of the listNodes and spotting a pattern that the middle of the list moves along each time the list grows by two
    //
    // given the head of a singly-linked-list, return the middle node
    // or if two middle nodes then the second of the two
    public ListNode MiddleNode(ListNode head) {
        // get length of the list, given the head
        var nextNode = head.next;
        int listNodeLength = 1;

        while(nextNode is not null)
        {
            listNodeLength++;
            nextNode = nextNode.next;
        }

        Console.WriteLine($"Calculated node length as: {listNodeLength}");

        // i have listNode length here
        bool isOdd = listNodeLength % 2 != 0;
        int middleNode;

        if(isOdd)
        {
            middleNode = (int)Math.Ceiling((decimal)listNodeLength / 2);
        }
        else
        {
            middleNode = (int)Math.Ceiling((decimal)listNodeLength / 2) + 1;
        }

        Console.WriteLine($"Calculated middle node as: {middleNode}");

        // now armed with middleNode above we can loop through the head but only return the list from middleNode onwards
        int nodesToIgnore = middleNode; 
        Console.WriteLine($"Calculated nodes to ignore as: {nodesToIgnore}");

        var nodesToProcess = head;

        while(nodesToProcess is not null && nodesToIgnore != 0)
        {
            nodesToProcess = nodesToProcess.next;
            nodesToIgnore = nodesToIgnore-1;
        }

        return nextNode!;
    }

    public bool CanConstruct(string ransomNote, string magazine) {
        bool canConstruct = false;

        // remove all spaces
        string ransomNoteClean = System.Text.RegularExpressions.Regex.Replace(ransomNote, @"\s+", "");
        string magazineClean = System.Text.RegularExpressions.Regex.Replace(magazine, @"\s+", "");

        if(magazineClean.Contains(ransomNoteClean))
        {
            canConstruct = true;
        }
        else
        {
            List<char> ransomNoteCharsList = ransomNoteClean.ToList<char>();

            Console.WriteLine($"looking at ransom note {ransomNoteClean}");

            foreach(char ransomLetter in ransomNoteCharsList)
            {
                if(magazineClean.Contains(ransomLetter))
                {
                    Console.WriteLine($"found ransom letter {ransomLetter} in {magazineClean}");

                    int index = magazineClean.IndexOf(ransomLetter);
                    magazineClean = magazineClean.Remove(index, 1);

                    Console.WriteLine($"magazine now looks like this {magazineClean}");
                    
                    canConstruct = true;
                }
                else
                {
                    canConstruct = false;
                    break;
                }
            }
        }

        return canConstruct;
    }
}

public class ListNode {
      public int val;
      public ListNode? next;

      public ListNode(int val=0, ListNode? next=null) {
          this.val = val;
          this.next = next;
      }
}