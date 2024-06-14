namespace PalindromeNumber;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        var number = x.ToString();
        var i = 0;
        var j = number.Length - 1;
        while (i <= j)
        {
            if (number[i] != number[j])
            {
                return false;
            }

            i++;
            j--;
        }
        
        return true;
    }
}