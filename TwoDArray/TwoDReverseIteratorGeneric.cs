using System;

namespace TwoDArray{
    class TwoDReverseIteratorGeneric<T>:ITwoDIterator<T>{

        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;
        private bool twodreverse = false;

        //constructor 
    
        public TwoDReverseIteratorGeneric(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        
        // move to the next element of the iteration
        public void Next()
        {
            if(twodreverse){
                j--;

                if(j<0){
                    j=0;
                    i++;
                    twodreverse=false;
                }
            }
            else{
            j++;
            if (j >= collection.Columns())
            {
                j = collection.Columns()-1;
                i++;
                twodreverse = true;
            }
            }

            while(!IsDone()){
                if(Current() == null){
                    Next();
                }
                else{
                    break;
                }
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }





    }
}