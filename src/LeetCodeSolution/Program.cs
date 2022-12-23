// See https://aka.ms/new-console-template for more information
using System;
using LeetCodeSolution;

var sol = new LeetCode();
int[][] customerAccounts = new int[][] { new int[] {1, 2, 3}, new int[] {6, 3, 2} };
int maxWealth = sol.MaximumWealth(customerAccounts);
Console.WriteLine("Maximum customer wealth is: {0}", maxWealth);
