using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TrafficMonitoring
{
    public partial class TrafficMonitoring : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int bWidthEllipse,int nHeightEllipse);

        public TrafficMonitoring()
        {
            InitializeComponent();
            #region 控件初始化
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,25,25));
            
            #endregion
        }

        #region 侧边按钮效果
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BraceEffectClick(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button)
            {
                Button btn = (System.Windows.Forms.Button)sender;
                BracePanel.Height = btn.Height;
                BracePanel.Top = btn.Top;
                BracePanel.Left = btn.Left;
                BracePanel.BackColor = Color.FromArgb(46, 51, 73);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BraceEffectLeave(object sender,EventArgs e)
        {
            if (sender is System.Windows.Forms.Button)
            {
                Button btn = (System.Windows.Forms.Button)sender;
                BracePanel.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
        #endregion
    }
}
