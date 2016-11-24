namespace Training
{
    partial class UCTomato
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
            this.btnResetTomato = new System.Windows.Forms.Button();
            this.btnTomatoRelaxLong = new System.Windows.Forms.Button();
            this.btnStopTomato = new System.Windows.Forms.Button();
            this.btnTomatoRelax = new System.Windows.Forms.Button();
            this.btnTomatoFocus = new System.Windows.Forms.Button();
            this.btnStartTomato = new System.Windows.Forms.Button();
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
            // btnResetTomato
            // 
            this.btnResetTomato.Location = new System.Drawing.Point(197, 113);
            this.btnResetTomato.Name = "btnResetTomato";
            this.btnResetTomato.Size = new System.Drawing.Size(75, 23);
            this.btnResetTomato.TabIndex = 3;
            this.btnResetTomato.Text = "重置";
            this.btnResetTomato.UseVisualStyleBackColor = true;
            // 
            // btnTomatoRelaxLong
            // 
            this.btnTomatoRelaxLong.BackColor = System.Drawing.Color.Ivory;
            this.btnTomatoRelaxLong.Location = new System.Drawing.Point(197, 75);
            this.btnTomatoRelaxLong.Name = "btnTomatoRelaxLong";
            this.btnTomatoRelaxLong.Size = new System.Drawing.Size(75, 23);
            this.btnTomatoRelaxLong.TabIndex = 4;
            this.btnTomatoRelaxLong.Text = "久放松(&L)";
            this.btnTomatoRelaxLong.UseVisualStyleBackColor = false;
            this.btnTomatoRelaxLong.Click += new System.EventHandler(this.btnTomatoRelaxLong_Click);
            // 
            // btnStopTomato
            // 
            this.btnStopTomato.Location = new System.Drawing.Point(97, 113);
            this.btnStopTomato.Name = "btnStopTomato";
            this.btnStopTomato.Size = new System.Drawing.Size(75, 23);
            this.btnStopTomato.TabIndex = 5;
            this.btnStopTomato.Text = "停止(&P)";
            this.btnStopTomato.UseVisualStyleBackColor = true;
            this.btnStopTomato.Click += new System.EventHandler(this.btnStopTomato_Click);
            // 
            // btnTomatoRelax
            // 
            this.btnTomatoRelax.Location = new System.Drawing.Point(97, 75);
            this.btnTomatoRelax.Name = "btnTomatoRelax";
            this.btnTomatoRelax.Size = new System.Drawing.Size(75, 23);
            this.btnTomatoRelax.TabIndex = 6;
            this.btnTomatoRelax.Text = "放松(&R)";
            this.btnTomatoRelax.UseVisualStyleBackColor = true;
            this.btnTomatoRelax.Click += new System.EventHandler(this.btnTomatoRelax_Click);
            // 
            // btnTomatoFocus
            // 
            this.btnTomatoFocus.Location = new System.Drawing.Point(3, 75);
            this.btnTomatoFocus.Name = "btnTomatoFocus";
            this.btnTomatoFocus.Size = new System.Drawing.Size(75, 23);
            this.btnTomatoFocus.TabIndex = 7;
            this.btnTomatoFocus.Text = "专注(&F)";
            this.btnTomatoFocus.UseVisualStyleBackColor = true;
            this.btnTomatoFocus.Click += new System.EventHandler(this.btnTomatoFocus_Click);
            // 
            // btnStartTomato
            // 
            this.btnStartTomato.Location = new System.Drawing.Point(3, 113);
            this.btnStartTomato.Name = "btnStartTomato";
            this.btnStartTomato.Size = new System.Drawing.Size(75, 23);
            this.btnStartTomato.TabIndex = 8;
            this.btnStartTomato.Text = "开始(&S)";
            this.btnStartTomato.UseVisualStyleBackColor = true;
            this.btnStartTomato.Click += new System.EventHandler(this.btnStartTomato_Click);
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
            // UCTomato
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
            this.Controls.Add(this.btnResetTomato);
            this.Controls.Add(this.btnTomatoRelaxLong);
            this.Controls.Add(this.btnStopTomato);
            this.Controls.Add(this.btnTomatoRelax);
            this.Controls.Add(this.btnTomatoFocus);
            this.Controls.Add(this.btnStartTomato);
            this.Controls.Add(this.txtRemain);
            this.Name = "UCTomato";
            this.Size = new System.Drawing.Size(278, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetTomato;
        private System.Windows.Forms.Button btnTomatoRelaxLong;
        private System.Windows.Forms.Button btnStopTomato;
        private System.Windows.Forms.Button btnTomatoRelax;
        private System.Windows.Forms.Button btnTomatoFocus;
        private System.Windows.Forms.Button btnStartTomato;
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
