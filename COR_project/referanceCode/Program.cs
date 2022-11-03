﻿using referanceCode;
using System;
class Program
{
    static void Main(string[] args)
    {
        // fun fact, the individual piexes of a chain are called links
        var link01 = new exampleHandler("OBJ_alpha");
        var link02 = new exampleHandler("OBJ_bravo");
        var link03 = new exampleHandler("OBJ_charl");
       

       //assempling the chain.
       link01.SetNext(link02).SetNext(link03);


        Console.WriteLine("eneciating chain of responsablity.");
        Console.WriteLine("chain handle object: OBJ_bravo");


        Console.WriteLine(link01.Handle("OBJ_bravo"));
        Console.WriteLine(link01.Handle("null"));
      
    }
}
