// Copyright (c) Microsoft Corporation. All rights reserved.
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Reflection;
namespace TaskbarDemo
{
    public partial class ChildDocument : Form
    {
        void demo()
        {
            if (ShowProgressBar.IsChecked.Value)
            {
                TaskbarManager.Instance.SetProgressValue((int)progressSlider.Value, 100);
                TaskbarManager.Instance.SetProgressState((TaskbarProgressBarState)ProgressStateSelection.SelectedItem);
            } 
            else 
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress); 
            }

            if (ShowProgressBar.IsChecked.Value) 
            {
                ProgressStateSelection.SelectedItem = TaskbarProgressBarState.Normal; 
            }
            else 
            {
                ProgressStateSelection.SelectedItem = TaskbarProgressBarState.NoProgress;
            }
            UpdateProgress();
        }

        // Keep a reference to the Taskbar instance
        private TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        private JumpList childWindowJumpList;
        private string childWindowAppId;
        void ChildDocument_Shown(object sender, EventArgs e)
        {
            // Set our default
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, this.Handle);
        }
        #region Progress Bar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // When the user changes the trackBar value,
            // update the progress bar in our UI as well as Taskbar
            progressBar1.Value = trackBar1.Value;
            windowsTaskbar.SetProgressValue(trackBar1.Value, 100, this.Handle);
        }
        private void comboBoxProgressBarStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the status of the taskbar progress bar
            TaskbarProgressBarState state = (TaskbarProgressBarState)(Enum.Parse(typeof(TaskbarProgressBarState),
                             (string)comboBoxProgressBarStates.SelectedItem));
            windowsTaskbar.SetProgressState(state, this.Handle);
            // Update the application progress bar,
            // as well disable the trackbar in some cases
            switch (state)
            {
                case TaskbarProgressBarState.Normal:
                    if (trackBar1.Value == 0)
                    {
                        trackBar1.Value = 20;
                        progressBar1.Value = trackBar1.Value;
                    }
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    windowsTaskbar.SetProgressValue(trackBar1.Value, 100, this.Handle);
                    trackBar1.Enabled = true;
                    break;
                case TaskbarProgressBarState.Paused:
                    if (trackBar1.Value == 0)
                    {
                        trackBar1.Value = 20;
                        progressBar1.Value = trackBar1.Value;
                    }
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    windowsTaskbar.SetProgressValue(trackBar1.Value, 100, this.Handle);
                    trackBar1.Enabled = true;
                    break;
                case TaskbarProgressBarState.Error:
                    if (trackBar1.Value == 0)
                    {
                        trackBar1.Value = 20;
                        progressBar1.Value = trackBar1.Value;
                    }
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    windowsTaskbar.SetProgressValue(trackBar1.Value, 100, this.Handle);
                    trackBar1.Enabled = true;
                    break;
                case TaskbarProgressBarState.Indeterminate:
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    progressBar1.MarqueeAnimationSpeed = 30;
                    trackBar1.Enabled = false;
                    break;
                case TaskbarProgressBarState.NoProgress:
                    progressBar1.Value = 0;
                    trackBar1.Value = 0;
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    trackBar1.Enabled = false;
                    break;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            childWindowJumpList = JumpList.CreateJumpListForIndividualWindow(childWindowAppId, this.Handle);
            ((Button)sender).Enabled = false;
            groupBoxCustomCategories.Enabled = true;
            buttonRefreshTaskbarList.Enabled = true;
        }
    }
}