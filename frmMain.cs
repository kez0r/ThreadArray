using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ThreadArray
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        public static Thread[] threadArray;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtNumThreads.Text.Trim() == "") return;

            var numThreads = Convert.ToInt32(txtNumThreads.Text);
            if (numThreads <= 0) return;

            var operationsPer = Convert.ToInt32(txtOperations.Text);
            if (operationsPer <= 0) return;

            Console.WriteLine("Starting... ({0} thread/s, {1} operation/s per)", numThreads, operationsPer);
            
            //populate the checker thread array
            threadArray = new Thread[numThreads];

            for (var i = 0; i < threadArray.Count(); i++)
            {
                var t = i; //clone iteration variable

                //assign SampleWorkerMethod to worker thread and start
                threadArray[t] = new Thread(() => SampleWorkerMethod(threadArray[t].Name, operationsPer)) { Name = "Worker " + (t + 1) };
                threadArray[t].Start();
            }

            //thread timer
            threadTimer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (var thread in threadArray)
                thread.Abort();
        }

        public void SampleWorkerMethod(string threadName, int operationsPerThread)
        {
            //this is a simple sample method

            for (var i = 0; i < operationsPerThread; i++)
            {
                var t = i; //clone iteration variable
                Console.WriteLine("Thread [{0}]: Operation #{1}", threadName, (t + 1));
            }
        }

        private void threadTimer_Tick(object sender, EventArgs e)
        {
            //check if any threads are still running
            var runningThreads = threadArray.Any(thread => thread.IsAlive);

            //thread(s) are still active
            if (runningThreads) return;

            //threads are finished running (or stopped), notify user of thread completion
            Console.WriteLine("Thread operations completed!");

            //turn off thread timer
            threadTimer.Enabled = false;
        }
    }
}
