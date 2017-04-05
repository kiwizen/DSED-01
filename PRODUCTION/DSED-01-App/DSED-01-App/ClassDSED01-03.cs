using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    /// <summary>
    /// This file contains a Custom Control Class.
    /// This custom control display message realated to the game
    ///    also contain button for user to press to continue.
    /// </summary>  
    public class MessagePanel : System.Windows.Forms.Panel
    {

        public delegate void DelegateMethod();
        public DelegateMethod CallBackMethod = null;

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.Label _label;

        public MessagePanel()
        {
            CommonControlClass.initialiseLabelControl(out this._label, CommonControlClass.TextFile, 0, 0, 325, 225,11F,
                System.Drawing.ContentAlignment.TopLeft, FixBorder : true);

            _button = new System.Windows.Forms.Button();
            CommonControlClass.initialiseButtonControl(out this._button, "OK", 100, 228, 100, 55);
            this._button.Click += new System.EventHandler(this.OK_Click);


            this.Location = new System.Drawing.Point(200, 95);
            this.Size = new System.Drawing.Size(325, 280);

            this.Controls.Add(this._label);
            this.Controls.Add(this._button);

        }

        public new string Text { set { this._label.Text = value; } }

        private void OK_Click(object sender, EventArgs e)
        {
            this._label.Text = CommonControlClass.TextFile;
            if (CallBackMethod != null) CallBackMethod.Invoke();
        }
    }
}
