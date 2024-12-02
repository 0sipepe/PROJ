using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_2
{
    public partial class form2 : Form
    {
        List<Rectangle> rect = new List<Rectangle>();
        Graphics gr, gr1;

        public form2()
        {
            
            InitializeComponent();
            gr1 = this.CreateGraphics();
            gr = pnGanta.CreateGraphics();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            int x = 5;
            int y = 5;

            try
            {
                rect = Form4.plan.rectangles;
                int level = 0;
                int index = 0;

                foreach(List<Task> list in Form4.plan.Sorted)
                {
                    foreach(Task t in list)
                    {
                        Console.WriteLine(" form 1 / STart: " + t.Start.ToString("dd/MM/yyyy") + " End: " + t.End.ToString("dd/MM/yyyy"));
                    }
                }
                CreateButton(Form4.plan.Start.ToString("dd/MM/yyyy"), pnGanta.Location.X - 10, pnGanta.Location.Y - 30, 50, 30, true);
                for (int i = 0; i < rect.Count; i++)
                {

                    if(level < Form4.plan.Sorted.Count)
                    {
                        rect[i].Draw(gr);
                        CreateButton(Form4.plan.Sorted[level][index].End.ToString("dd/MM/yyyy"), (int)(pnGanta.Location.X + rect[i + 2].x + rect[i + 2].width - 10), pnGanta.Location.Y - 30, 50, 30, true);

                        if (Form4.plan.Sorted[level].Count == index + 1)
                        {
                            level++;
                            index = 0;
                        }
                        else { index++; }
                    }
                    
                    

                   
                   

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for(int i = 0; i < Form4.plan.Tasks.Count; i++)
            {    
                y = (i) * pnGanta.Height / Form4.plan.Tasks.Count;
                CreateButton(Form4.plan.Tasks[i].Name, 5, y + 52, 30, pnGanta.Height/ Form4.plan.Tasks.Count, false, i + 1);
            }



        }

        private void btnToMain_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Visible = true;
            this.Visible = false;
        }

        private void pnGanta_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangle r in rect)
            {
                r.Draw(gr);
            }
        }

        private void form2_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X + " hui " + e.Y);
        }

      

        private void CreateButton(string text, int x, int y, int width, int height, bool date = false, int index = default(int))
        {
            Button l = new Button();
            if (!date) l.Text = index.ToString();
            else l.Text = text;
            l.Location = new Point(x, y);
            l.Size = new Size(width, height);
            //Console.WriteLine(l.Location.X + " - location - " + l.Location.Y + " - size - " + l.Width + " " + l.Height);
            l.Tag = text;
            this.Controls.Add(l);
            l.Click += new EventHandler(bt_Click);
        }
        private void bt_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button bt = sender as System.Windows.Forms.Button;

            string t = bt.Tag as string;
            MessageBox.Show( t);

        }


    }
}
