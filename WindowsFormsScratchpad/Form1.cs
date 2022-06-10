using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsScratchpad
{
    public partial class SierpinskiForm : Form
    {
        private int maxDepth = 6;


        public SierpinskiForm()
        {
            InitializeComponent();
        }


        private void CoordinatePictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Triangle represented in this way by three points (P,Q,R)
            //          P
            //        /  \
            //       /    \
            //      /      \
            //     /        \
            //   Q  ________  R


            float topPadding = 10;
            float bottomPadding = 10;
            float sidePadding = 10;
            float triangleWidth = g.ClipBounds.Width-sidePadding;
            float triangleHeight = g.ClipBounds.Height-bottomPadding;

            var p = new PointF(g.ClipBounds.Width/2,topPadding);
            var q = new PointF(p.X-triangleWidth/2.0f,triangleHeight);
            var r = new PointF(p.X+triangleWidth/2.0f,triangleHeight);


            g.FillPolygon(Brushes.Black,new []{p,q,r});

            DrawSierpinski(g,p,q,r,0);
        }

        private void DrawSierpinski(Graphics g, PointF p,PointF q,PointF r,int depth)
        {
            if (depth > maxDepth) return;


            g.FillPolygon(Brushes.White, new[]
            {
                MidPoint(q,p),
                MidPoint(r,p),
                MidPoint(q,r)
            });

            DrawSierpinski(g,p, MidPoint(r,p),MidPoint(q,p), depth + 1);
            DrawSierpinski(g, MidPoint(q,p),q,MidPoint(q,r), depth + 1);
            DrawSierpinski(g,MidPoint(p,r),MidPoint(q,r),r,depth+1);
        }

        PointF MidPoint(PointF p, PointF q) => new PointF((p.X + q.X) / 2.0f, (p.Y + q.Y) / 2.0f);

        private void Form1_Resize(object sender, EventArgs e)
        {
            CoordinatePictureBox.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            maxDepth = trackBar1.Value;
            CoordinatePictureBox.Invalidate();
        }
    }

        
}
