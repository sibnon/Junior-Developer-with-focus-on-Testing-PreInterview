using System;
using System.Collections.Generic;
/*
    
	Qustion 2 - Shide Consulting Test

    Write a function that, given a list and a target sum, returns zero-based indices of any two distinct elements
	whose sum is equal to the target sum. If there are no such elements, the function should return null.
    
	For example, FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12) should return any of the following tuples of indices:
    1, 4 (3 + 9 = 12)
    2, 3 (5 + 7 = 12)
    3, 2 (7 + 5 = 12)
    4, 1 (9 + 3 = 12)
	
	Author: Sibusiso Nondoda
    Date: 2019-01-24

*/

public class TwoSum{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum){
	//return zero-based indices of any two distinct elements whose sum is equal to the target sum, otherwise return null
		
    HashSet<int> hashset = new HashSet<int>();
    for (int i = 0; i < list.Count; i++){
        var required = sum - list[i];
        if (hashset.Contains(required)){
            return Tuple.Create(list.IndexOf(required), i);
        }
        hashset.Add(list[i]);                
    }
    return null;
}
	
public static void Main(string[] args){
     Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
     Console.WriteLine(indices.Item1 + " " + indices.Item2);
    }
}