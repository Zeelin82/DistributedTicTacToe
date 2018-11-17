using DistributedTicTacToe.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributedTicTacToe
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            new Presenter.Presenter(this);
        }
    }
}
