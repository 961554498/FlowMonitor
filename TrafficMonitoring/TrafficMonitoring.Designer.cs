namespace TrafficMonitoring
{
    partial class TrafficMonitoring
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficMonitoring));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BracePanel = new System.Windows.Forms.Panel();
            this.RealTimebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BracePanel);
            this.panel1.Controls.Add(this.RealTimebtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // BracePanel
            // 
            this.BracePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BracePanel.Location = new System.Drawing.Point(0, 193);
            this.BracePanel.Name = "BracePanel";
            this.BracePanel.Size = new System.Drawing.Size(3, 100);
            this.BracePanel.TabIndex = 2;
            // 
            // RealTimebtn
            // 
            this.RealTimebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RealTimebtn.FlatAppearance.BorderSize = 0;
            this.RealTimebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RealTimebtn.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.RealTimebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RealTimebtn.Image = global::TrafficMonitoring.Properties.Resources.rs_icon_n;
            this.RealTimebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealTimebtn.Location = new System.Drawing.Point(0, 144);
            this.RealTimebtn.Name = "RealTimebtn";
            this.RealTimebtn.Size = new System.Drawing.Size(186, 46);
            this.RealTimebtn.TabIndex = 1;
            this.RealTimebtn.Text = "实时";
            this.RealTimebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RealTimebtn.UseVisualStyleBackColor = true;
            this.RealTimebtn.Click += new System.EventHandler(this.BraceEffectClick);
            this.RealTimebtn.Leave += new System.EventHandler(this.BraceEffectLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(186, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 528);
            this.panel3.TabIndex = 1;
            // 
            // TrafficMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrafficMonitoring";
            this.Text = "流量监控";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RealTimebtn;
        private System.Windows.Forms.Panel BracePanel;
        private System.Windows.Forms.Panel panel3;
    }
}

