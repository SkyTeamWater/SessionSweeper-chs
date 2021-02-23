namespace SessionSweeper
{
    partial class fMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.tmrResume = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.lblSessionStatus = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnEnd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnPrintScreen = new System.Windows.Forms.Button();
			this.btnScrollLock = new System.Windows.Forms.Button();
			this.btnPauseBreak = new System.Windows.Forms.Button();
			this.lblLockSessionInfo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrNetwork = new System.Windows.Forms.Timer(this.components);
			this.lblAfkStatus = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrResume
			// 
			this.tmrResume.Interval = 10000;
			this.tmrResume.Tick += new System.EventHandler(this.tmrResume_Tick);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 416);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(440, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Translate by SkyTeamWater - Version 1.4";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSessionStatus
			// 
			this.lblSessionStatus.BackColor = System.Drawing.Color.Green;
			this.lblSessionStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblSessionStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSessionStatus.ForeColor = System.Drawing.Color.White;
			this.lblSessionStatus.Location = new System.Drawing.Point(0, 372);
			this.lblSessionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSessionStatus.Name = "lblSessionStatus";
			this.lblSessionStatus.Size = new System.Drawing.Size(440, 44);
			this.lblSessionStatus.TabIndex = 2;
			this.lblSessionStatus.Text = "战局解锁了!";
			this.lblSessionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnEnd);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnPrintScreen);
			this.groupBox1.Controls.Add(this.btnScrollLock);
			this.groupBox1.Controls.Add(this.btnPauseBreak);
			this.groupBox1.Controls.Add(this.lblLockSessionInfo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(408, 300);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Keybinds";
			// 
			// btnEnd
			// 
			this.btnEnd.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnEnd.Image = global::SessionSweeper.Properties.Resources.end;
			this.btnEnd.Location = new System.Drawing.Point(8, 218);
			this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(53, 44);
			this.btnEnd.TabIndex = 10;
			this.btnEnd.TabStop = false;
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label3.Location = new System.Drawing.Point(69, 230);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(413, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "这个热键将会启动/禁用 自动鼠标移动以防止挂机被踢";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.Location = new System.Drawing.Point(69, 163);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "这个热键会断网五秒";
			// 
			// btnPrintScreen
			// 
			this.btnPrintScreen.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnPrintScreen.Image = global::SessionSweeper.Properties.Resources.printscreen;
			this.btnPrintScreen.Location = new System.Drawing.Point(8, 152);
			this.btnPrintScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnPrintScreen.Name = "btnPrintScreen";
			this.btnPrintScreen.Size = new System.Drawing.Size(53, 44);
			this.btnPrintScreen.TabIndex = 6;
			this.btnPrintScreen.TabStop = false;
			this.btnPrintScreen.UseVisualStyleBackColor = true;
			this.btnPrintScreen.Click += new System.EventHandler(this.btnPrintScreen_Click);
			// 
			// btnScrollLock
			// 
			this.btnScrollLock.Image = global::SessionSweeper.Properties.Resources.scrolllock;
			this.btnScrollLock.Location = new System.Drawing.Point(8, 81);
			this.btnScrollLock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnScrollLock.Name = "btnScrollLock";
			this.btnScrollLock.Size = new System.Drawing.Size(53, 44);
			this.btnScrollLock.TabIndex = 5;
			this.btnScrollLock.TabStop = false;
			this.btnScrollLock.UseVisualStyleBackColor = true;
			this.btnScrollLock.Click += new System.EventHandler(this.btnScrollLock_Click);
			// 
			// btnPauseBreak
			// 
			this.btnPauseBreak.Image = global::SessionSweeper.Properties.Resources.pausebreak;
			this.btnPauseBreak.Location = new System.Drawing.Point(8, 28);
			this.btnPauseBreak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnPauseBreak.Name = "btnPauseBreak";
			this.btnPauseBreak.Size = new System.Drawing.Size(53, 44);
			this.btnPauseBreak.TabIndex = 4;
			this.btnPauseBreak.TabStop = false;
			this.btnPauseBreak.UseVisualStyleBackColor = true;
			this.btnPauseBreak.Click += new System.EventHandler(this.btnPauseBreak_Click);
			// 
			// lblLockSessionInfo
			// 
			this.lblLockSessionInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLockSessionInfo.Location = new System.Drawing.Point(69, 81);
			this.lblLockSessionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLockSessionInfo.Name = "lblLockSessionInfo";
			this.lblLockSessionInfo.Size = new System.Drawing.Size(331, 105);
			this.lblLockSessionInfo.TabIndex = 3;
			this.lblLockSessionInfo.Text = "这个热键会停止其他玩家的加入.只会工作在独自游玩或者和使用SessionSweeper的好友一起.Windows防火墙必须打开.";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 46);
			this.label1.TabIndex = 2;
			this.label1.Text = "这个热键会让你和战局里所有玩家断开.";
			// 
			// tmrNetwork
			// 
			this.tmrNetwork.Interval = 5000;
			this.tmrNetwork.Tick += new System.EventHandler(this.tmrNetwork_Tick);
			// 
			// lblAfkStatus
			// 
			this.lblAfkStatus.BackColor = System.Drawing.Color.Green;
			this.lblAfkStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblAfkStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAfkStatus.ForeColor = System.Drawing.Color.White;
			this.lblAfkStatus.Location = new System.Drawing.Point(0, 328);
			this.lblAfkStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAfkStatus.Name = "lblAfkStatus";
			this.lblAfkStatus.Size = new System.Drawing.Size(440, 44);
			this.lblAfkStatus.TabIndex = 4;
			this.lblAfkStatus.Text = "自动鼠标移动以打开!";
			this.lblAfkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(440, 447);
			this.Controls.Add(this.lblAfkStatus);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblSessionStatus);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "fMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SessionSweeper";
			this.Load += new System.EventHandler(this.fMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrResume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSessionStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLockSessionInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScrollLock;
        private System.Windows.Forms.Button btnPauseBreak;
        private System.Windows.Forms.Button btnPrintScreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrNetwork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblAfkStatus;
    }
}

