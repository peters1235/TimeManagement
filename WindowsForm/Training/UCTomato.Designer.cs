namespace Training
{
    partial class UCPomodoro
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnResetPomodoro = new System.Windows.Forms.Button();
            this.btnPomodoroRelaxLong = new System.Windows.Forms.Button();
            this.btnStopPomodoro = new System.Windows.Forms.Button();
            this.btnPomodoroRelax = new System.Windows.Forms.Button();
            this.btnPomodoroFocus = new System.Windows.Forms.Button();
            this.btnStartPomodoro = new System.Windows.Forms.Button();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFocusSpan = new System.Windows.Forms.TextBox();
            this.txtRelaxSpan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResetPomodoro
            // 
            this.btnResetPomodoro.Location = new System.Drawing.Point(197, 113);
            this.btnResetPomodoro.Name = "btnResetPomodoro";
            this.btnResetPomodoro.Size = new System.Drawing.Size(75, 23);
            this.btnResetPomodoro.TabIndex = 3;
            this.btnResetPomodoro.Text = "重置";
            this.btnResetPomodoro.UseVisualStyleBackColor = true;
            // 
            // btnPomodoroRelaxLong
            // 
            this.btnPomodoroRelaxLong.BackColor = System.Drawing.Color.Ivory;
            this.btnPomodoroRelaxLong.Location = new System.Drawing.Point(197, 75);
            this.btnPomodoroRelaxLong.Name = "btnPomodoroRelaxLong";
            this.btnPomodoroRelaxLong.Size = new System.Drawing.Size(75, 23);
            this.btnPomodoroRelaxLong.TabIndex = 4;
            this.btnPomodoroRelaxLong.Text = "久放松(&L)";
            this.btnPomodoroRelaxLong.UseVisualStyleBackColor = false;
            this.btnPomodoroRelaxLong.Click += new System.EventHandler(this.btnPomodoroRelaxLong_Click);
            // 
            // btnStopPomodoro
            // 
            this.btnStopPomodoro.Location = new System.Drawing.Point(97, 113);
            this.btnStopPomodoro.Name = "btnStopPomodoro";
            this.btnStopPomodoro.Size = new System.Drawing.Size(75, 23);
            this.btnStopPomodoro.TabIndex = 5;
            this.btnStopPomodoro.Text = "停止(&P)";
            this.btnStopPomodoro.UseVisualStyleBackColor = true;
            this.btnStopPomodoro.Click += new System.EventHandler(this.btnStopPomodoro_Click);
            // 
            // btnPomodoroRelax
            // 
            this.btnPomodoroRelax.Location = new System.Drawing.Point(97, 75);
            this.btnPomodoroRelax.Name = "btnPomodoroRelax";
            this.btnPomodoroRelax.Size = new System.Drawing.Size(75, 23);
            this.btnPomodoroRelax.TabIndex = 6;
            this.btnPomodoroRelax.Text = "放松(&R)";
            this.btnPomodoroRelax.UseVisualStyleBackColor = true;
            this.btnPomodoroRelax.Click += new System.EventHandler(this.btnPomodoroRelax_Click);
            // 
            // btnPomodoroFocus
            // 
            this.btnPomodoroFocus.Location = new System.Drawing.Point(3, 75);
            this.btnPomodoroFocus.Name = "btnPomodoroFocus";
            this.btnPomodoroFocus.Size = new System.Drawing.Size(75, 23);
            this.btnPomodoroFocus.TabIndex = 7;
            this.btnPomodoroFocus.Text = "专注(&F)";
            this.btnPomodoroFocus.UseVisualStyleBackColor = true;
            this.btnPomodoroFocus.Click += new System.EventHandler(this.btnPomodoroFocus_Click);
            // 
            // btnStartPomodoro
            // 
            this.btnStartPomodoro.Location = new System.Drawing.Point(3, 113);
            this.btnStartPomodoro.Name = "btnStartPomodoro";
            this.btnStartPomodoro.Size = new System.Drawing.Size(75, 23);
            this.btnStartPomodoro.TabIndex = 8;
            this.btnStartPomodoro.Text = "开始(&S)";
            this.btnStartPomodoro.UseVisualStyleBackColor = true;
            this.btnStartPomodoro.Click += new System.EventHandler(this.btnStartPomodoro_Click);
            // 
            // txtRemain
            // 
            this.txtRemain.Enabled = false;
            this.txtRemain.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemain.Location = new System.Drawing.Point(3, 3);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.Size = new System.Drawing.Size(269, 54);
            this.txtRemain.TabIndex = 2;
            this.txtRemain.Text = "25:00";
            this.txtRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "专注时长";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "放松时长";
            // 
            // txtFocusSpan
            // 
            this.txtFocusSpan.Location = new System.Drawing.Point(97, 146);
            this.txtFocusSpan.Name = "txtFocusSpan";
            this.txtFocusSpan.Size = new System.Drawing.Size(75, 21);
            this.txtFocusSpan.TabIndex = 10;
            this.txtFocusSpan.Text = "25";
            this.txtFocusSpan.TextChanged += new System.EventHandler(this.txtFocusSpan_TextChanged);
            // 
            // txtRelaxSpan
            // 
            this.txtRelaxSpan.Location = new System.Drawing.Point(97, 173);
            this.txtRelaxSpan.Name = "txtRelaxSpan";
            this.txtRelaxSpan.Size = new System.Drawing.Size(75, 21);
            this.txtRelaxSpan.TabIndex = 10;
            this.txtRelaxSpan.Text = "5";
            this.txtRelaxSpan.TextChanged += new System.EventHandler(this.txtRelaxSpan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "分钟";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "分钟";
            // 
            // UCPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.txtRelaxSpan);
            this.Controls.Add(this.txtFocusSpan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetPomodoro);
            this.Controls.Add(this.btnPomodoroRelaxLong);
            this.Controls.Add(this.btnStopPomodoro);
            this.Controls.Add(this.btnPomodoroRelax);
            this.Controls.Add(this.btnPomodoroFocus);
            this.Controls.Add(this.btnStartPomodoro);
            this.Controls.Add(this.txtRemain);
            this.Name = "UCPomodoro";
            this.Size = new System.Drawing.Size(278, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPomodoro;
        private System.Windows.Forms.Button btnPomodoroRelaxLong;
        private System.Windows.Forms.Button btnStopPomodoro;
        private System.Windows.Forms.Button btnPomodoroRelax;
        private System.Windows.Forms.Button btnPomodoroFocus;
        private System.Windows.Forms.Button btnStartPomodoro;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFocusSpan;
        private System.Windows.Forms.TextBox txtRelaxSpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
