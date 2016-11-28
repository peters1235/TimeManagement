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

        DispatcherTimer secondsTimer = new DispatcherTimer();
        DispatcherTimer halfHourTimer = new DispatcherTimer();
        string MindPyramidFile = "MindPyramid.txt";
        string DailyProgressFile = "DailyProgress.txt";

        public MainWindow()
        {
            InitializeComponent();

            _pomodoro.TimeOver += _pomodoro_TimeOver;

            InitHalfHourTimer();

            secondsTimer.Tick += timer_Tick;
            ResetProgress((int)_pomodoro.CurrentTotalSpan.TotalSeconds);

            InitLogs();
        }

        private void InitLogs()
        {
            string a = System.IO.File.ReadAllText("MindPyramid.txt", Encoding.UTF8);

            FlowDocument flowDoc = new FlowDocument();
            flowDoc.Blocks.Add(new Paragraph(new Run(a)));                              
            
            //flowDoc.Blocks.Add(new Paragraph("\r\n" + DateTime.Now.ToShortTimeString() + "\t" + "E*T" + "\t"));
            txtMindTracer.Document = flowDoc;
            txtMindTracer.ScrollToEnd();

            //TextPointer caretPos = txtMindTracer.CaretPosition;

            //// Set the TextPointer to the end of the current document.
            //caretPos = caretPos.DocumentEnd;

            //// Specify the new caret position at the end of the current document.
            //txtMindTracer.CaretPosition = caretPos;


            //Daily Progress
            String progresss = System.IO.File.ReadAllText(DailyProgressFile, Encoding.UTF8);
            FlowDocument progressDoc = new FlowDocument();
            progressDoc.Blocks.Add(new Paragraph(new Run(progresss)));
            txtDailyProgress.Document = progressDoc;
        }

        private void InitHalfHourTimer()
        {
            secondsTimer.Interval = TimeSpan.FromMilliseconds(1000);
            halfHourTimer.Interval = TimeSpan.FromMilliseconds(1800000);
            halfHourTimer.Tick += halfHourTimer_Tick;
        }

        void halfHourTimer_Tick(object sender, EventArgs e)
        {
            HalfAnHourLater();
        }

        private void HalfAnHourLater()
        {
            SaveMindPyramid();
            SaveDailyProgress();
            txtMindTracer.AppendText("\r\n" + DateTime.Now.ToString("G"));
            this.Activate();
        }

        void timer_Tick(object sender, EventArgs e)
        {            
            _pomodoro.Tick();           
            
            txtRemain.Content = _pomodoro.TimeRemain.ToString("c").Substring(3);

            timeProgress.Value++;   

            int secondsGone = (int) (_pomodoro.CurrentTotalSpan.TotalSeconds - _pomodoro.TimeRemain.TotalSeconds);
            TaskbarManager.Instance.SetProgressValue(secondsGone
                , (int)_pomodoro.CurrentTotalSpan.TotalSeconds);
        }

        void _pomodoro_TimeOver(object sender, EventArgs e)
        {
            this.Activate();
            secondsTimer.Stop();
            if (TimeOver != null)
            {
                TimeOver(this, null);
            }
        }

        private void btnPomodoroRelaxLong_Click(object sender, EventArgs e)
        {
            InitLogs();

            _pomodoro.StartLongRelax();
          
            ResetProgress((int) _pomodoro.CurrentTotalSpan.TotalSeconds);

            secondsTimer.Start();
        }

        private void ResetProgress(int seconds)
        {
            timeProgress.Maximum = seconds;
            timeProgress.Value = 0;
        }

        private void btnPomodoroRelax_Click(object sender, EventArgs e)
        {
            _pomodoro.StartRelax();

            ResetProgress((int)_pomodoro.CurrentTotalSpan.TotalSeconds);

            secondsTimer.Start();
        }

        private void btnPomodoroFocus_Click(object sender, EventArgs e)
        {
            _pomodoro.StartFocus();

            ResetProgress((int)_pomodoro.CurrentTotalSpan.TotalSeconds);

            secondsTimer.Start();
        }

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {
            ToggleSecondsTimer();

        }

        private void ToggleSecondsTimer()
        {

            if (secondsTimer.IsEnabled)
            {
                secondsTimer.Stop();
            }
            else
            {
                secondsTimer.Start();
            }
        }

        private void timeProgress_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ToggleSecondsTimer();
        }

        private void txtRemain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ToggleSecondsTimer();
        }

        private void txtMindTracer_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void SaveMindPyramid()
        {
            TextRange documentTextRange = new TextRange(txtMindTracer.Document.ContentStart, txtMindTracer.Document.ContentEnd);
            string dataFormat = documentTextRange.Text;
            System.IO.File.WriteAllText(MindPyramidFile,dataFormat);
        }

        private void txtDailyProgress_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SaveDailyProgress()
        {
            TextRange documentTextRange = new TextRange(txtDailyProgress.Document.ContentStart, txtDailyProgress.Document.ContentEnd);
            string dataFormat = documentTextRange.Text;
            System.IO.File.WriteAllText(DailyProgressFile,dataFormat);
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveLogs();
        }

        private void CommandBinding_SaveLogs_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveLogs();
        }

        private void SaveLogs()
        {
            SaveMindPyramid();
            SaveDailyProgress();
        }

        private void CommandBinding_SaveLogs_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }   
    }
     
}
