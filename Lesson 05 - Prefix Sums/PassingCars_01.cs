///////////////////////////////////////////////////////////////////////////////////
//
// --------------------------------------------------------------------------------
// Report
// --------------------------------------------------------------------------------
// Date         : 11 July 2021
// Total Score  : 50%
// Task Score   : 50%
// Correctness  : 100%
// Performance  : 0%
//	
///////////////////////////////////////////////////////////////////////////////////

using System;

class Solution {
    public int solution(int[] A) {
        int count = 0;
        for (var i = 0; i < A.Length - 1; i++) {
            for (var j = i + 1; j < A.Length; j++) {
                if(A[i] < A[j]) count++;
            }
        }
        return count;
    }
}