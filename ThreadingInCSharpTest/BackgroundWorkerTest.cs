using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThreadingInCSharpTest
{
    using System.ComponentModel;

    [TestClass]
    public class BackgroundWorkerTest
    {
        static BackgroundWorker _bw = new BackgroundWorker();

        [TestMethod]
        public void TestMethod1()
        {
            _bw.DoWork += bw_DoWork;
            _bw.RunWorkerAsync("Message to worker");
        }

        static void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            // This is called on the worker thread
            Console.WriteLine(e.Argument);        // writes "Message to worker"
                                                  // Perform time-consuming task...
        }
    }
}
