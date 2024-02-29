using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class Szines : Button
    {
        public Szines() 
        {
            MouseClick += Szines_MouseClick; ;
        }

        private void Szines_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
