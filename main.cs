using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int[] arr = {4,   700, 9, 3, 700, 2, 9, 5};
    List<int> s = new List<int>();
    for(int i = 0; i< arr.Length; i++)
    {
       for(int j = i +1; j<arr.Length ; j++)
       {
            if(arr[i] == arr[j]){
              var index = Array.IndexOf(arr, arr[i]);
              s.Add(index);
             
         }
      
       }
      
    }
    s.Sort();

    
     if(s.Count <=0)
       Console.WriteLine(-1);
     else
     {
        Console.WriteLine(arr[s[0]]);
     }
  }
}


