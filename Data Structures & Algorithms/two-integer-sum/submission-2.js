class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
 twoSum(nums, target) {
  let indexed = nums.map((num, idx) => [num, idx]);
  indexed.sort((a, b) => a[0] - b[0]); // ordenar por valor

  let left = 0;
  let right = indexed.length - 1;

  while (left < right) {
    let sum = indexed[left][0] + indexed[right][0];
    if (sum === target) {
      return [indexed[left][1], indexed[right][1]];
    } else if (sum > target) {
      right--;
    } else {
      left++;
    }
  }
}
}
