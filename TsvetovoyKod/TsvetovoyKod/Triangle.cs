using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsvetovoyKod
{
    internal class Triangle : Figure
    {
        bool A, B;
        public Triangle(string type, int x, int y, int wigth, int heigth, Color lineColor, Color fillColor) : base(type, x, y, wigth, heigth, lineColor, fillColor) { }
        public Triangle(Figure f) : base(f) { }

        public override void Draw(Graphics gr)
        {           
            PointF[] points = new PointF[] { new PointF(X, Y + Heigth), new PointF(X + Wigth / 2, Y), new PointF(X + Wigth, Y + Heigth) };
            gr.FillPolygon(new SolidBrush(fillColor), points);
            gr.DrawPolygon(new Pen(lineColor), points);

        }
        
        public override bool IsEditedBottom(int ex, int ey)
        {
            
            if ((Wigth < 0) && (Heigth < 0)) A = (X + Wigth / 2 + 5 >= ex && ex >= X + Wigth / 2 - 5) && ((Y + 5 >= ey) && (Y - 5 <= ey));
            
            else if ((Wigth > 0) && (Heigth < 0)) A = (X + Wigth / 2 + 5 >= ex && ex >= X + Wigth / 2 - 5) && ((Y + 5 >= ey) && (Y - 5 <= ey));
           
            else if ((Wigth < 0) && (Heigth > 0)) A = (X >= ex && ex >= Wigth + X) && ((Heigth + Y + 5 >= ey) && (Heigth + Y - 5 <= ey));

            else A = (X <= ex && ex <= Wigth + X) && ((Heigth + Y + 6 >= ey) && (Heigth + Y - 5 <= ey));
       
          
            if (A) return true;
            else { A = false; return false; }

        }
        public override bool IsEditedLeft(int ex, int ey)
        {

            if ((Wigth < 0) && (Heigth < 0)) B = (Y + Heigth + 5 >= ey && ey >= Y + Heigth - 5) && ((X + 5 >= ex) && (X - 5 <= ex));
           
            else if ((Wigth > 0) && (Heigth < 0)) B = ((Y + Heigth + 5 >= ey && ey >= Y + Heigth - 5)) && ((Wigth + X + 5 >= ex) && (Wigth + X - 5 <= ex));
         

            else if ((Wigth < 0) && (Heigth > 0))  B = (Y + Heigth + 5 >= ey && ey >= Heigth + Y - 5) && ((X + 5 >= ex) && (X - 5 <= ex));
            else B = (((Y + Heigth + 5 >= ey) && (ey >= Heigth + Y - 5)) && ((Wigth + X + 10 >= ex) && (Wigth + X - 5 <= ex)));
         

            if (B) return true;
            else { B = false; return false; }

        }
        public override bool IsMoved(int ex, int ey)
        {
            if ((Wigth < 0) && (Heigth < 0))
            {
                if ((X - 6 > ex && ex > Wigth + X + 6) && (Y - 6 > ey && ey > Heigth + Y + 6))
                {
                    mx = X - ex;
                    my = Y - ey;
                    //Console.WriteLine($" X {X} Y {Y} ex {ex} ey {ey} mx {mx} my {my}");
                    return true;
                }
                else { return false; }
            }
            else if ((Wigth > 0) && (Heigth < 0))
            {
                if ((X + 6 < ex && ex < Wigth - 6 + X) && (Y - 6 > ey && ey > Heigth + Y + 6))
                {
                    mx = ex - X;
                    my = Y - ey;
                    return true;
                }
                else { return false; }
            }
            else if ((Wigth < 0) && (Heigth > 0))
            {
                if (((X + 6 * X / 100 < ex && ex < Wigth - 6 * (Wigth + X) / 100 + X) && (Y + 6 * Y / 100 < ey && ey < Heigth - 6 * (Heigth + Y) / 100 + Y)))
                {
                    mx = X - ex;
                    my = ey - Y;

                    return true;
                }
                else { return false; }
            }

            else
            {

                if ((X + 6 < ex && ex < Wigth + X - 6) && (Y + 6 < ey && ey < Heigth + Y - 6))
                {
                    mx = ex - X;
                    my = ey - Y;

                    return true;
                }
                else { return false; }

            }


        }
        public override void Move(int ex, int ey)
        {
            if ((Wigth < 0) && (Heigth < 0))
            {
                X = mx  + ex;
                Y = my +  ey;
                //Console.WriteLine($" X {X} Y {Y} ex {ex} ey {ey} mx {mx} my {my}");
            }
            else if ((Wigth < 0) && (Heigth > 0))
            {
                X = mx + ex;
                Y = ey - my;
            }
            else if ((Wigth > 0) && (Heigth < 0))
            {
                X = ex - mx;
                Y = my + ey;
            }
            else
            {
                X = ex - mx;
                Y = ey - my;
            }
        }
        public override void EditBottom(int ex, int ey)
        {
            if ((Wigth < 0) && (Heigth < 0))
            {
                if ((ey - (Y + Heigth)) > 0)
                {
                    int boob = Y;
                    Y = ey;
                    boob -= Y;
                    Heigth += boob;
                }           
            }
            else if ((Wigth < 0) && (Heigth > 0)) { Heigth = ey - Y; }
           
            else if ((Wigth > 0) && (Heigth < 0))
            {
                if ((ey - (Y + Heigth)) > 0)
                {
                    int boob = Y;
                    Y = ey;
                    boob -= Y;
                    Heigth += boob;
                }
            }
            else  { Heigth = ey - Y; }               
        }

        public override void EditLeft(int ex, int ey)
        {
            if ((Wigth < 0) && (Heigth < 0))
            {
             
                int boob = X;
                X = ex;
                boob -= X;
                Wigth += boob;
                
            }
            else if ((Wigth < 0) && (Heigth > 0))
            {
               
                int boob = X;
                X = ex;
                boob -= X;
                Wigth += boob;
                

            }
            else if ((Wigth > 0) && (Heigth < 0))
            {
                { Wigth = ex - X; }
            }
            else
            {
                { Wigth = ex - X;}
            }

        }
    }
}
