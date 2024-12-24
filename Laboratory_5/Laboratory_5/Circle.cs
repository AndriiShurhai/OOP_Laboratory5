using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_5
{
    class Circle : Figure
    {
        private int radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void DrawBlack(Form Form)
        {
            using (Graphics g = Form.CreateGraphics())
            {
                g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius*2, radius*2);
            }
        }

        public override void HideDrawingBackground(Form Form)
        {
            using (Graphics g = Form.CreateGraphics())
            {
                g.DrawEllipse(new Pen(Form.BackColor), centerX - radius, centerY - radius, radius * 2, radius * 2);
            }
        }
    }
}
