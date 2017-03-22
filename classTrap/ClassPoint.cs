﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classTrap
{
    internal abstract class ClassPoint
    {
        public const int countPoints = 4;
        public Point[] points;
        public abstract void setPoints();
    }

    class Trap : ClassPoint
    {
        public override void setPoints()
        {
            points = new Point[countPoints];
            points[0].X = 0;
            points[0].Y = 50;
            points[1].X = 0;
            points[1].Y = 100;
            points[2].X = 100;
            points[2].Y = 150;
            points[3].X = 100;
            points[3].Y = 0;
        }
        public void Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillPolygon(new SolidBrush(Color.Aqua), points);
        }
    }

    class Chetur : ClassPoint
    {
        private float far = 0;
        public override void setPoints()
        {
            points = new Point[countPoints];
        }
        public void Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawPolygon(new Pen(Color.Black,2),points );// FillPolygon(new SolidBrush(Color.Aqua), points);
        }
        public void Pouring(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillPolygon(new SolidBrush(Color.Aqua), points);
        }
        public void Rotate(object sender, PaintEventArgs e)
        {
            far += 30;
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            e.Graphics.RotateTransform(far);
            e.Graphics.TranslateTransform(100.0F, 0.0F);
            g.DrawPolygon(new Pen(Color.Black, 2), points);
        }
        public void Clear(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
        }
    }
}
