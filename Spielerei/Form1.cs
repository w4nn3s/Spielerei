﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielerei
{
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();
        }

        private void btnRijtjes_Click(object sender, EventArgs e)
        {
            Rijtjes rijtjes = new Rijtjes();
            rijtjes.ShowDialog();
        }
    }
}
