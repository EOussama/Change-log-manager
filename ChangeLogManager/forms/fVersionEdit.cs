﻿using System;
using System.Windows.Forms;

namespace ChangeLogManager.forms
{
    public partial class fVersionEdit : Form
    {
        // Form -------------------------------------------------------------------------
        public fVersionEdit()
        {
            InitializeComponent();
        }


        // Textbox ----------------------------------------------------------------------
        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            checkInput();
        }


        // Button -----------------------------------------------------------------------
        private void checkInput()
        {
            bEdit.Enabled = tbEdit.Text.Length > 0 ? true : false;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            fMain.changelogVersion.Text = "Version " + tbEdit.Text.Trim();
            this.Close();
        }
    }
}
