﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SebWindowsClient.ConfigurationUtils;
using SebWindowsClient.ProcessUtils;
using SebWindowsClient.Properties;
using SebWindowsClient.XULRunnerCommunication;


namespace SebWindowsClient.UI
{
    public class SEBReloadBrowserToolStripButton : SEBToolStripButton
    {
        public SEBReloadBrowserToolStripButton()
        {
            this.ToolTipText = SEBUIStrings.reloadPage;
            base.Image = (Bitmap)Resources.ResourceManager.GetObject("reload");
            this.BackColor = Color.White;
            this.Alignment = ToolStripItemAlignment.Right;
        }

        protected override void OnClick(EventArgs e)
        {
            try
            {
                SEBWindowHandler.BringWindowToTop(
                    SEBWindowHandler.GetOpenWindows()
                        .First(w => w.Key.GetProcess().GetExecutableName().Contains("firefox")).Key);
            }
            catch { }
        }
    }
}
