namespace LongestSubstringWithoutRepeatingCharacters {
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var previous = 0;
            var current = new List<char>();
            foreach (var currentChar in s)
            {
                var i = current.LastIndexOf(currentChar);
                if (i != -1)
                {
                    previous = Math.Max(previous, current.Count);
                    current.RemoveRange(0, i+1);
                }
                current.Add(currentChar);
            }
            return Math.Max(previous, current.Count);
        }
    }
}