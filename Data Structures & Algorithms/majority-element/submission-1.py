class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        dic = defaultdict(int)

        for num in nums:
            dic[num] += 1

        for key, val in dic.items():
            if val >= len(nums) / 2:
                return key

        
