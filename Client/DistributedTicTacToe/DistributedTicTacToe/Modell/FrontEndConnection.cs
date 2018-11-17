using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedTicTacToe.Modell
{
    public static class FrontEndConnection
    {
        public static void connect()
        {
            while(true)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Will try to connect to front end");
            }
        }
    }
}
