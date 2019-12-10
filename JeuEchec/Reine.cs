﻿using JeuEchec.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuEchec
{
    class Reine : Piece
    {
        private Image image;
        public Image Image { get => image; set => image = value; }
        public Reine(string color) : base(color)
        {
            if (color == "black")
            {
                image = new Bitmap(Resources.reineN);

            }
            else
            {
                image = new Bitmap(Resources.reineB);
            }
        }

       
    }
}
