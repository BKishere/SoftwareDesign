//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 3 x 3 array of String
            ITwoDArray<String> name_array = new TwoDArrayGeneric<String>(2, 3);

            name_array.Set(0, 0,"Sarah");
            name_array.Set(0, 1, null);
            name_array.Set(0, 2, "Yixin");
            name_array.Set(1, 0, "Tom");
            name_array.Set(1, 1, null);
            name_array.Set(1, 2, "Faizal");
            
 
            ITwoDIterator<String> iter_major = name_array.CreateRowMajorIterator();
            ITwoDIterator<String> iter_reverse = name_array.CreateReverseIterator();

            Console.WriteLine("Reverse transverse Iteration:");
            while(!iter_reverse.IsDone()){
                
                Console.Write(iter_reverse.Current()+" ");
                iter_reverse.Next();
            }
           
            Console.WriteLine("\n");
            Console.WriteLine("Row major iteration: ");
            while(!iter_major.IsDone()){
                Console.Write(iter_major.Current()+" ");
                iter_major.Next();
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
