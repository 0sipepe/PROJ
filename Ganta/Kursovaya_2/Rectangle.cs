using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_2
{
    public class Rectangle
    {
        public int x;
        public int y;
        public float width;
        public float height;
        Color color;

        public Rectangle(int x, int y, float width, float height, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
            
        }
        public  void Draw(Graphics gr)
        {
            PointF[] points = new PointF[] { new PointF(x, y), new PointF(x + width, y), new PointF(x + width, y + height), new PointF(x, y + height) };
            gr.FillPolygon(new SolidBrush(color), points);
            
        }


    }
}
