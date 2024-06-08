using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static int powertotal(int X, int N)
    {
        int totalPaths = 0;
        backtracking(1, X, N, 0, ref totalPaths);
        return totalPaths;
    }
    
    public static void backtracking(int index, int X,int N, int sum, ref int totalPaths)
    {
        if(sum > X)
        {
            return;
        }
        
        if(sum == X)
        {
            totalPaths++;
            return;
        }
        
        for(int i = index; i < X ; i++)
        {
            backtracking(i + 1, X, N, sum + (int)(Math.Pow((double)i,(double)N)) , ref totalPaths);
        }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int X = Convert.ToInt32(Console.ReadLine().Trim());

        int N = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.powertotal(X, N);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
