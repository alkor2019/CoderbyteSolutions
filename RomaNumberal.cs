using System;
using System.Collections.Generic;

public class  RomaNumberal
{
      public static string RomaNumber(string str)
      {
         Dictionary<string, int> romans = new Dictionary<string, int>()
    {
      {"M", 1000},
      {"D", 500},
      {"C", 100},
      {"L", 50},
      {"X", 10},
      {"V", 5},
      {"I", 1}
    };
    
     
    int total =0;
    
    for(int i= 0; i<str.Length; i++)
    {  
        
       if(romans.ContainsKey(str[i].ToString()))
       {
          int n = 0;
          romans.TryGetValue(str[i].ToString(), out n);
          total +=n;
       }
    }
    string result ="";
   
  foreach(KeyValuePair<string, int>  item in romans) {
            if (total <= 0) break;
            while (total >= item.Value) {
                result += item.Key;
                total -= item.Value;
            }
        }

  return result;
}
}