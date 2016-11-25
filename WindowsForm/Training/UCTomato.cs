using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Training
{
    public partial class UCPomodoro : UserControl
    {
        public event EventHandler TimeOver;

        Pomodoro _pomodoro = new Pomodoro();

        public UCPomodoro()
        {
            InitializeComponent();
            timer.Enabled = false;
            _pomodoro.TimeOver += _pomodoro_TimeOver;
            testLinear();

        }

        void testLinear()
        {
            /*LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Red, LinearGradientMode.Horizontal);
     Graphics g = this.CreateGraphics();
     g.FillRectangle(brush, 1, 1, 100, 100);
     g.DrawString("zhuzhao", this.Font, brush, 1, 1);*/
            /*LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Red, LinearGradientMode.Horizontal);
            brush.SetBlendTriangularShape(0.5f);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(brush, 1, 1, 1000, 100);
            g.DrawString("zhuzhao", this.Font, brush, 1, 1);*/
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Red, LinearGradientMode.Horizontal);
            brush.SetSigmaBellShape(0.5f);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(brush, 1, 1, 1000, 100);
            g.DrawString("zhuzhao", this.Font, brush, 1, 1);

        }
        void _pomodoro_TimeOver(object sender, EventArgs e)
        {
            timer.Stop();
            txtRemain.Enabled = true;
            if (TimeOver != null)
            {
                TimeOver(this, null);
            }
        }

        private void btnPomodoroFocus_Click(object sender, EventArgs e)
        {            
            _pomodoro.StartFocus();
            timer.Enabled = true;             
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _pomodoro.Tick();
            txtRemain.Text = _pomodoro.TimeRemain.ToString("c").Substring(3);
            //timer.Start();
            txtRemain.Enabled = false;
        } 
        private void btnPomodoroRelax_Click(object sender, EventArgs e)
        {
            _pomodoro.StartRelax();
            timer.Enabled = true;
        }

        private void txtFocusSpan_TextChanged(object sender, EventArgs e)
        {
            _pomodoro.FocusSpan = new TimeSpan(0, int.Parse(txtFocusSpan.Text), 0);
        }

        private void txtRelaxSpan_TextChanged(object sender, EventArgs e)
        {
            _pomodoro.RelaxSpan = new TimeSpan(0, int.Parse(txtRelaxSpan.Text), 0);
        }

        private void btnStopPomodoro_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnStartPomodoro_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnPomodoroRelaxLong_Click(object sender, EventArgs e)
        {
            _pomodoro.StartLongRelax();
            timer.Enabled = true;
        }
    }
}
