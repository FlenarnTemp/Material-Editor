﻿using System;
using System.Windows.Forms;

namespace Material_Editor
{
    public partial class CheckControl : CustomControl
    {
        public CheckControl(string label, Action<CustomControl> changedCallback, bool initialChecked = false)
        {
            InitializeComponent();

            lbLabel.Text = label;
            check.Checked = initialChecked;
            ChangedCallback = changedCallback;
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            RunChangedCallback();
        }

        public override object GetProperty()
        {
            return check.Checked;
        }
    }
}
