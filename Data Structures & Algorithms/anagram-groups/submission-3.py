class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = {}

        for string in strs:
            key = self.generateKey(string)

            if key not in res:
                res[key] = []
            res[key].append(string)

        return list(res.values())

    def generateKey(self, string: str):
        count = [0] * 26
        for char in string:
            count[ord(char) - ord('a')] += 1
        
        return tuple(count)