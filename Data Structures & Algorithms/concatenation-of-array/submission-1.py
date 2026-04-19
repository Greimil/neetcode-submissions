class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        l = 0
        listSize = len(nums)

        while l < listSize:
            nums.append(nums[l])
            l += 1
        
        return nums
