﻿using System;

namespace Esercitazone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insersci una frase");
            Console.ReadLine(); 
   
            String unicodeString =
                "This Unicode string has 2 characters outside the "   +
                "ASCII range: \n" +
                "Pi (\u03A0), and Sigma (\u03A3).";
            Console.WriteLine("Original string:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodeString);
            Console.WriteLine();
        }
    }
}
