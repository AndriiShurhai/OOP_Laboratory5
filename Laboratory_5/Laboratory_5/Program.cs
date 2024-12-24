using System;

namespace Laboratory_5
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    namespace GeometricShapes
    {
        public partial class MainForm : Form
        {
            private List<Figure> figures;
            private Button btnMoveCircle;
            private Button btnMoveSquare;
            private Button btnMoveRhomb;
            private Button btnMoveAll;

            public MainForm()
            {
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                this.Size = new Size(800, 600);
                this.BackColor = Color.White;

                btnMoveCircle = new Button
                {
                    Text = "Move Circle",
                    Location = new Point(20, 20),
                    Size = new Size(100, 30)
                };
                btnMoveCircle.Click += BtnMoveCircle_Click;

                btnMoveSquare = new Button
                {
                    Text = "Move Square",
                    Location = new Point(20, 60),
                    Size = new Size(100, 30)
                };
                btnMoveSquare.Click += BtnMoveSquare_Click;

                btnMoveRhomb = new Button
                {
                    Text = "Move Rhomb",
                    Location = new Point(20, 100),
                    Size = new Size(100, 30)
                };
                btnMoveRhomb.Click += BtnMoveRhomb_Click;

                btnMoveAll = new Button
                {
                    Text = "Move All",
                    Location = new Point(20, 140),
                    Size = new Size(100, 30)
                };
                btnMoveAll.Click += BtnMoveAll_Click;

                Controls.AddRange(new Control[] {
                btnMoveCircle, btnMoveSquare, btnMoveRhomb, btnMoveAll
            });
            }

            private void BtnMoveCircle_Click(object sender, EventArgs e)
            {
                Circle circle = new Circle(100, 100, 30);
                circle.MoveRight(this);
            }

            private void BtnMoveSquare_Click(object sender, EventArgs e)
            {
                Square square = new Square(100, 200, 60);
                square.MoveRight(this);
            }

            private void BtnMoveRhomb_Click(object sender, EventArgs e)
            {
                Rhomb rhomb = new Rhomb(100, 300, 80, 80);
                rhomb.MoveRight(this);
            }

            private void BtnMoveAll_Click(object sender, EventArgs e)
            {
                foreach (var figure in new Figure[]{ new Circle(100, 100, 30), new Square(100, 200, 60), new Rhomb(100, 300, 80, 80), })
                {
                    figure.MoveRight(this);
                }
            }
        }

        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}