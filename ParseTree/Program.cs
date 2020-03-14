/**Week 10 Lab Submission - Question 2: Main Program(Client)**/

using System;

namespace ParseTree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Declare and initialise object
            INode main_root = new NodeComposite("*");
            
            INode left_root = new NodeLeaf(2);
            
            INode right_root = new NodeComposite("+");
            INode left_of_right_root= new NodeLeaf(10);
            INode right_of_right_root = new NodeLeaf(-5);

            //Compute both child up at the right_root (left_of_right_root + right_of_right_root)
            right_root.addChild(left_of_right_root, right_of_right_root);

            //Compute both child up for both left_root and right_root to form the result in main_root
            main_root.addChild(left_root, right_root);

            //Display the result 
            Console.WriteLine("Calculation Result: "+main_root.getValue().ToString());
        }
    }
}
