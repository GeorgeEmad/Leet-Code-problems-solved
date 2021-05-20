class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        conjugate= {}
        for i in range(len(nums)):
            if str(target - nums[i]) in conjugate:
                temp = conjugate[str(target - nums[i])]
                firstindex = temp[1]
                return [firstindex, i]
            conjugate[str(nums[i])] = [target - nums[i], i]




