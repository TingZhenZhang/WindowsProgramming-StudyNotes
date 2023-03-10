
namespace DesktopPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.petLabel = new System.Windows.Forms.Label();
            this.movingTimer = new System.Windows.Forms.Timer(this.components);
            this.petNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // gravityTimer
            // 
            this.gravityTimer.Enabled = true;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // petLabel
            // 
            this.petLabel.Image = global::DesktopPet.Properties.Resources.gifman_drag_small;
            this.petLabel.Location = new System.Drawing.Point(125, 70);
            this.petLabel.Name = "petLabel";
            this.petLabel.Size = new System.Drawing.Size(125, 125);
            this.petLabel.TabIndex = 0;
            this.petLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petLabel_MouseDown);
            this.petLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.petLabel_MouseMove);
            this.petLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.petLabel_MouseUp);
            // 
            // movingTimer
            // 
            this.movingTimer.Tick += new System.EventHandler(this.movingTimer_Tick);
            // 
            // petNotifyIcon
            // 
            this.petNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("petNotifyIcon.Icon")));
            this.petNotifyIcon.Text = "DesktopPet";
            this.petNotifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 384);
            this.Controls.Add(this.petLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label petLabel;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.Timer movingTimer;
        private System.Windows.Forms.NotifyIcon petNotifyIcon;
    }
}

