﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure {
    public partial class Adventure : Form {
        public Adventure() {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e) {
            lblGold.Text = "123";
        }
    }
}
