using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_01_App
{
    /// <summary>
    /// This file contains a Custom Control Class.
    /// This custom control class display message to the user
    ///    and a OK button for user to click to continue.
    /// </summary>  
    public class MessagePanel : System.Windows.Forms.Panel
    {

        public delegate void DelegateMethod();
        public DelegateMethod CallBackMethod = null;

        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.Label _label;

        public MessagePanel()
        {
            CommonControlClass.initialiseLabelControl(out this._label, CommonControlClass.TextFile, 
                0, 0, 325, 225, 12F,
                System.Drawing.ContentAlignment.TopLeft, FixBorder: true);

            CommonControlClass.initialiseButtonControl(out this._button, "OK", 100, 228, 100, 55);
            _button.Click += new System.EventHandler(this.OK_Click);


            this.Location = new System.Drawing.Point(200, 95);
            this.Size = new System.Drawing.Size(325, 280);
            this.Controls.Add(this._label);
            this.Controls.Add(this._button);

        }

        private void OK_Click(object sender, EventArgs e)
        {
            ShowGameRule();
            if (CallBackMethod != null) CallBackMethod.Invoke();
        }

        public void ShowMessage(string text)
        {
            setMessage(text, 14, System.Drawing.ContentAlignment.MiddleCenter);
            this.Enabled = true;
        }

        public void ShowGameRule()
        {
            setMessage(CommonControlClass.TextFile, 12, System.Drawing.ContentAlignment.TopLeft);
        }

        private void setMessage(string text, int font_size, System.Drawing.ContentAlignment textalign)
        {
            _label.Text = text;
            _label.Font = new System.Drawing.Font("Papyrus", font_size);
            _label.TextAlign = textalign;
        }
    }
}
