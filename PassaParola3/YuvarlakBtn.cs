﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
namespace PassaParola3
{
     public class YuvarlakBtn:Button
    {
        

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(new System.Drawing.Rectangle(new System.Drawing.Point(), this.Size));
                this.Region = new System.Drawing.Region(gp);
                FlatStyle = FlatStyle.Flat;
                FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = Color.White;
              //  this.BackColor = Color.White;

            

        }
    }
}
