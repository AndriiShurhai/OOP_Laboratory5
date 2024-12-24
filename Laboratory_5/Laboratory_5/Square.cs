using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_5
{
    class Square : Figure
    {
        private int sideLength;

        public Square(int x, int y, int side) : base(x, y) 
        {
            this.sideLength = side; 
        }

        public override void DrawBlack(Form Form)
        {
            using (Graphics g = Form.CreateGraphics())
            {
                g.DrawRectangle(Pens.Black, centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
            }
        }
        public override void HideDrawingBackground(Form Form)
        {
            using (Graphics g = Form.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Form.BackColor), centerX - sideLength / 2, centerY - sideLength / 2, sideLength, sideLength);
            }
        }
    }
}
