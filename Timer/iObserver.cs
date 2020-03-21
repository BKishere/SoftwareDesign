using System;

namespace Timer{
    interface iObserver{
        void Update();
        int getTimeCount();
        void timeCountDecrement();

    }
}