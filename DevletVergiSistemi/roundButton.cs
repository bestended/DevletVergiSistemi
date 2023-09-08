using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevletVergiSistemi
{
    class roundButton:Button
    {


        protected override void OnPaint(PaintEventArgs pevent)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gp);


            base.OnPaint(pevent);

            //base.OnPaint(pevent);
            //GraphicsPath gp = new GraphicsPath();
            //Rectangle rec = new Rectangle(Point.Empty,this.Size);
            //gp.AddEllipse(rec);
            //Region = new Region(gp);

        }



    }
}
