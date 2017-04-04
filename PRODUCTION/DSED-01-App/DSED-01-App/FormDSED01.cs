﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_01_App
{
    public partial class FormDSED01 : Form
    {
        // A User defined Class to store all dependent variable related to the Game Form
        private CommonControlClass _myCommonClass;

        public FormDSED01()
        {
            // Initialize a user defined class object
            _myCommonClass = new CommonControlClass();

            // Default method call to initialize component
            InitializeComponent();

            // Initialize screen control object
            InitializeGameScreenLayout();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

