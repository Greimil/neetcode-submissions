class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dif = {}
        
        for i in range(len(nums)):
            dif[nums[i]] = i
            
        
        l = 0
        while l < len(nums):
            complemento = target - nums[l]
            if complemento in dif and dif[complemento] != l:
                return [l, dif[complemento]]
            
            l += 1 




