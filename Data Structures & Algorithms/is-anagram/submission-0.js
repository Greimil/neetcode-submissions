class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if(s.length !== t.length) return false

        let arr1 = [...s].sort()
        let arr2 = [...t].sort()

        
        for(let i = 0; i < arr1.length; i++) {
            if(arr1[i] !== arr2[i] ) return false

        }

        return true

    }
}
