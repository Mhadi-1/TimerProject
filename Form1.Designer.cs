namespace TimerProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_Hurse = new System.Windows.Forms.NumericUpDown();
            this.numeric_Minutes = new System.Windows.Forms.NumericUpDown();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tmr_Counter = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_Second = new System.Windows.Forms.NumericUpDown();
            this.notify_Timer = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hurse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Second)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.circularProgressBar1.AnimationSpeed = 600;
            this.circularProgressBar1.BackColor = System.Drawing.Color.White;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(57, 102);
            this.circularProgressBar1.MarqueeAnimationSpeed = 1000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.DimGray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(313, 315);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 0;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Yellow;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "C";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "25";
            this.circularProgressBar1.TabIndex = 2;
            this.circularProgressBar1.Text = "00:00:00";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 60;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_Date.Location = new System.Drawing.Point(153, 20);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(108, 32);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "00:00:00";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_tt
            // 
            this.lbl_tt.AutoSize = true;
            this.lbl_tt.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_tt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_tt.Location = new System.Drawing.Point(271, 52);
            this.lbl_tt.Name = "lbl_tt";
            this.lbl_tt.Size = new System.Drawing.Size(0, 32);
            this.lbl_tt.TabIndex = 4;
            this.lbl_tt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(122, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "h";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(243, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "m";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeric_Hurse
            // 
            this.numeric_Hurse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numeric_Hurse.ForeColor = System.Drawing.Color.Black;
            this.numeric_Hurse.Location = new System.Drawing.Point(55, 476);
            this.numeric_Hurse.Name = "numeric_Hurse";
            this.numeric_Hurse.Size = new System.Drawing.Size(61, 26);
            this.numeric_Hurse.TabIndex = 11;
            this.numeric_Hurse.TabStop = false;
            this.numeric_Hurse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeric_Minutes
            // 
            this.numeric_Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numeric_Minutes.ForeColor = System.Drawing.Color.Black;
            this.numeric_Minutes.Location = new System.Drawing.Point(178, 476);
            this.numeric_Minutes.Name = "numeric_Minutes";
            this.numeric_Minutes.Size = new System.Drawing.Size(55, 26);
            this.numeric_Minutes.TabIndex = 13;
            this.numeric_Minutes.TabStop = false;
            this.numeric_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Start
            // 
            this.btn_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_Start.ForeColor = System.Drawing.Color.Teal;
            this.btn_Start.Location = new System.Drawing.Point(37, 548);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(100, 36);
            this.btn_Start.TabIndex = 14;
            this.btn_Start.TabStop = false;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Stop.BackColor = System.Drawing.Color.White;
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_Stop.ForeColor = System.Drawing.Color.Teal;
            this.btn_Stop.Location = new System.Drawing.Point(273, 548);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(100, 36);
            this.btn_Stop.TabIndex = 15;
            this.btn_Stop.TabStop = false;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_Reset.ForeColor = System.Drawing.Color.Teal;
            this.btn_Reset.Location = new System.Drawing.Point(169, 548);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(77, 36);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.TabStop = false;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tmr_Counter
            // 
            this.tmr_Counter.Interval = 1000;
            this.tmr_Counter.Tick += new System.EventHandler(this.tmrcircualrPrograss_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(359, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeric_Second
            // 
            this.numeric_Second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numeric_Second.ForeColor = System.Drawing.Color.Black;
            this.numeric_Second.Location = new System.Drawing.Point(289, 476);
            this.numeric_Second.Name = "numeric_Second";
            this.numeric_Second.Size = new System.Drawing.Size(64, 26);
            this.numeric_Second.TabIndex = 12;
            this.numeric_Second.TabStop = false;
            this.numeric_Second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notify_Timer
            // 
            this.notify_Timer.Text = "notifyTimer";
            this.notify_Timer.Visible = true;
            this.notify_Timer.BalloonTipClosed += new System.EventHandler(this.notify_Timer_BalloonTipClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 650);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.numeric_Minutes);
            this.Controls.Add(this.numeric_Second);
            this.Controls.Add(this.numeric_Hurse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.lbl_Date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminnder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hurse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_Hurse;
        private System.Windows.Forms.NumericUpDown numeric_Minutes;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Timer tmr_Counter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_Second;
        private System.Windows.Forms.NotifyIcon notify_Timer;
    }
}

