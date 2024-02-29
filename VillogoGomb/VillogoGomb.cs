using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class VillogoGomb : Button
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public VillogoGomb() 
        {
            BackColor = Color.Yellow;
            MouseEnter += VillogoGomb_MouseEnter;
            // MouseLeave += VillogoGomb_MouseLeave;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
            timer.Stop();
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
            timer.Interval = 1000;
            timer.Start();
        }
    }
}
