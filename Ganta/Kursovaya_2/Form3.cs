using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_2
{
    public partial class Form3 : Form
    {
        Graphics gr;

        public Form3()
        {
            InitializeComponent();
            gr = pnTree.CreateGraphics();
            pnTree.AutoScroll = true;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                DrawTree(Form4.plan.Sorted);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void bt_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string str = "Предыдущие: \n";
            Task t = b.Tag as Task;
            Console.WriteLine(t.Name);
            foreach(Task t1 in t.Previous)
            {
                str += t1.Name + ", ";
            }
            str.Remove(str.Length - 1);
            str += "\n\n Исполнитель: " + t.actualPers.Name + "\n\nСложность: " + t.Complexity;
            
           
                

            MessageBox.Show(str);
        }
        private void DrawTree(List<List<Task>> sorted)
        {
            int h = 50;
            int w = 100;
            int x = 20;
            int y = 100;
            for(int level = 0; level < sorted.Count; level++)
            {
                for(int j = 0; j < sorted[level].Count; j++)
                {
                    Console.WriteLine("---" + sorted[level][j].Previous.Count);
                    Button b = new Button();
                    b.Size = new Size(w, h);
                    b.Location = new Point(x, y);
                    b.Text = sorted[level][j].Name;
                    b.Tag = sorted[level][j];
                    pnTree.Controls.Add(b);
                    b.Click += new EventHandler(bt_Click);
                    y += 70;

                }
                x += 130;
                y = 100;

            }
        }

        private void btnToMain_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Visible = false;
        }

        private void btnToPlan_Click(object sender, EventArgs e)
        {
            form2 fPlan = new form2();
            this.Visible = false;
            fPlan.Show();
            
        }

        private void btnCriticalPath_Click(object sender, EventArgs e)
        {
            string name = "Критический путь";
            string path = "";
            List<Task> crit = Form4.plan.criticalPath;
                

            foreach(Task t in crit)
            {
                path += t.Name + ", ";
            }
            path.Remove(path.Length - 1);
            path += "\n\nСложность = ";
            path +=  Form4.plan.MaxComplexity;

            MessageBox.Show(path, name);
        }

        private void btnAllTasks_Click(object sender, EventArgs e)
        {
            string name = "Все задачи";
            string tasks = "";
            int counter = 0;

            foreach (Task t in Form4.plan.Tasks)
            {
                counter++;
                tasks += counter + ") " +  t.Name + "\n";
            }
            MessageBox.Show(tasks, name);
        }

        private void btnAllWorkers_Click(object sender, EventArgs e)
        {
            string name = "Все исполнители";
            string persons = "";
            int counter = 1;

            foreach (Person p in Form4.plan.Persons)
            {
                persons += counter + ") " + p.Name + "\n";
                counter++;
            }
            MessageBox.Show(persons, name);
        }
    }
}
