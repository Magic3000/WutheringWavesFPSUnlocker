using WutheringWavesFPSUnlocker.Properties;

namespace WutheringWavesFPSUnlocker
{
    partial class WWFpsUnlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WWFpsUnlocker));
            this.fpsHsb = new System.Windows.Forms.HScrollBar();
            this.fpsLbl = new System.Windows.Forms.Label();
            this.setFpsBtn = new System.Windows.Forms.Button();
            this.gamePathlbl = new System.Windows.Forms.Label();
            this.selectGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fpsHsb
            // 
            this.fpsHsb.Location = new System.Drawing.Point(212, 92);
            this.fpsHsb.Maximum = 249;
            this.fpsHsb.Minimum = 20;
            this.fpsHsb.Name = "fpsHsb";
            this.fpsHsb.Size = new System.Drawing.Size(420, 26);
            this.fpsHsb.TabIndex = 0;
            this.fpsHsb.Value = 20;
            this.fpsHsb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fpsHsb_Scroll);
            // 
            // fpsLbl
            // 
            this.fpsLbl.AutoSize = true;
            this.fpsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fpsLbl.Location = new System.Drawing.Point(12, 86);
            this.fpsLbl.Name = "fpsLbl";
            this.fpsLbl.Size = new System.Drawing.Size(77, 32);
            this.fpsLbl.TabIndex = 1;
            this.fpsLbl.Text = "FPS:";
            // 
            // setFpsBtn
            // 
            this.setFpsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setFpsBtn.Location = new System.Drawing.Point(12, 121);
            this.setFpsBtn.Name = "setFpsBtn";
            this.setFpsBtn.Size = new System.Drawing.Size(129, 56);
            this.setFpsBtn.TabIndex = 2;
            this.setFpsBtn.Text = "Set FPS";
            this.setFpsBtn.UseVisualStyleBackColor = true;
            this.setFpsBtn.Click += new System.EventHandler(this.setFpsBtn_Click);
            // 
            // gamePathlbl
            // 
            this.gamePathlbl.AutoSize = true;
            this.gamePathlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamePathlbl.Location = new System.Drawing.Point(12, 9);
            this.gamePathlbl.Name = "gamePathlbl";
            this.gamePathlbl.Size = new System.Drawing.Size(178, 32);
            this.gamePathlbl.TabIndex = 3;
            this.gamePathlbl.Text = "Game folder:";
            // 
            // selectGameBtn
            // 
            this.selectGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectGameBtn.Location = new System.Drawing.Point(147, 121);
            this.selectGameBtn.Name = "selectGameBtn";
            this.selectGameBtn.Size = new System.Drawing.Size(189, 56);
            this.selectGameBtn.TabIndex = 4;
            this.selectGameBtn.Text = "Select game";
            this.selectGameBtn.UseVisualStyleBackColor = true;
            this.selectGameBtn.Click += new System.EventHandler(this.selectGameBtn_Click);
            // 
            // WWFpsUnlocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectGameBtn);
            this.Controls.Add(this.gamePathlbl);
            this.Controls.Add(this.setFpsBtn);
            this.Controls.Add(this.fpsLbl);
            this.Controls.Add(this.fpsHsb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WWFpsUnlocker";
            this.Text = "Wuthering Waves FPS Unlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar fpsHsb;
        private System.Windows.Forms.Label fpsLbl;
        private System.Windows.Forms.Button setFpsBtn;
        private System.Windows.Forms.Label gamePathlbl;
        private System.Windows.Forms.Button selectGameBtn;
    }
}

