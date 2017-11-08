//https://www.hackerrank.com/challenges/grading/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int[] grades){
        for(int i =0; i < grades.Length;i++){
            int grade = grades[i];
            int DifferneceToNextMultiple=(5 - grade%5);
            
            if(grade + DifferneceToNextMultiple <40){
                 grades[i] = grade;
            }
            else{
             
                
                if(DifferneceToNextMultiple < 3)
                    grades[i] = grades[i] + DifferneceToNextMultiple;
                                
                
            }
            
        }
        
        return grades;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
        

    }
}
