// Copyright © 2010-2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.Windows.Forms;
using CefSharp.MinimalExample.WinForms.Controls;
using CefSharp.WinForms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserForm : Form
    {
        private readonly ChromiumWebBrowser browser;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        public BrowserForm()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Skins//wolf_kill.ssk";
            Text = "狼人传说";
            //WindowState = FormWindowState.Maximized;
            Size = new System.Drawing.Size(1019, 624);

            browser = new ChromiumWebBrowser("http://121.40.64.66:8081/Web/login.php")
            {
                Dock = DockStyle.Fill,

            };
            browser.AddressChanged += AddressChangedHandler;
            Control.CheckForIllegalCrossThreadCalls = false;
            toolStripContainer.ContentPanel.Controls.Add(browser);
        }

        // 地址变化回调函数
        void AddressChangedHandler(object sender, AddressChangedEventArgs e)
        {
            int result = String.Compare("http://121.40.64.66:8081/Web/login.php", browser.Address);

            if (result != 0)  // 不是登陆
            {
                Size = new System.Drawing.Size(1019, 1019);
                Control shunwang = Controls.Find("shunwang", true)[0];
                shunwang.Visible = false;
            }
        }

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
            }
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void shunwang_Click(object sender, EventArgs e)
        {

        }
    }
}
