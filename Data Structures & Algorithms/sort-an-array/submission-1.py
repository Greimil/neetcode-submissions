class Solution:
    def sortArray(self, nums: List[int]) -> List[int]:
        return self.mergeSort(nums)

    def mergeSort(self, nums: List[int]) -> List[int]:
        if len(nums) <= 1: 
            return nums

        middle = round(len(nums) / 2)
        left = nums[:middle]
        right = nums[middle:]

        sortedLeft = self.mergeSort(left)
        sortedRight = self.mergeSort(right)

        return self.merge(sortedLeft, sortedRight)
        

    def merge(self, left: List[int], right: List[int]) -> List[int]:
        res = []
        i = 0
        j = 0

        while i < len(left) and j < len(right):
            if left[i] <= right[j]:
                res.append(left[i])
                i += 1
            else:
                res.append(right[j])
                j += 1

        while i < len(left):
            res.append(left[i])
            i += 1

        while j < len(right):
            res.append(right[j])
            j += 1

        return res

