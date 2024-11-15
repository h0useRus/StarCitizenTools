// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = AssemblyHelpers.GetProduct() + " " + AssemblyHelpers.GetFileVersion();
        }
    }
}
