using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombInBoxApp
{
    public partial class PanelMessage : System.Windows.Forms.Panel
    {
        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.Label _label;

        public PanelMessage()
        {
            _label = new System.Windows.Forms.Label();
            _label.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _label.Location = new System.Drawing.Point(0, 0);
            _label.Size = new System.Drawing.Size(325, 225);
            _label.Text = "This is a test Message";
            _label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            _button = new System.Windows.Forms.Button();
            FormBoxInBox.initialiseButtonControl(out this._button, "OK", 100, 228, 100, 55);

            this.Location = new System.Drawing.Point(200,95);
            this.Size = new System.Drawing.Size(325, 300);
            //this.Width = 250;
            //this.Height = 300;
            //this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this._label);
            this.Controls.Add(this._button);
            //this.ResumeLayout(false);
        }
    }
}
