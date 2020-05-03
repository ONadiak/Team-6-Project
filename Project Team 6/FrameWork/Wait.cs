using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Project_Team_6.FrameWork
{
    class Wait
    {
        public static bool WaitFor(Func<bool> func, int Timeout = 250, int waitInternal = 50)
        {
            DateTime start = DateTime.Now;
            do
            {
                if (func())
                {
                    return true;
                }
                Thread.Sleep(waitInternal);
            } while (DateTime.Now - start < TimeSpan.FromMilliseconds(Timeout));
            return false;
        }
    }
}
