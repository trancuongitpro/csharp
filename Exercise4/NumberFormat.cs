﻿using System;

namespace Exercise4
{
    internal class ImplicitilyTypedLocal
    {
        public static void Main(string[] args)
        {
            var i = 5;
            var s = "hello";
            var d = 1.0;
//i is an integer
            Console.WriteLine("i*i: " +i * i);
//s is a string
            Console.WriteLine("s in upper case:" + s.ToUpper());
//d is a double
            Console.WriteLine("type of +d:" +d.GetType());
            Console.ReadLine();
            
        }
    }
}