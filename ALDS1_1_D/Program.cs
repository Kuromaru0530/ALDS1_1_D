using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var R = new List<int>();
        
        
        for (int i = 0; i < n; i++)
        {
             R.Add(int.Parse(Console.ReadLine())); 
        }
        var maxv = R[1] - R[0];
        var minv = R[0];
        for (int j = 1; j < n; j++)
        {
            
            maxv = Math.Max(maxv, R[j] - minv);
            minv = Math.Min(minv, R[j]);
        }
        Console.WriteLine(maxv);
    }
}