﻿using System.CodeDom.Compiler;
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

//Task
//Given an integer,n, print its first 10 multiples. Each multiple n x i (where 1<i<10) should be printed on a new line in the form: n x i = result.

//Output Format
//Print 10 lines i of output; each line  (where 1<i<10) contains the result of n x i in the form:
//n x i = result.

class Program
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sonuc;
        string x = Console.ReadLine();
        
        for(int i =1; i<=10; i++)
        {   
            int ilkDeger = i;
            int ikinciDeger = n;
            sonuc = n*i;
            Console.WriteLine(ikinciDeger+ " "+ "x"+ " " +ilkDeger+" "+ "="+" "+sonuc);
        }
    }
}