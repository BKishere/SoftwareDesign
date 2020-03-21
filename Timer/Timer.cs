//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//
using System.Collections.Generic;

namespace Timer
{
    class Timer:iSubject
    {
        private List<iObserver> list_observer;
        private List<iObserver> list_remove;

        //constructor
        public Timer(){
            list_observer = new List<iObserver>();
            list_remove = new List<iObserver>();
        }

        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Sleeping...");
                Notify();
                numberOfTicks--;
            }
            System.Console.ReadLine();
        }

        //implement Attach Method - attach to subject
        public void Attach(iObserver observer){
            list_observer.Add(observer);
        }

        //implement Detach Method - Detach from subject when no longer in use
        public void Detach(iObserver observer){
            list_observer.Remove(observer);
        }

        //implement Notify Method - Observer notified about data change
        public void Notify(){
            foreach(var i in list_observer){
                if(i.getTimeCount() == 0){
                    i.Update();
                    list_remove.Add(i);
                }
                else{
                    i.timeCountDecrement();
                }
            }
            checkListRemove();
        } 

        //implement remove list of observer for detech
        public void checkListRemove(){
            foreach(var i in list_remove){
                Detach(i);
            }
            list_remove.Clear();
        }
    }
}
