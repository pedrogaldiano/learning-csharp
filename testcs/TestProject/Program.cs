using System;
using System.Collections.Generic;

namespace testcs
{
        class Account
    {
        public string Name = "keke";
    } ;
    
    class StructsAndObjectsDemo
    {
    public static void Main ()
    {
        Account RobsAccount ;
        RobsAccount = new Account();
        // RobsAccount.Name = "Rob";
        Console.WriteLine (RobsAccount.Name );
    }
}
    // class LocalExample
    // {
    //     static void Main()
    //     {
    //         string a = " 000";
    //         string b = "abcd";
    //         char c = b[0];
    //         a[0] = c;
    //         Console.WriteLine(a);
    //         // string s = "codeleet";
    //         // int[] indices = new int[] {4,5,6,7,0,2,1,3};
            
    //         // string r = s;
    //         // for (int i = 0; i < indices.Length; i++)
    //         // {
    //         //     r[i] = s[indices[i]];
    //         // }

    //         // Console.WriteLine(r);
    //     }
    // }
}

            // string j = "ABCDEFG";

            // for (int i = 0; i < j.Length; i++)
            // {
            //     Console.WriteLine(j[i]);
            // }
            
            // bool x = j.Contains(j[0]);

            // Console.WriteLine(x);
            // string[] abc = new string[] {
            //     "A0", "B1", "C2", "D3", "E4", "F5", 
            //      "--G6", "--H7", "--I8", "--J9", "--K10", "--L11"};

          
            // int[,] a = new int[5,3] {{1,2,3}, {4,5,6}, {7,8,9}, {10,11,12}, {13,14,15}};

            // for (int i = 0; i < a.Length; i++)
            // {
            //     foreach (var j in a[0])
            //     {
            //         Console.Write(j +  "  ");
            //     }
            //     Console.WriteLine();
            // }
