// 05.
// You are given an array of strings. Write a method that sorts the 
// array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;

class SortsArrayByTheLengthOfMembers
{
    static void Main()
    {
        string[] aaa = { "sfgr", "fgt", "uiyt", "wde", "hj", "dfg", "hjkl" };
        Array.Sort(aaa);
        Array.Sort(aaa, (x, y) => x.Length.CompareTo(y.Length));
        foreach (var item in aaa)
        {
            Console.WriteLine(item);
        }
    }
}