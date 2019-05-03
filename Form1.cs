﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode =
             System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen p = new Pen(Color.WhiteSmoke, 1);
            SolidBrush p1 = new SolidBrush(Color.Yellow);
            SolidBrush p2 = new SolidBrush(Color.Black);
            SolidBrush p3= new SolidBrush(Color.Red);
            SolidBrush p4 = new SolidBrush(Color.Purple);
            SolidBrush p5 = new SolidBrush(Color.LemonChiffon);
            SolidBrush p6 = new SolidBrush(Color.Gray);
            SolidBrush p7 = new SolidBrush(Color.Blue);
            SolidBrush p8 = new SolidBrush(Color.Orange);
            SolidBrush p9 = new SolidBrush(Color.Green);
            SolidBrush p10 = new SolidBrush(Color.Bisque);
            SolidBrush p11 = new SolidBrush(Color.White);
            SolidBrush p12 = new SolidBrush(Color.SeaGreen);
            SolidBrush p13 = new SolidBrush(Color.OldLace);
            SolidBrush p14 = new SolidBrush(Color.OliveDrab);

            Point[] P = { new Point(16, 13), new Point(154, 146), new Point(97, 222) };
            Point[] P1 = { new Point(16, 13), new Point(10, 65), new Point(97, 222) };
            Point[] P2 = { new Point(44, 169), new Point(10, 65), new Point(97, 222) };
            Point[] P3 = { new Point(44, 169), new Point(60, 213), new Point(97, 222) };
            Point[] P4 = { new Point(154, 146), new Point(171, 180), new Point(97, 222) };
            Point[] P5 = { new Point(154, 146), new Point(232, 301), new Point(203, 147) };
            Point[] P6 = { new Point(274, 301), new Point(232, 301), new Point(261, 147) };
            Point[] P7 = { new Point(308, 147), new Point(274, 301), new Point(355, 147) };
            Point[] P8 = { new Point(338, 180), new Point(398, 222), new Point(356, 147) };
            Point[] P9 = { new Point(489, 13), new Point(398, 222), new Point(356, 147) };
            Point[] P10 = { new Point(489, 13), new Point(398, 222), new Point(490, 65) };
            Point[] P11 = { new Point(455, 169), new Point(398, 222), new Point(490, 65) };
            Point[] P12 = { new Point(439, 213), new Point(398, 222), new Point(455, 169) };
            Point[] P13 = { new Point(309, 317), new Point(398, 222), new Point(439, 213), new Point(435, 268) };
            Point[] P14 = { new Point(191, 317), new Point(97, 222), new Point(60, 213), new Point(60, 268) };
            Point[] P15 = { new Point(60, 268), new Point(191, 317), new Point(105, 352) };
            Point[] P16 = { new Point(435, 268), new Point(309, 317), new Point(386, 352) };
            Point[] P17 = { new Point(219, 393), new Point(191, 317), new Point(232, 301) };
            Point[] P18 = { new Point(282, 393), new Point(309, 317), new Point(274, 301) };
            Point[] P19 = { new Point(282, 393), new Point(219, 393), new Point(250, 441) };
            Point[] P20 = { new Point(282, 393), new Point(219, 393), new Point(250, 415) };
            Point[] P21 = { new Point(250, 441), new Point(219, 393), new Point(177, 451) };
            Point[] P22 = { new Point(282, 393), new Point(250, 441), new Point(316, 451) };
            Point[] P23 = { new Point(250, 441), new Point(316, 451), new Point(250, 483), new Point(177, 451) };
            Point[] P24 = { new Point(105, 352), new Point(194, 426), new Point(177, 451), new Point(131, 416), new Point(127, 393) };
            Point[] P25 = { new Point(386, 352), new Point(299, 426), new Point(316, 451), new Point(362, 416), new Point(364, 393) };
            g.DrawPolygon(p, P);
            g.DrawPolygon(p, P1);
            g.DrawPolygon(p, P2);
            g.DrawPolygon(p, P3);
            g.DrawPolygon(p, P4);
            g.DrawPolygon(p, P5);
            g.DrawPolygon(p, P6);
            g.DrawPolygon(p, P7);
            g.DrawPolygon(p, P8);
            g.DrawPolygon(p, P9);
            g.DrawPolygon(p, P10);
            g.DrawPolygon(p, P11);
            g.DrawPolygon(p, P12);
            g.DrawLine(p, 203, 147, 355, 147);
            g.DrawPolygon(p, P13);
            g.DrawPolygon(p, P14);
            g.DrawPolygon(p, P15);
            g.DrawPolygon(p, P16);
            g.DrawPolygon(p, P17);
            g.DrawPolygon(p, P18);
            g.DrawPolygon(p, P19);
            g.DrawPolygon(p, P20);
            g.DrawPolygon(p, P21);
            g.DrawPolygon(p, P22);
            g.DrawPolygon(p, P23);
            g.DrawPolygon(p, P24);
            g.DrawPolygon(p, P25);
           
            g.FillPolygon(p4, P);
            g.FillPolygon(p3, P1);
            g.FillPolygon(p7, P2);
            g.FillPolygon(p5, P3);
            g.FillPolygon(p1, P4);
            g.FillPolygon(p2, P5);
            g.FillPolygon(p10, P6);
            g.FillPolygon(p13, P7);
            g.FillPolygon(p12, P8);
            g.FillPolygon(p11, P9);
            g.FillPolygon(p10, P10);
            g.FillPolygon(p9, P11);
            g.FillPolygon(p8, P12);
            g.FillPolygon(p6, P13);
            g.FillPolygon(p5, P14);
            g.FillPolygon(p4, P15);
            g.FillPolygon(p3, P16);
            g.FillPolygon(p7, P17);
            g.FillPolygon(p8, P18);
            g.FillPolygon(p5, P19);
            g.FillPolygon(p7, P20);
            g.FillPolygon(p12, P21);
            g.FillPolygon(p1, P22);
            g.FillPolygon(p2, P23);
            g.FillPolygon(p13, P24);
            g.FillPolygon(p14, P25);

        }
    }
}
