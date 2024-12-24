using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_5
{
    class Rhomb : Figure
    {
        private int horDiag;
        private int vertDiag;

        public Rhomb(int x, int y, int horDiag, int vertDiag) : base(x, y)
        {
            this.horDiag = horDiag;
            this.vertDiag = vertDiag;
        }

        public override void DrawBlack(Form Form)
        {
            using (Graphics g = Form.CreateGraphics())
            {
                Point[] points =
                {
                    new Point(centerX - horDiag/2, centerY),
                    new Point(centerX, centerY - vertDiag/2),
                    new Point(centerX + horDiag/2, centerY),
                    new Point(centerX, centerY + vertDiag/2)
                };
                g.DrawPolygon(Pens.Black, points);
            }
        }

        public override void HideDrawingBackground(Form Form)
        {
            using (Graphics g = Form.CreateGraphics())
            {
                Point[] points =
                {
                    new Point(centerX - horDiag/2, centerY),
                    new Point(centerX, centerY - vertDiag/2),
                    new Point(centerX + horDiag/2, centerY),
                    new Point(centerX, centerY + vertDiag/2)
                };
                g.DrawPolygon(new Pen(Form.BackColor), points);
            }
        }
    }
}
