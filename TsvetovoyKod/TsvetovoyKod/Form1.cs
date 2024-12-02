using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TsvetovoyKod
{
    public partial class Form1 : Form
    {
        Graphics gr, grbit;   //объекты Graphics, отвечающие за рисование на PictureBox и Bitmap-дубликате соотвественно
        List<Figure> figures = new List<Figure>();                            //список нарисованных пользователем фигур
        Color lineColor, fillColor = Color.Black;                        // цвета контура и заливки фигуры соотвествнно
        bool draw, edit1, edit2, move, selected;        //флаги, показывающие, в какой момент пользователь рисует фигуру,
                                                        //редактирует нижнюю грань, правую грань, двигает фигуру и 
                                                        //взаимодействует с фигурой (нужно для удаление одной фигуры)
        bool drawingMode = true;                                                               //отвечает за режим игры
        string type;                                                                   //отвечает за тип рисуемой фигуры
        int num_of_edited = -1;                      //индекс фигуры, взаимодействующей с пользователем, в списке фигур
        int levelNum =  0;                                                                               //номер уровня
        List <Level> levels = new List<Level>();                                                       //список уровней 
        Bitmap bit;                         //Bitmap, дублирующий всю графику пользователя, нужен для сравнения пискелей
        Figure copy;        //фигура, копирующая фигуру, которую пользователь изменяет. Нужно для отката изменения назад
        int tmpScore;                                            //промежуточный счёт, нужный для перепрохождения уровня



        public Form1()
        {
            InitializeComponent();
            bit = new Bitmap(pbDrawing.Width, pbDrawing.Height);   //создание дублирующего битмапа
            gr = pbDrawing.CreateGraphics();
            grbit = Graphics.FromImage(bit);
            pbDrawing.BackColor = (Color.White);

            for (int i = 0; i < 20; i++)
            {
                if (this.Controls[i] is Label lb) { lb.BackColor = Color.FromArgb(0, 0, 0, 0); }
                if (this.Controls[i] is Button bt) { bt.BackColor = Color.Plum; }
                
            }
            btnCircle.BackColor = Color.Fuchsia;
            for (int  i  = 1; i <= 10; i++)
            {
                Level lev = new Level(i);
                levels.Add(lev);
 
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            if (drawingMode)
                    if (cdLine.ShowDialog() == DialogResult.OK)
                    {
                        lineColor = cdLine.Color;
                        btnLine.BackColor = lineColor;
                    }
            else
                {
                    if (cdLine.ShowDialog() == DialogResult.OK)
                    {
                        figures[num_of_edited].LineColor = cdLine.Color;
                        Redraw(); RedrawBit();
                        btnLine.BackColor = figures[num_of_edited].LineColor;
                    }
                }
        }

        private void pbDrawing_MouseMove(object sender, MouseEventArgs e)
        {

            if (drawingMode) { if (draw) Drawing(e.X, e.Y); }     // если включен режим рисования, то отрисовываем фигуру (метод снизу)
            else
            //если не рисуем, то редактируем
            {

                if (move) {  figures[num_of_edited].Move(e.X, e.Y); Redraw();   }
                else if (edit1) { figures[num_of_edited].EditBottom(e.X, e.Y); Redraw();  }
                else if (edit2) { figures[num_of_edited].EditLeft(e.X, e.Y); Redraw(); }
            }
        }

        private void pbDrawing_MouseUp(object sender, MouseEventArgs e)
        {
 
            if (drawingMode)
            {
                if (draw)
                {
                    Drawing(e.X, e.Y);
                    figures[figures.Count - 1].Draw(grbit);
                    draw = false;
                }
            }
            else
            {
                if (move) { figures[num_of_edited].Move(e.X, e.Y); move = false; Redraw(); RedrawBit();}
                else if (edit1) { figures[num_of_edited].EditBottom(e.X, e.Y); edit1 = false; Redraw(); RedrawBit();  }
                else if (edit2) { figures[num_of_edited].EditLeft(e.X, e.Y); edit2 = false; Redraw(); RedrawBit(); }
                //Console.WriteLine(copy.Heigth);
            }
        }

        
       
        private void btnMode_Click(object sender, EventArgs e)
        {
            if (drawingMode == true) 
            {
                btnMode.Text = "редактирование";
                drawingMode = false;
            }
            else
            {
                btnMode.Text = "рисование";
                drawingMode = true;
            }
        }

        private void pbDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;         
            if (drawingMode == true)
            {
                draw = true;
                Figure figure;
                switch (type)
                {
                    case "rect":
                        figure = new Rectangle("r", x, y, 0, 0, fillColor, lineColor);
                        break;
                    case "tria":
                        figure = new Triangle("t", x, y, 0, 0, fillColor, lineColor);
                        break;
                    default:
                        figure = new Circle("c", x, y, 0, 0, fillColor, lineColor);
                        break;
                }
                figures.Add(figure);
                figure.Draw(gr);
            }
            else
            {
                for (int i = figures.Count - 1; i >= 0; i--)
                {
                    move = figures[i].IsMoved(x, y);
                    if (figures[i].IsEditedBottom(x, y)) {
                        edit1 = true;
                        edit2 = false;
                    }                                        //проверяем, попали ли в редактирование снизу      
                    if (figures[i].IsEditedLeft(x, y))
                    {
                        edit2 = true;
                        edit1 = false;
                    }                                        //проверка на редактирование справа
                         
                    if (edit1 || edit2 || move)
                    {
                        selected = true;
                        num_of_edited = i;
                        Console.WriteLine(i);
                        copy  = MakeFigure(figures[num_of_edited].Type, figures[num_of_edited]);
                        break;
                    }
                    else
                    {
                        selected = false;
                        copy = null;
                    }
                }
            }

        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (drawingMode) {
                if (cdFill.ShowDialog() == DialogResult.OK)        //цвет заливки
                {
                    fillColor = cdFill.Color;
                    btnFill.BackColor = fillColor;
                }
            }
            else       //цвет заливки
            {
                if (cdFill.ShowDialog() == DialogResult.OK)
                {
                    figures[num_of_edited].FillColor = cdFill.Color;
                    Redraw(); RedrawBit();
                    btnFill.BackColor = figures[num_of_edited].FillColor;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            copy = null;
            if (drawingMode)
            {
                gr.Clear(pbDrawing.BackColor);
                grbit.Clear(pbDrawing.BackColor);
                
                figures.Clear();
            }
            else
            {
                if (selected)
                {
                    figures.Remove(figures[num_of_edited]);
                    Redraw();
                    RedrawBit();
                    selected = false;

                }
            }
        }
        private void btnStepBack_Click(object sender, EventArgs e)
        {

            if (drawingMode)
            {
                if (figures.Count > 0)
                {
                    figures.Remove(figures[figures.Count - 1]);
                    Redraw();
                    RedrawBit();
                }
            }

            else
            {
                 figures[num_of_edited] = MakeFigure(figures[num_of_edited].Type, copy);
                Redraw();
                RedrawBit();
                Console.WriteLine(copy.Heigth);
            }

        }

        private void btnLevel_Click(object sender, EventArgs e)                  //уровень вперед
        {

            if (levelNum < 10)
            {
                levelNum++;
                pbTask.Image = Level.levels[levelNum - 1];
                labelLevel.Text = levelNum.ToString();
                tmpScore = 0;
                gr.Clear(pbDrawing.BackColor);
                grbit.Clear(pbDrawing.BackColor);
                figures.Clear();
                btnFill.BackColor = Color.Plum;
                btnLine.BackColor = Color.Plum;
            }
        }
        private void btnLevelDown_Click(object sender, EventArgs e)           //уровень назад
        {

            if (levelNum > 1)
            {
                levelNum -= 1;
                pbTask.Image = Level.levels[levelNum - 1];
                labelLevel.Text = levelNum.ToString();
                btnFill.BackColor = Color.Plum;
                btnLine.BackColor = Color.Plum;
            }

        }
        private void btnCheckResult_Click(object sender, EventArgs e)
        {
            Form6.currentUser.Score -= tmpScore;
            int score = levels[levelNum - 1].GetScore(bit);
            tmpScore = score;
            Console.WriteLine(score + "sc");

            if (score > tmpScore) Form6.currentUser.Score += score;
            else Form6.currentUser.Score += tmpScore;
            labelScorePlay.Text = Form6.currentUser.Score.ToString();

            string text;
            if (score % 10 == 1) text = $"Ваш счёт за уровень: {score} очко";
            else if (score % 10 < 5 & score % 10 > 1) text = $"Ваш счёт за уровень: {score} очка!";
            else text = $"Ваш счёт за уровень: {score} очков!";
            MessageBox.Show(text);

            FileHandler.ToFile();
        }


        private void pbTask_Click(object sender, EventArgs e)
        {
            if ((levelNum == 10))
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите начать заново?\n Ваши результаты обнулятся", "Внимание!", MessageBoxButtons.YesNo);
                if ((dialogResult == DialogResult.Yes))
                { 
                    levelNum = 1;
                    pbTask.Image = Level.levels[levelNum - 1];
                    Form6.currentUser.Score = 0;
                    labelScorePlay.Text = Form6.currentUser.Score.ToString();
                    labelLevel.Text = levelNum.ToString();
                    copy = null;

                    gr.Clear(pbDrawing.BackColor);
                    grbit.Clear(pbDrawing.BackColor);

                    figures.Clear();
                }
            }
        }
        private void btnRectangle_Click(object sender, EventArgs e) { type = "rect"; btnCircle.BackColor = btnTriangle.BackColor = Color.Plum;  btnRectangle.BackColor = Color.Fuchsia; }

        private void btnTriangle_Click(object sender, EventArgs e) { type = "tria"; btnTriangle.BackColor  = Color.Fuchsia; btnCircle.BackColor = btnRectangle.BackColor =  Color.Plum; }

        
        private void btnInstriction_Click(object sender, EventArgs e)
        {
            Form4 Instruction = new Form4();
            Instruction.Show();
        }

     
        private void btnBackFromDrawing_Click(object sender, EventArgs e)      
        {
            Form6 MainScreen = new Form6();
            this.Visible = false;
            MainScreen.Show();
        }

      

        private void btnCircle_Click(object sender, EventArgs e) { type = "circle"; btnCircle.BackColor = Color.Fuchsia; btnTriangle.BackColor = btnRectangle.BackColor = Color.Plum; }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(DataBank.ExactUser + "djwhbdjwhb");

            levelNum = 1;
            DoubleBuffered = true;
            Redraw();
            labelUserPlay.Text = Form6.currentUser.Name;
            labelScorePlay.Text = Form6.currentUser.Score.ToString() ;
            labelLevel.Text = levelNum.ToString();
            bit.MakeTransparent();
            
            pbTask.Image = Level.levels[levelNum - 1];
        }
        private void pbDrawing_Paint(object sender, PaintEventArgs e) => Redraw();

        /// <summary>
        /// стираем все фигуры и рисуем их заново (относительно графикса, привязанного к PictureBox)
        /// </summary>
        private void Redraw()
        {
            gr.Clear(pbDrawing.BackColor);
            foreach (Figure figur in figures)
            {
                figur.Draw(gr);
                pbTask.Image = Level.levels[levelNum - 1];
            }           
        }
        /// <summary>
        /// редактирование размер фигуры и ее отрисовка
        /// </summary>   
        private void Drawing(int mx, int my)
        {
            figures[figures.Count - 1].Wigth = mx - figures[figures.Count - 1].X;
            figures[figures.Count - 1].Heigth = my - figures[figures.Count - 1].Y;
         
            Redraw();         
        }
        /// <summary>
        /// стираем все фигуры и рисуем их заново (относительно графикса, привязанного к битмапу)
        /// </summary>

        private void RedrawBit()
        {
            grbit.Clear(pbDrawing.BackColor);
            foreach (Figure f in figures) { f.Draw(grbit); }
        }
        internal Figure MakeFigure(string ttype, Figure ccopy)
        {
            Figure fig;
            switch (ttype)
            {
                case "r":
                    fig = new Rectangle(ccopy);
                    break;
                case "t":
                    fig = new Triangle(ccopy);
                    break;
                default:
                    fig = new Circle(ccopy);
                    break;
            }
            return fig;
        }
    }
}
