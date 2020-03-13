//Exercise 4 Step 2 - Implement the Couple class so that it behaves as described in Step 1

using System;

namespace Couple
{
    class Couple{
        
        static Couple c1;
        static Couple c2;

        public static Couple GetInstance(int value){
        if(c1 == null){
            c1 = new Couple();
        }

        if(c2 == null){
            c2 = new Couple();
        }

        if(value == 1){
            return c1;
        }
        else{
            return c2;
        }

       

        }
    }
}