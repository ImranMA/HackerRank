//https://www.hackerrank.com/challenges/ctci-making-anagrams/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
       string a = Console.ReadLine();
            string b = Console.ReadLine();


            char[] arrA = a.ToCharArray();
            char[] arryB = b.ToCharArray();

            char[] temp = arryB;
            char[] temp1 = arrA;

            if (arrA.Length <= arryB.Length)
            {
                temp = arrA;
                temp1 = arryB;
            }
                

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp1.Contains(temp[i]))
                {
                    
                     int inde = Array.IndexOf(temp1, temp[i]);
                     temp1[inde] = '-';
                     temp[i] = '-';
                }                    
            }

            int Restul =0;

             a = string.Join("", temp).Replace("-", "");
             b = string.Join("", temp1).Replace("-", "");

            
             Restul = b.Length + a.Length;
          Console.WriteLine(Restul);
    }
}
