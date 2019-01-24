/*
   Qustion 1 - Shide Consulting Test
   
   A palindrome is a word that reads the same backward or forward.
   Write a function that checks if a given word is a palindrome.
   Character case should be ignored.
   
   For example, IsPalindrome("Deleveled") should return true as 
   character case should be ignored,resulting in "deleveled", which
   is a palindrome since it reads the same backward and forward.
   
   Author: Sibusiso Nondoda
   Date: 2019-01-24

 */
using System;

public class Palindrome{
    public static bool IsPalindrome(string word){
	//Check whether a string is a palindrome word or not	
		int minimumIndex = 0;
        int maximumIndex = word.Length - 1;
        while (true){
            if (minimumIndex > maximumIndex){
                return true;
            }
            char x = word[minimumIndex];
            char y = word[maximumIndex];
            if (!(char.ToLower(x) == char.ToLower(y))){
                return false;
            }
            minimumIndex++;
            maximumIndex--;
        }
    }

    
    public static void Main(string[] args){
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}