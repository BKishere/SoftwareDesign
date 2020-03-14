/**Week 10 Lab Submission - Question 2: NodeLeaf Class**/

using System;

namespace ParseTree{

    public class NodeLeaf: INode{
        
        double value = 0.0;

        public double getValue(){
            return value;
        }

        public NodeLeaf(double value){
            this.value = value;
        }

        public void addChild(INode NodeA, INode NodeB){
            throw new NotImplementedException();
        }
    }
}