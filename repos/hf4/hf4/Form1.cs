using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hf4
{
    public partial class Form1 : Form
    {
        private ManualResetEvent step1Pressed = new ManualResetEvent(false);
        private AutoResetEvent step2Pressed = new AutoResetEvent(false);

        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            startBike(bBike1);
            startBike(bBike2);
            startBike(bBike3);
        }

        private void startBike(Button bike)
        {
            Thread t = new Thread(BikeThread);
            bike.Tag = t;
            t.IsBackground = true;
            t.Start(bike);
        }

        public void BikeThread(object param)
        {
            Button bike = (Button) param;
            while (bike.Left < pStart.Left)
            {
                MoveBike(bike);
                Thread.Sleep(100);
            }
            if (step1Pressed.WaitOne())
            {
                while (bike.Left < pRest.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
            }
            if (step2Pressed.WaitOne())
            {
                while (bike.Left < pTarget.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                }
            }
          
        }

        delegate void BikeAction(Button bike);

        Random random = new Random();

        public void MoveBike(Button bike)
        {
            if (InvokeRequired)
            {
                Invoke(new BikeAction(MoveBike), bike);
            }
            else
            {
                bike.Left += random.Next(3, 9);
            }
        }

        private void bStep1_Click(object sender, EventArgs e)
        {
            step1Pressed.Set();
        }

        private void bStep2_Click(object sender, EventArgs e)
        {
            step2Pressed.Set();
        }

        private void bBike2_Click(object sender, EventArgs e)
        {
            bBike2.
        }
    }
}
