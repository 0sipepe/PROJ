using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsvetovoyKod
{
    internal class Circle : Figure
    {
        public Circle(string type, int x, int y, int wigth, int heigth, Color lineColor, Color fillColor) : base(type, x, y, wigth, heigth, lineColor, fillColor) { }

        public override void Draw(Graphics gr)
        {
            gr.FillEllipse(new SolidBrush(fillColor), this.X, this.Y, this.Wigth, this.Heigth);
            gr.DrawEllipse(new Pen(lineColor), this.X, this.Y, this.Wigth, this.Heigth);
        }
        public Circle(Figure f) : base(f) { }

        public override bool IsMoved(int ex, int ey)
        {
            if (Wigth < 0)
            {
                Wigth = Math.Abs(Wigth);
                X = X - Wigth;
            }
            if (Heigth < 0)
            {
                Heigth = Math.Abs(Heigth);
                Y = Y - Heigth;
            }
            if ((X + 3 * X / 100 < ex && ex < Wigth - 3 * (Wigth + X) / 100 + X) && (Y + 3 * Y / 100 < ey && ey < Heigth - 3 * (Heigth + Y) / 100 + Y))
            {
                mx = ex - X;
                my = ey - Y;
                return true;
            }
            else
            {
                Console.WriteLine("c " + X + " " + Y + " " + ex + " " + ey);
                return false;
            }
        }
        public override bool IsEditedBottom(int ex, int ey)
        {
            if (Wigth < 0)
            {
                Wigth = Math.Abs(Wigth);
                X = X - Wigth;
            }
            if (Heigth < 0)
            {
                Heigth = Math.Abs(Heigth);
                Y = Y - Heigth;
            }
            bool A = (X <= ex && ex <= Wigth + X) && ((Heigth + Y + 5 * Heigth / 100 >= ey) && (Heigth + Y - 2 * Heigth / 100 <= ey));
            //bool B = (Y <= ey && ey <= Heigth + Y) && ((Wigth + X + 5 * Wigth / 100 >= ex) && (Wigth + X - 5 * Wigth / 100 <= ex));

            if (A) return true;
            else return false;

        }
        public override bool IsEditedLeft(int ex, int ey)
        {
            if (Wigth < 0)
            {
                Wigth = Math.Abs(Wigth);
                X = X - Wigth;
            }
            if (Heigth < 0)
            {
                Heigth = Math.Abs(Heigth);
                Y = Y - Heigth;
            }
            bool B = (Y <= ey && ey <= Heigth + Y) && ((Wigth + X + 5 * Wigth / 100 >= ex) && (Wigth + X - 2 * Wigth / 100 <= ex));

            if (B) return true;
            else return false;

        }
        public override void Move(int ex, int ey)
        {

            X = ex - mx;
            Y = ey - my;          

        }
        public override void EditBottom(int ex, int ey) => Heigth = ey - Y;
        public override void EditLeft(int ex, int ey) => Wigth = ex - X;
    }
}