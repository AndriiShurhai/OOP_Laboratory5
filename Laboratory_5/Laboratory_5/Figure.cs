using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_5
{
    abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        public Figure(int x, int y)
        {
            this.centerX = x;
            this.centerY = y;
        }

        public abstract void DrawBlack(Form Form);
        public abstract void HideDrawingBackground(Form Form);

        public void MoveRight(Form form)
        {
            while (centerX < form.Width - 50)
            {
                DrawBlack(form);
                System.Threading.Thread.Sleep(50);
                HideDrawingBackground(form);
                centerX += 50;
            }
        }
    }
}
