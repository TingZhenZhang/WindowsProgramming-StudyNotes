
namespace MyGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.powerBar = new System.Windows.Forms.ProgressBar();
            this.replayButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.ballActingTimer = new System.Windows.Forms.Timer(this.components);
            this.ballPanel = new System.Windows.Forms.Panel();
            this.hintLabel = new System.Windows.Forms.Label();
            this.ballPic = new System.Windows.Forms.PictureBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.ringPic = new System.Windows.Forms.PictureBox();
            this.powerTimer = new System.Windows.Forms.Timer(this.components);
            this.ballPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringPic)).BeginInit();
            this.SuspendLayout();
            // 
            // powerBar
            // 
            this.powerBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.powerBar.Enabled = false;
            this.powerBar.ForeColor = System.Drawing.Color.Coral;
            this.powerBar.Location = new System.Drawing.Point(237, 20);
            this.powerBar.Margin = new System.Windows.Forms.Padding(5);
            this.powerBar.MaximumSize = new System.Drawing.Size(0, 31);
            this.powerBar.MinimumSize = new System.Drawing.Size(627, 31);
            this.powerBar.Name = "powerBar";
            this.powerBar.Size = new System.Drawing.Size(627, 31);
            this.powerBar.Step = 0;
            this.powerBar.TabIndex = 0;
            this.powerBar.Visible = false;
            // 
            // replayButton
            // 
            this.replayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.replayButton.AutoSize = true;
            this.replayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.replayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.replayButton.Enabled = false;
            this.replayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.ForeColor = System.Drawing.Color.Silver;
            this.replayButton.Location = new System.Drawing.Point(465, 286);
            this.replayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.replayButton.MaximumSize = new System.Drawing.Size(349, 100);
            this.replayButton.MinimumSize = new System.Drawing.Size(181, 52);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(181, 52);
            this.replayButton.TabIndex = 0;
            this.replayButton.Text = "PLAY AGAIN";
            this.replayButton.UseVisualStyleBackColor = false;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.AutoSize = true;
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playButton.Location = new System.Drawing.Point(492, 276);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playButton.Name = "playButton";
            this.playButton.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.playButton.Size = new System.Drawing.Size(131, 62);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // ballActingTimer
            // 
            this.ballActingTimer.Tick += new System.EventHandler(this.ballActingTimer_Tick);
            // 
            // ballPanel
            // 
            this.ballPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ballPanel.BackColor = System.Drawing.Color.LightGray;
            this.ballPanel.Controls.Add(this.hintLabel);
            this.ballPanel.Controls.Add(this.ballPic);
            this.ballPanel.Controls.Add(this.showLabel);
            this.ballPanel.Controls.Add(this.ringPic);
            this.ballPanel.Location = new System.Drawing.Point(15, 65);
            this.ballPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ballPanel.Name = "ballPanel";
            this.ballPanel.Size = new System.Drawing.Size(1080, 490);
            this.ballPanel.TabIndex = 4;
            this.ballPanel.Visible = false;
            // 
            // hintLabel
            // 
            this.hintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hintLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hintLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.hintLabel.Location = new System.Drawing.Point(367, 129);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(362, 66);
            this.hintLabel.TabIndex = 5;
            this.hintLabel.Text = "Press SPACE to start !";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hintLabel.Visible = false;
            // 
            // ballPic
            // 
            this.ballPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ballPic.BackColor = System.Drawing.Color.Transparent;
            this.ballPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballPic.ErrorImage = null;
            this.ballPic.Image = global::MyGame.Properties.Resources.MyBall;
            this.ballPic.InitialImage = null;
            this.ballPic.Location = new System.Drawing.Point(20, 350);
            this.ballPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ballPic.MaximumSize = new System.Drawing.Size(140, 140);
            this.ballPic.MinimumSize = new System.Drawing.Size(100, 100);
            this.ballPic.Name = "ballPic";
            this.ballPic.Size = new System.Drawing.Size(120, 120);
            this.ballPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballPic.TabIndex = 2;
            this.ballPic.TabStop = false;
            this.ballPic.Visible = false;
            // 
            // showLabel
            // 
            this.showLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showLabel.Location = new System.Drawing.Point(404, 113);
            this.showLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(269, 82);
            this.showLabel.TabIndex = 4;
            this.showLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showLabel.Visible = false;
            // 
            // ringPic
            // 
            this.ringPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ringPic.BackColor = System.Drawing.Color.Transparent;
            this.ringPic.ErrorImage = null;
            this.ringPic.Image = global::MyGame.Properties.Resources.ring;
            this.ringPic.InitialImage = null;
            this.ringPic.Location = new System.Drawing.Point(905, 380);
            this.ringPic.Margin = new System.Windows.Forms.Padding(4);
            this.ringPic.Name = "ringPic";
            this.ringPic.Size = new System.Drawing.Size(160, 70);
            this.ringPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ringPic.TabIndex = 3;
            this.ringPic.TabStop = false;
            this.ringPic.Visible = false;
            // 
            // powerTimer
            // 
            this.powerTimer.Interval = 10;
            this.powerTimer.Tick += new System.EventHandler(this.powerTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 573);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.powerBar);
            this.Controls.Add(this.ballPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1130, 620);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyGame";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDark;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ballPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar powerBar;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.PictureBox ballPic;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer ballActingTimer;
        private System.Windows.Forms.Panel ballPanel;
        private System.Windows.Forms.PictureBox ringPic;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Timer powerTimer;
    }
}

