using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private CalcManager manager;
        private BackgroundWorker bw;
        private bool cancel = false;
        private bool symbolAtTheEnd = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            manager = new CalcManager(this);
            stopBtn.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancel = true;
        }


    }

}
