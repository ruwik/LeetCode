namespace MedianOfTwoSortedArrays {
    public class Solution {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var sampleSize = nums1.Length + nums2.Length;
            var mid =  sampleSize / 2;
            var i = 0;
            var j = 0;
            var merged = new List<int>();

            while (merged.Count <= mid)
            {
                if (i != nums1.Length && j != nums2.Length)
                {
                    merged.Add(nums1[i] < nums2[j] ? nums1[i++] : nums2[j++]);
                }
                else if (i != nums1.Length)
                {
                    merged.Add(nums1[i++]);
                }
                else if (j != nums2.Length)
                {
                    merged.Add(nums2[j++]);
                }
                
            }
            
            if (sampleSize % 2 == 0)
            {
                return (merged[mid] + merged[mid - 1]) / 2.0;
            }

            return merged[mid];
        }
    }
}