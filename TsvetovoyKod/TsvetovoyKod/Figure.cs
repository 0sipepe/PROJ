using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsvetovoyKod
{
    internal abstract class Figure
    {
         int x, y, wigth, heigth;
         protected Color lineColor, fillColor;
         protected int mx, my;
         string type;
  

        public Figure(string type, int x, int y, int wigth, int heigth, Color lineColor, Color fillColor)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.wigth = wigth;
            this.heigth = heigth;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
        }
        public Figure (Figure f)
        {
            this.x = f.x;
            this.y = f.y;
            this.wigth= f.wigth;
            this.heigth = f.heigth;
            this.lineColor = f.lineColor;
            this.fillColor = f.fillColor;
        }
        public string Type
        {
            get { return type; }
        }

        public int Wigth
        {
            set { wigth = Convert.ToInt32(value); }
            get { return wigth; }
        }
        public int Heigth
        {
            set { heigth = Convert.ToInt32(value); }
            get { return heigth; }
        }
        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public Color LineColor
        {
            set { lineColor = value; }
            get { return lineColor; }

        }
        public Color FillColor
        {
            set { fillColor = value; }
            get { return fillColor; }

        }
        public virtual void Draw(Graphics gr) { }


     /// <summary>
     /// проверка на попадание в правую грань фигуры
     /// </summary>
     
        public abstract bool IsEditedLeft(int ex, int ey);
        /// <summary>
        /// проверка на попадание в нижнюю грань фигуры
        /// </summary>
       
        public abstract bool IsEditedBottom(int ex, int ey);
        /// <summary>
        /// проверка на попадание в фигуру
        /// </summary>
        
        public abstract bool IsMoved(int ex, int ey);
        /// <summary>
        /// движение фигуры на основе координат мыши
        /// </summary>

        public virtual void Move(int ex, int ey) { }
        /// <summary>
        /// изменение фигуры в зависимости от нижней грани
        /// </summary>
     
        public virtual void EditBottom(int ex, int ey) { }

        /// <summary>
        /// изменение фигуры в зависимости от правой грани
        /// </summary>
    
        public virtual void EditLeft(int ex, int ey) { }
    }
}
