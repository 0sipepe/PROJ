using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsvetovoyKod
{
    internal class Level
    {
        internal static List<Bitmap> levels = new List<Bitmap>();
        int lvl = 0;

      
        public Level(int llevel)
        {
            lvl = llevel;
            Bitmap pic = new Bitmap(1, 1);
            switch (llevel)
            { 
                case 1:
                    pic = new Bitmap(Properties.Resources.квадрат);
                    break;
                case 2:
                    pic = new Bitmap(Properties.Resources.глаз);
                    break;
                case 3:
                    pic = new Bitmap(Properties.Resources.штука1);
                    break;
                case 4:
                    pic = new Bitmap(Properties.Resources.домик);
                    break;
                case 5:
                    pic = new Bitmap(Properties.Resources.штука2);
                    break;
                case 6:
                    pic = new Bitmap(Properties.Resources.гриб);
                    break;
                case 7:
                    pic = new Bitmap(Properties.Resources.котик);
                    break;
                case 8:
                    pic = new Bitmap(Properties.Resources.штука3);
                    break;
                case 9:
                    pic = new Bitmap(Properties.Resources.гномик);
                    break;
                case 10:
                    pic = new Bitmap(Properties.Resources.finish);
                    break;

            }
            Console.WriteLine(pic.Width + "(" + pic.Height);
            levels.Add(pic);
        }
        

        public int GetScore(Bitmap drawing)
        {
            int notEmpty = 0;
            int score = 0;


           // Console.WriteLine(drawing.GetPixel(5, 5));
            for (int i = 1; i < drawing.Width - 1; i++)
            {
                for (int j = 1; j < drawing.Height - 1; j++)
                {
                    if ((this.lvl == 3) || (this.lvl == 8))
                    {
                        if (((drawing.GetPixel(i, j).Equals(levels[this.lvl - 1].GetPixel(i, j))) && 
                            (drawing.GetPixel(i, j) != Color.FromArgb(0, 0, 0, 0) && levels[this.lvl - 1].GetPixel(i, j) == Color.FromArgb(0, 0, 0, 0))))
                        notEmpty++;
                    }
                    if ((drawing.GetPixel(i, j).Equals(levels[this.lvl - 1].GetPixel(i, j))) && 
                        !(drawing.GetPixel(i, j) == Color.FromArgb(0, 0, 0, 0) && levels[this.lvl - 1].GetPixel(i, j) == Color.FromArgb(0, 0, 0, 0)))   score++;
                   
                    if (levels[this.lvl - 1].GetPixel(i, j).A == 255) notEmpty++;
                                                       
                }
            }
                                                                                                                                                                                                                       // Console.WriteLine(score+ "--" + notEmpty);
                                                                                                                                                                                                                        //Console.WriteLine((100 * score )/ notEmpty);
                                                                                                                                                                                                                        //Console.WriteLine(drawing.Width + " " + drawing.Height);
                                                                                                                                                                                                                        //Console.WriteLine(notEmpty);
            
            return (100 * score) / notEmpty;

        }
    }
}
