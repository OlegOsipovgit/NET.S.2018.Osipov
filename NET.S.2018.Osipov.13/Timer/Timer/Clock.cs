using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Timer
{
    public class Clock
    {
        private int time;
        public Clock(int time)
        {
            this.time = time;
        }
        /// <summary>
        /// Event
        /// </summary>
        public event EventHandler<ClocksFinishedEventArgs> ClocksFinished;
        /// <summary>
        /// Method runs event
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnClocksFinished(ClocksFinishedEventArgs e)
        {
            if (ClocksFinished != null) ClocksFinished(this,e);
        }
        /// <summary>
        /// Timer method
        /// </summary>
        /// <param name="information"></param>
        public void StartClocks(string information)
        {
            Thread.Sleep(1000 * time);
            
        }
        /// <summary>
        /// Class for information of event
        /// </summary>
        public sealed class ClocksFinishedEventArgs:EventArgs
        {
            public string Information { get; }
            public ClocksFinishedEventArgs(string information)
            {
                Information = information;
            }
        }
    }
}
