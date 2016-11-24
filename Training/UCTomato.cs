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
    public partial class UCTomato : UserControl
    {
        public event EventHandler TimeOver;

        Tomato _tomato = new Tomato();

        public UCTomato()
        {
            InitializeComponent();
            timer.Enabled = false;
            _tomato.TimeOver += _tomato_TimeOver;
            testLinear();

        }

        void testLinear()
        {
            Rectangle area = txtFocusSpan.ClientRectangle;
            
            Graphics g = this.CreateGraphics();
 
            
          
            /*LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Red, LinearGradientMode.Horizontal);
     Graphics g = this.CreateGraphics();
     g.FillRectangle(brush, 1, 1, 100, 100);
     g.DrawString("zhuzhao", this.Font, brush, 1, 1);*/
            /*LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Red, LinearGradientMode.Horizontal);
            brush.SetBlendTriangularShape(0.5f);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(brush, 1, 1, 1000, 100);
            g.DrawString("zhuzhao", this.Font, brush, 1, 1);*/
            LinearGradientBrush brush = new LinearGradientBrush(area, Color.White, Color.Red, LinearGradientMode.Horizontal);
            brush.SetSigmaBellShape(0.5f);
          
            g.FillRectangle(brush, 1, 1, 1000, 100);
            g.DrawString("zhuzhao", this.Font, brush, 1, 1);
            

        }
        void _tomato_TimeOver(object sender, EventArgs e)
        {
            timer.Stop();
            txtRemain.Enabled = true;
            if (TimeOver != null)
            {
                TimeOver(this, null);
            }
        }

        private void btnTomatoFocus_Click(object sender, EventArgs e)
        {            
            _tomato.StartFocus();
            timer.Enabled = true;             
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _tomato.Tick();
            txtRemain.Text = _tomato.TimeRemain.ToString("c").Substring(3);
            //timer.Start();
            txtRemain.Enabled = false;
        } 
        private void btnTomatoRelax_Click(object sender, EventArgs e)
        {
            _tomato.StartRelax();
            timer.Enabled = true;
        }

        private void txtFocusSpan_TextChanged(object sender, EventArgs e)
        {
            _tomato.FocusSpan = new TimeSpan(0, int.Parse(txtFocusSpan.Text), 0);
        }

        private void txtRelaxSpan_TextChanged(object sender, EventArgs e)
        {
            _tomato.RelaxSpan = new TimeSpan(0, int.Parse(txtRelaxSpan.Text), 0);
        }

        private void btnStopTomato_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnStartTomato_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnTomatoRelaxLong_Click(object sender, EventArgs e)
        {
            _tomato.StartLongRelax();
            timer.Enabled = true;
        }
    }
}
