
namespace MyGame_II
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
            this.playButton = new System.Windows.Forms.Button();
            this.powerBarTimer = new System.Windows.Forms.Timer(this.components);
            this.ballActingTimer = new System.Windows.Forms.Timer(this.components);
            this.myPanel = new System.Windows.Forms.Panel();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.ballPic = new System.Windows.Forms.PictureBox();
            this.ringPic = new System.Windows.Forms.PictureBox();
            this.barBack = new System.Windows.Forms.PictureBox();
            this.powerBarPic = new System.Windows.Forms.PictureBox();
            this.myPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.BackColor = System.Drawing.Color.DimGray;
            this.playButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.playButton.Location = new System.Drawing.Point(306, 227);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(187, 62);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // powerBarTimer
            // 
            this.powerBarTimer.Interval = 10;
            this.powerBarTimer.Tick += new System.EventHandler(this.powerBarTimer_Tick);
            // 
            // ballActingTimer
            // 
            this.ballActingTimer.Tick += new System.EventHandler(this.ballActingTimer_Tick);
            // 
            // myPanel
            // 
            this.myPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.myPanel.Controls.Add(this.consoleLabel);
            this.myPanel.Controls.Add(this.ballPic);
            this.myPanel.Controls.Add(this.ringPic);
            this.myPanel.Location = new System.Drawing.Point(11, 50);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(776, 389);
            this.myPanel.TabIndex = 4;
            this.myPanel.Visible = false;
            this.myPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseClick);
            // 
            // consoleLabel
            // 
            this.consoleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consoleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.consoleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.consoleLabel.Location = new System.Drawing.Point(243, 25);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(291, 70);
            this.consoleLabel.TabIndex = 5;
            this.consoleLabel.Text = "...";
            this.consoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.consoleLabel.Visible = false;
            // 
            // hintLabel
            // 
            this.hintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hintLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hintLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hintLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.hintLabel.Location = new System.Drawing.Point(90, 155);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(619, 69);
            this.hintLabel.TabIndex = 4;
            this.hintLabel.Text = "Click button to start!";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ballPic
            // 
            this.ballPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ballPic.Image = global::MyGame_III.Properties.Resources.ball;
            this.ballPic.Location = new System.Drawing.Point(3, 306);
            this.ballPic.Name = "ballPic";
            this.ballPic.Size = new System.Drawing.Size(80, 80);
            this.ballPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballPic.TabIndex = 3;
            this.ballPic.TabStop = false;
            this.ballPic.Visible = false;
            // 
            // ringPic
            // 
            this.ringPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ringPic.Image = global::MyGame_III.Properties.Resources.ring;
            this.ringPic.Location = new System.Drawing.Point(652, 324);
            this.ringPic.Name = "ringPic";
            this.ringPic.Size = new System.Drawing.Size(120, 50);
            this.ringPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ringPic.TabIndex = 2;
            this.ringPic.TabStop = false;
            this.ringPic.Visible = false;
            // 
            // barBack
            // 
            this.barBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barBack.Location = new System.Drawing.Point(126, 11);
            this.barBack.Name = "barBack";
            this.barBack.Size = new System.Drawing.Size(550, 34);
            this.barBack.TabIndex = 5;
            this.barBack.TabStop = false;
            this.barBack.Visible = false;
            // 
            // powerBarPic
            // 
            this.powerBarPic.BackColor = System.Drawing.Color.DarkKhaki;
            this.powerBarPic.Location = new System.Drawing.Point(128, 14);
            this.powerBarPic.MaximumSize = new System.Drawing.Size(545, 29);
            this.powerBarPic.MinimumSize = new System.Drawing.Size(0, 29);
            this.powerBarPic.Name = "powerBarPic";
            this.powerBarPic.Size = new System.Drawing.Size(545, 29);
            this.powerBarPic.TabIndex = 6;
            this.powerBarPic.TabStop = false;
            this.powerBarPic.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.powerBarPic);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.barBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyGame III";
            this.myPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBarPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox ringPic;
        private System.Windows.Forms.PictureBox ballPic;
        private System.Windows.Forms.Timer powerBarTimer;
        private System.Windows.Forms.Timer ballActingTimer;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.PictureBox barBack;
        private System.Windows.Forms.PictureBox powerBarPic;
    }
}

