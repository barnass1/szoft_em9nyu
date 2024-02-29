using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzamoloGomb : Button
    {
        int szám = 1;
        public SzamoloGomb() 
        {
            Text = szám.ToString();
            MouseClick += SzamoloGomb_MouseClick;

        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szám++;
            if (szám == 6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
