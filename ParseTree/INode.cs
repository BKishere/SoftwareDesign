/**Week 10 Lab Submission - Question 2: INode Interface**/

using System;

namespace ParseTree
{
public interface INode
{
    public double getValue();
    public void addChild(INode nodeA, INode nodeB);
}
}