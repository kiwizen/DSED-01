using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombInBoxApp
{
    public partial class FormBoxInBox : Form
    {

        public FormBoxInBox()
        {        
            InitializeComponent();
            setupFormBoxInBox();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
