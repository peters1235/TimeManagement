using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace TimeManagement
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {        
        public event EventHandler TimeOver;

        Pomodoro _pomodoro = new Pomodoro();

        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            

            _pomodoro.TimeOver += _pomodoro_TimeOver;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += timer_Tick;            
        }

        void timer_Tick(object sender, EventArgs e)
        {            
            _pomodoro.Tick();
            
            txtRemain.Content = _pomodoro.TimeRemain.ToString("c").Substring(3);
            double unit =btnProgress.Margin.Right / _pomodoro.TimeRemain.TotalSeconds ;
            if ( _pomodoro.TimeRemain.TotalSeconds ==0 )
            {
                unit = 0;
            }
            btnProgress.Margin = new Thickness(btnProgress.Margin.Left,
                btnProgress.Margin.Top,
                
                btnProgress.Margin.Right - unit,
                btnProgress.Margin.Bottom);

            int secondsGone = (int) (_pomodoro.CurrentTotalSpan.TotalSeconds - _pomodoro.TimeRemain.TotalSeconds);

            TaskbarManager.Instance.SetProgressValue(secondsGone
                , (int)_pomodoro.CurrentTotalSpan.TotalSeconds);
        }

        void _pomodoro_TimeOver(object sender, EventArgs e)
        {
            timer.Stop();

            if (TimeOver != null)
            {
                TimeOver(this, null);
            }
        }

        private void btnPomodoroRelaxLong_Click(object sender, EventArgs e)
        {
            _pomodoro.StartLongRelax();
            timer.Start();
        }

        private void btnPomodoroRelax_Click(object sender, EventArgs e)
        {
            _pomodoro.StartRelax();
            timer.Start();
        }

        private void btnPomodoroFocus_Click(object sender, EventArgs e)
        {
            _pomodoro.StartFocus();
            timer.Start();
        }

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }

        }
    }
}
