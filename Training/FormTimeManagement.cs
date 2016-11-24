using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Training
{
    public partial class FormTimeManagement : Form
    {

        public FormTimeManagement()
        {
            InitializeComponent();
            this.Icon = Training.Properties.Resources.time;
            int[] arr = new int[] { 180000, 120000, 60000 };
            _n = CreateNode(arr);
            TurnTimers(false);
            showTimer.Tick += (o, e) => { lblRemain.Text = (int.Parse(lblRemain.Text) - 1).ToString(); };
            timer.Tick += new EventHandler(timer_Tick);
            
            ucTomato1.TimeOver += (o,e) => Remind();
        }

        private void TurnTimers(bool on)
        {
            showTimer.Enabled = on;
            timer.Enabled = on;
            if (on)
            {
                timer.Stop();
                timer.Start();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_cur == null)
            {
                _cur = _n.Next;
            }
            else
            {
                _cur = _cur.Next;
            }
            StartTick();
        }

        private void StartTick()
        {
            int t = _cur.Value;
            timer.Interval = t;
            lblRound.Text = (t / 60000 ).ToString() + "分钟";
            lblRemain.Text = (t / 1000).ToString();

            TurnTimers(true);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Remind();

            TurnTimers(false);
        }

        public void Remind()
        {
            this.BringToFront();
            this.Activate();
            string remindPath = System.IO.Path.Combine(Application.StartupPath, "remind");

            if (!File.Exists(remindPath))
            {
                return;
            }
            string[] reminds = Directory.GetFiles(remindPath);
            if (reminds.Length <= 0)
            {
                return;
            }

            Random r = new Random(-47);
            int index = r.Next(reminds.Length);
            {
                Process.Start(reminds[index]);
            }
        }

        private void CloseShowTimer()
        {
            showTimer.Enabled = false;
        }      

        Node _n = null;
        Node _cur = null; 

        private Node CreateNode(int[] arr)
        {
            Node end = new Node() { Value = arr[arr.Length - 1] };
            end.Next = end;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                Node n = new Node() { Value = arr[i] };
                n.Next = end.Next;
                end.Next = n;
            }

            return end;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _cur = _n.Next;
            StartTick();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            StartTick();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class LoopList
    {
        int _count = 0;
        Node _end = null;
        public Node Next()
        {
            return _end.Next;
        }

        public void AddLast(Node n)
        {
            if (_end == null)
            {
                _end = n;
                _end.Next = _end;
            }
            else
            {
                n.Next = _end;
                _end.Next = n;
                _end = n;
            }
        }
    }
}
