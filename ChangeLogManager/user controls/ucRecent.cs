﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ChangeLogManager.classes;

namespace ChangeLogManager
{
    public partial class ucRecent : UserControl
    {
        public Label title, version, date;
        public string path;
        public DateTime lastEdited;

        public ucRecent()
        {
            InitializeComponent();

            title = lTitle;
            version = lVersion;
            date = lDate;
        }

        private void lDate_MouseEnter(object sender, EventArgs e)
        {
            ucRecent_MouseEnter(this, e);
        }

        private void lDate_MouseLeave(object sender, EventArgs e)
        {
            ucRecent_MouseLeave(this, e);
        }

        private void ucRecent_Click(object sender, EventArgs e)
        {
            cLog.OpenLog(this.ParentForm, true, this.path);
        }

        private void lDate_Click(object sender, EventArgs e)
        {
            ucRecent_Click(this, e);
        }

        private void lClose_MouseEnter(object sender, EventArgs e)
        {
            this.lClose.ForeColor = Color.DimGray;
            this.BackColor = Color.Silver;
        }

        private void lClose_MouseLeave(object sender, EventArgs e)
        {
            this.lClose.ForeColor = Color.Gainsboro;
            ucRecent_MouseLeave(sender, e);
        }

        private void lClose_Click(object sender, EventArgs e)
        {
            if(this.lClose.ForeColor != SystemColors.ScrollBar)
                cLog.RemoveLogFromRecent(this.path);
        }

        private void ucRecent_MouseEnter(object sender, EventArgs e)
        {
            this.lClose.ForeColor = Color.Gainsboro;
            this.BackColor = Color.Silver;
        }

        private void ucRecent_MouseLeave(object sender, EventArgs e)
        {
            this.lClose.ForeColor = SystemColors.ScrollBar;
            this.BackColor = SystemColors.ScrollBar;
        }
    }
}
