//
// ICT2106 Software Design - Timer exercise
//
// A class that prints a message to the screen every time it receives a notification.
//

using System;

namespace Timer
{
    class TextAlarm:iObserver
    {
        // the message to be printed
        private string message;
        private int timeCount{set;get;}

        // constructor
        public TextAlarm(string messageIn,int timeCountIn)
        {
            // save the message for later
            message = messageIn;
            timeCount = timeCountIn;

        }
		
		// to be invoked when the alarm is triggered
		public void Update()
		{
			Console.WriteLine(message);
		}

        //Get time count value
        public int getTimeCount(){
            return timeCount;
        }
        //Decrement time count
        public void timeCountDecrement(){
            timeCount--;
        }
    }
}
