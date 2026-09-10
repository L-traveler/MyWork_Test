using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest9_8
{
    internal class LabelAndTimer
    {
        public Label lab { get; set; }
        public System.Windows.Forms.Timer labTimer;

        public LabelAndTimer(Label lab, System.Windows.Forms.Timer labTimer)
        {
            this.lab = lab;
            this.labTimer = labTimer;
        }
    }
}
