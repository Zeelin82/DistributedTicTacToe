using DistributedTicTacToe.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedTicTacToe.Presenter
{
    class Presenter
    {
        private View view;
        public Presenter(View view)
        {
            this.view = view;
            intialize();
        }

        private void intialize()
        {
            // tcp listener
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                FrontEndConnection.connect();
            }).Start();          
        }
    }
}
