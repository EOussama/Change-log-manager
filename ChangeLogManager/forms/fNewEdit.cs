﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLogManager.forms
{
    public partial class fNewEdit : Form
    {
        // Form ------------------------------------------------------------------------
        public fNewEdit(string textToEdit)
        {
            InitializeComponent();
            tbEdit.Text = textToEdit;
        }


        // Textbox ---------------------------------------------------------------------
        private void tbEdit_TextChanged(object sender, EventArgs e)
        {
            bEdit.Enabled = (tbEdit.Text.Length > 0);
        }

        private void tbEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                bEdit_Click(sender, e);
        }


        // Button ----------------------------------------------------------------------
        private void bEdit_Click(object sender, EventArgs e)
        {
            fMain.newFeatures.Items[fMain.newFeatures.SelectedIndex] = tbEdit.Text;
            fMain.UpdateStatusStrip("Entry edited");
            this.Close();
        }
    }
}
