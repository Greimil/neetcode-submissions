class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t) : 
            return False
        
        

        return self.mapStrings(s) == self.mapStrings(t)

        




    def mapStrings(self, s: str): 
        frec_counter = {}

        for char in s:
            if not frec_counter.get(char, 0):
                frec_counter[char] = 1
            else:
                frec_counter[char] += 1 
        
        return frec_counter



            