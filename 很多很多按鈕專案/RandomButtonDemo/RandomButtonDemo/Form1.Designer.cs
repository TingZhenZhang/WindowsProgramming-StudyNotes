namespace RandomButtonDemo
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
            this.cardTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.currentSpendLabel = new System.Windows.Forms.Label();
            this.spendTimer = new System.Windows.Forms.Timer(this.components);
            this.cardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cardTimer
            // 
            this.cardTimer.Interval = 1000;
            this.cardTimer.Tick += new System.EventHandler(this.cardTimer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "花費時間：";
            // 
            // currentSpendLabel
            // 
            this.currentSpendLabel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.currentSpendLabel.Location = new System.Drawing.Point(112, 0);
            this.currentSpendLabel.Name = "currentSpendLabel";
            this.currentSpendLabel.Size = new System.Drawing.Size(85, 35);
            this.currentSpendLabel.TabIndex = 1;
            this.currentSpendLabel.Text = "0";
            this.currentSpendLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // spendTimer
            // 
            this.spendTimer.Interval = 1000;
            this.spendTimer.Tick += new System.EventHandler(this.spendTimer_Tick);
            // 
            // cardPanel
            // 
            this.cardPanel.Location = new System.Drawing.Point(12, 38);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(992, 416);
            this.cardPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 466);
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.currentSpendLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "目標是成為一張升級到滿滿星星的R卡... ...呃 沒錯吧？";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer cardTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentSpendLabel;
        private System.Windows.Forms.Timer spendTimer;
        private System.Windows.Forms.Panel cardPanel;
    }
}

